using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace cadStart.Libs.Shapes
{
    internal class dot
    {
        private PointF point; 
        public void AddPoint(PointF Point)
        {
            // Var olan XML dosyasını yükle
            XDocument xmlDocument = XDocument.Load("cadData.xml");

            // points elementini bul
            XElement pointsElement = xmlDocument.Element("cadData").Element("points");

            // Yeni bir Point elementi oluştur
            XElement pointElement = new XElement("Point");
            pointElement.SetAttributeValue("X", Point.X);
            pointElement.SetAttributeValue("Y", Point.Y);

            // Point elementini points elementine ekle
            pointsElement.Add(pointElement);

            // XML dosyasını güncelle
            xmlDocument.Save("cadData.xml");

            Console.WriteLine("Point başarıyla XML dosyasına eklendi.");
        }
        public void AddPoint(float x, float y)
        {
            XDocument xmlDocument = XDocument.Load("cadData.xml");

            XElement pointsElement = xmlDocument.Element("cadData").Element("points");

            XElement pointElement = new XElement("point");
            pointElement.SetAttributeValue("X", x);
            pointElement.SetAttributeValue("Y", y);

            pointsElement.Add(pointElement);

            xmlDocument.Save("cadData.xml");

            Console.WriteLine("Point başarıyla XML dosyasına eklendi.");
        }
        public void HandleMouseClick(float mouseX, float mouseY, xmlOperations xmlHandler)
        {
        
            point = new PointF(mouseX, mouseY);

            AddPoint(point);

            Console.WriteLine($"Point Set: ({mouseX}, {mouseY})"); 

        }
    }
}
