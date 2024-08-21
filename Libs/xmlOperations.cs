using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace cadStart.Libs
{
    public class xmlOperations
    {
        public void CreateXmlFile()
        {
            // Root elementleri oluştur
            XElement points = new XElement("points");
            XElement lines = new XElement("lines");

            // Root elementi oluştur ve alt elementleri ekle
            XElement root = new XElement("cadData");
            root.Add(points);
            root.Add(lines);

            // XML belgesini oluştur
            XDocument xmlDocument = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), root);

            // XML belgesini dosyaya kaydet
            xmlDocument.Save("cadData.xml");

            Console.WriteLine("XML dosyası başarıyla oluşturuldu.");
        }
        public void AddPointToXml(PointF point)
        {
            // Var olan XML dosyasını yükle
            XDocument xmlDocument = XDocument.Load("cadData.xml");

            // points elementini bul
            XElement pointsElement = xmlDocument.Element("cadData").Element("points");

            // Yeni bir Point elementi oluştur
            XElement pointElement = new XElement("Point");
            pointElement.SetAttributeValue("X", point.X);
            pointElement.SetAttributeValue("Y", point.Y);

            // Point elementini points elementine ekle
            pointsElement.Add(pointElement);

            // XML dosyasını güncelle
            xmlDocument.Save("cadData.xml");

            Console.WriteLine("Point başarıyla XML dosyasına eklendi.");
        }
        public void AddLine(float startX, float startY, float endX, float endY)
        {
            XDocument xmlDocument = XDocument.Load("cadData.xml");

            XElement linesElement = xmlDocument.Element("cadData").Element("lines");

            XElement lineElement = new XElement("line");
            lineElement.SetAttributeValue("StartX", startX);
            lineElement.SetAttributeValue("StartY", startY);
            lineElement.SetAttributeValue("EndX", endX);
            lineElement.SetAttributeValue("EndY", endY);

            linesElement.Add(lineElement);

            xmlDocument.Save("cadData.xml");
        }

    }
}
