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
    internal class line
    {
        public PointF StartPoint { get; set; }
        public PointF EndPoint { get; set; }

        private bool isStartPointSet = false;

        public void addLine(PointF startPoint, PointF endPoint, xmlOperations xmlHandler)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;

            // Çizgiyi XML dosyasına kaydet
            xmlHandler.AddLine(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);

            xmlHandler.AddPointToXml(startPoint);
            xmlHandler.AddPointToXml(endPoint);
        }

        public void addLine(float startX, float startY, float endX, float endY, xmlOperations xmlHandler)
        {
            StartPoint = new PointF(startX, startY);
            EndPoint = new PointF(endX, endY);

            // Çizgiyi XML dosyasına kaydet
            xmlHandler.AddLine(startX, startY, endX, endY);

            xmlHandler.AddPointToXml(StartPoint);
            xmlHandler.AddPointToXml(EndPoint);
        }

        public void HandleMouseClick(float mouseX, float mouseY, xmlOperations xmlHandler)
        {
            if (!isStartPointSet)
            {
                StartPoint = new PointF(mouseX, mouseY);
                isStartPointSet = true;
                Console.WriteLine($"Start Point Set: ({mouseX}, {mouseY})");
            }
            else
            {
                EndPoint = new PointF(mouseX, mouseY);
                isStartPointSet = false;
                //Console.WriteLine($"End Point Set: ({mouseX}, {mouseY})");

                // Çizgiyi XML dosyasına kaydet
                addLine(StartPoint, EndPoint, xmlHandler);
            }
        }
    }
}