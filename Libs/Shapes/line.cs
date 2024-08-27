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
        public PointF TempPoint { get; set; }

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

        }
        public void addLineSelect(PointF startPoint, PointF endPoint, xmlOperations xmlHandler)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;

            // Çizgiyi XML dosyasına kaydet
            xmlHandler.AddLine(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
        }
        public void addLineSelect(float startX, float startY, float endX, float endY, xmlOperations xmlHandler)
        {
            StartPoint = new PointF(startX, startY);
            EndPoint = new PointF(endX, endY);

            // Çizgiyi XML dosyasına kaydet
            xmlHandler.AddLine(startX, startY, endX, endY);
        }

        public void HandleMouseClick(float mouseX, float mouseY, xmlOperations xmlHandler)
        {
            if (!isStartPointSet)
            {
                StartPoint = new PointF(mouseX, mouseY);
                isStartPointSet = true;
                Console.WriteLine($"Start Point Set: ({mouseX}, {mouseY})");
                xmlHandler.AddPointToXml(StartPoint);
            }
            else
            {
                EndPoint = new PointF(mouseX, mouseY);
                isStartPointSet = false;
                Console.WriteLine($"End Point Set: ({mouseX}, {mouseY})");
                xmlHandler.AddPointToXml(EndPoint);
                // Çizgiyi XML dosyasına kaydet
                addLine(StartPoint, EndPoint, xmlHandler);
            }

        }
        public void HandleMouseClickSelect(float mouseX, float mouseY, xmlOperations xmlHandler)
        {
            TempPoint = new PointF(mouseX, mouseY);

            if (!isStartPointSet)
            {
                StartPoint = TempPoint;
                isStartPointSet = true;
                Console.WriteLine($"Start Select Point Set: ({mouseX}, {mouseY})");
            }
            else if(StartPoint != TempPoint)
            {
                EndPoint = TempPoint;
                isStartPointSet = false;
                Console.WriteLine($"End Select Point Set: ({mouseX}, {mouseY})");

                // Çizgiyi XML dosyasına kaydet
                addLineSelect(StartPoint, EndPoint, xmlHandler);
                TempPoint = PointF.Empty;
            }

        }
    }
}