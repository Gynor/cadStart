using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace cadStart.Libs
{
    internal class line
    {
        public PointF StartPoint { get; set; }
        public PointF EndPoint { get; set; }

        public line(PointF startPoint, PointF endPoint, xmlOperations xmlHandler)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;

            // Çizgiyi XML dosyasına kaydet
            xmlHandler.AddLine(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
        }

        public line(float startX, float startY, float endX, float endY, xmlOperations xmlHandler)
        {
            StartPoint = new PointF(startX, startY);
            EndPoint = new PointF(endX, endY);

            // Çizgiyi XML dosyasına kaydet
            xmlHandler.AddLine(startX, startY, endX, endY);
        }
    }
}