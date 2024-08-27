using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace cadStart.Libs
{
    public class draw
    {
        private List<PointF> points;
        private List<Tuple<PointF, PointF>> lines;
        private List<Tuple<PointF, float, float, float>> circles;

        public draw(string xmlFilePath)
        {
            points = new List<PointF>();
            LoadPointsFromXml(xmlFilePath);
            lines = new List<Tuple<PointF, PointF>>();
            LoadLinesFromXml(xmlFilePath);
            circles = new List<Tuple<PointF, float, float, float>>();
            LoadCirclesFromXml(xmlFilePath);

        }

        // XML'deki noktaları yükleme metodu
        private void LoadPointsFromXml(string xmlFilePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            XmlNodeList pointNodes = xmlDoc.SelectNodes("/cadData/points/Point");
            foreach (XmlNode pointNode in pointNodes)
            {
                float x = float.Parse(pointNode.Attributes["X"].Value);
                float y = float.Parse(pointNode.Attributes["Y"].Value);
                PointF point = new PointF(x, y);
                points.Add(point);
            }
        }
        private void LoadLinesFromXml(string xmlFilePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            XmlNodeList lineNodes = xmlDoc.SelectNodes("/cadData/lines/Line");
            foreach (XmlNode lineNode in lineNodes)
            {
                float startX = float.Parse(lineNode.Attributes["StartX"].Value);
                float startY = float.Parse(lineNode.Attributes["StartY"].Value);
                float endX = float.Parse(lineNode.Attributes["EndX"].Value);
                float endY = float.Parse(lineNode.Attributes["EndY"].Value);

                PointF startPoint = new PointF(startX, startY);
                PointF endPoint = new PointF(endX, endY);

                lines.Add(new Tuple<PointF, PointF>(startPoint, endPoint));
            }
        }
        private void LoadCirclesFromXml(string xmlFilePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            XmlNodeList circleNodes = xmlDoc.SelectNodes("/cadData/circles/Circle");
            foreach (XmlNode circleNode in circleNodes)
            {
                float centerX = float.Parse(circleNode.Attributes["CenterX"].Value);
                float centerY = float.Parse(circleNode.Attributes["CenterY"].Value);
                float radius = float.Parse(circleNode.Attributes["Radius"].Value);
                float startAngle = float.Parse(circleNode.Attributes["StartAngle"].Value);
                float sweepAngle = float.Parse(circleNode.Attributes["SweepAngle"].Value);

                PointF centerPoint = new PointF(centerX, centerY);

                circles.Add(new Tuple<PointF, float, float, float>(centerPoint, radius, startAngle, sweepAngle));
            }
        }

        // Tüm noktaları içi dolu daire olarak çizdirme metodu
        public void DrawPoints(Graphics g, Brush brush)
        {
            float radius = 4f;
            // XML dosyasını yükle
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("cadData.xml");

            // Tüm Point düğümlerini seç
            XmlNodeList pointNodes = xmlDoc.SelectNodes("/cadData/points/Point");

            // Her bir Point düğümü üzerinde işlem yap
            foreach (XmlNode pointNode in pointNodes)
            {
                // X ve Y değerlerini al
                float x = float.Parse(pointNode.Attributes["X"].Value);
                float y = float.Parse(pointNode.Attributes["Y"].Value);

                // Noktayı bir daire olarak çiz
                g.FillEllipse(brush, x - radius / 2, y - radius / 2, radius, radius);
            }
        }
        public void DrawLines(Graphics g, Pen pen) 
        {
            // XML dosyasını yükle
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("cadData.xml");

            // Tüm line düğümlerini seç
            XmlNodeList lineNodes = xmlDoc.SelectNodes("/cadData/lines/line");
            foreach (XmlNode lineNode in lineNodes)
            {
                float startX = float.Parse(lineNode.Attributes["StartX"].Value);
                float startY = float.Parse(lineNode.Attributes["StartY"].Value);
                float endX = float.Parse(lineNode.Attributes["EndX"].Value);
                float endY = float.Parse(lineNode.Attributes["EndY"].Value);

                PointF startPoint = new PointF(startX, startY);
                PointF endPoint = new PointF(endX, endY);

                // Çizgiyi çiz
                g.DrawLine(pen, startPoint, endPoint);
            }
        }
        public void DrawCircle(Graphics g, Pen pen) 
        {
            // XML dosyasını yükle
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("cadData.xml");

            // Tüm circle düğümlerini seç
            XmlNodeList circleNodes = xmlDoc.SelectNodes("/cadData/circles/circle");
            foreach (XmlNode circleNode in circleNodes)
            {
                float centerX = float.Parse(circleNode.Attributes["CenterX"].Value);
                float centerY = float.Parse(circleNode.Attributes["CenterY"].Value);
                float radius = float.Parse(circleNode.Attributes["Radius"].Value);
                float startAngle = float.Parse(circleNode.Attributes["StartAngle"].Value);
                float sweepAngle = float.Parse(circleNode.Attributes["SweepAngle"].Value);

                PointF centerPoint = new PointF(centerX, centerY);

                // Çemberin dışını saran dikdörtgeni belirleyin
                RectangleF rect = new RectangleF(
                    centerPoint.X - radius,
                    centerPoint.Y - radius,
                    2 * radius,
                    2 * radius);

                // Belirtilen açılarla yay çizin
                g.DrawArc(pen, rect, startAngle, sweepAngle);
            }

        }
        public void DrawArc(Graphics graphics, Pen pen)
        {
            // XML dosyasını yükle
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("cadData.xml");
        }
    }
}
