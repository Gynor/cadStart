using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace cadStart.Libs.Shapes
{
    internal class circle
    {
        public PointF CenterPoint { get; set; }
        public float Radius { get; set; }
        public float StartAngle { get; set; } = 0;
        public float SweepAngle { get; set; } = 360;

        public PointF TempPoint { get; set; }

        private bool isCenterPointSet = false;

        public void addCircle(PointF centerPoint, float radius, float startAngle, float sweepAngle, xmlOperations xmlHandler)
        {
            CenterPoint = centerPoint;
            Radius = radius;
            StartAngle = startAngle;
            SweepAngle = sweepAngle;

            // Çemberi XML dosyasına kaydet
            xmlHandler.AddCircle(centerPoint.X, centerPoint.Y, radius, startAngle, sweepAngle);
        }

        public void addCircle(float centerX, float centerY, float radius, float startAngle, float sweepAngle, xmlOperations xmlHandler)
        {
            CenterPoint = new PointF(centerX, centerY);
            Radius = radius;
            StartAngle = startAngle;
            SweepAngle = sweepAngle;

            // Çemberi XML dosyasına kaydet
            xmlHandler.AddCircle(centerX, centerY, radius, startAngle, sweepAngle);
        }

        public void HandleMouseClick(float mouseX, float mouseY, xmlOperations xmlHandler)
        {
            if (!isCenterPointSet)
            {
                CenterPoint = new PointF(mouseX, mouseY);
                isCenterPointSet = true;
                Console.WriteLine($"Center Point Set: ({mouseX}, {mouseY})");
                xmlHandler.AddPointToXml(CenterPoint);
            }
            else
            {
                float dx = mouseX - CenterPoint.X;
                float dy = mouseY - CenterPoint.Y;
                Radius = (float)Math.Sqrt(dx * dx + dy * dy);
                isCenterPointSet = false;
                Console.WriteLine($"Radius Set: {Radius}");
                // Çemberi XML dosyasına kaydet
                addCircle(CenterPoint, Radius, StartAngle, SweepAngle, xmlHandler);
            }
        }

        public void HandleMouseClickSelect(float mouseX, float mouseY, xmlOperations xmlHandler)
        {
            TempPoint = new PointF(mouseX, mouseY);

            if (!isCenterPointSet)
            {
                CenterPoint = TempPoint;
                isCenterPointSet = true;
                Console.WriteLine($"Center Select Point Set: ({mouseX}, {mouseY})");
            }
            else
            {
                float dx = TempPoint.X - CenterPoint.X;
                float dy = TempPoint.Y - CenterPoint.Y;
                Radius = (float)Math.Sqrt(dx * dx + dy * dy);
                isCenterPointSet = false;
                Console.WriteLine($"Radius Set: {Radius}");
                if (Radius > 0)
                {
                    // Çemberi XML dosyasına kaydet
                    addCircle(CenterPoint, Radius, StartAngle, SweepAngle, xmlHandler);
                }
            }
        }
    }

}

