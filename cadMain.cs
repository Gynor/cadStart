using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cadStart.Libs;
using System.Xml;
using System.Xml.Linq;
using cadStart.Libs.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace cadStart
{
    public partial class cadMain : Form
    {
        private line Line;
        private dot Dot;
        private draw Draw;
        private bool isLineMode = false;
        private bool isDotMode = false;
        private System.Windows.Forms.Button activeButton;
        private System.Windows.Forms.Button selectButton;
        xmlOperations xmlHandler = new xmlOperations();
        private PointF? selectedPoint = null;

        public cadMain()
        {
            InitializeComponent();
            //this.MouseClick += new MouseEventHandler(this.OnMouseClick);

            this.MouseDown += new MouseEventHandler(cadMain_MouseDown);
            // XML dosyasını oluştur
            xmlHandler.CreateXmlFile();

            Line = new line();

            Dot = new dot();

            Draw = new draw("cadData.xml");

            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Graphics nesnesini al ve draw sınıfı ile noktaları çiz
            Graphics g = e.Graphics;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Daha yüksek kalite için diğer ayarlar
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            // İstediğiniz renk ve fırça ile noktaları çizdirin
            Brush brush = new SolidBrush(Color.Black);

            Pen pen = new Pen(Color.Black, 2f);


            Draw.DrawPoints(g,brush);

            Draw.DrawLines(g, pen);
        }
        //private void OnMouseClick(object sender, MouseEventArgs e)
        //{
        //    // Capture the X and Y coordinates of the mouse click
        //    float x = e.X;
        //    float y = e.Y;

        //    // Create a PointF using the captured coordinates
        //    PointF clickedPoint = new PointF(x, y);

        //    // You can now use clickedPoint for other operations
        //   // MessageBox.Show($"Clicked at: X={clickedPoint.X}, Y={clickedPoint.Y}");
        //}

        private void cadMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (selectButton == select)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("cadData.xml");
                    XmlNodeList pointNodes = xmlDoc.SelectNodes("/cadData/points/Point");

                    PointF clickedPoint = new PointF(e.X, e.Y);
                    // Tolerans (yakınlık kontrolü için)
                    float tolerance = 5f;

                    float minDistance = float.MaxValue;
                    PointF? closestPoint = null;

                    // XML dosyasındaki noktaları oku
                    foreach (XmlNode pointNode in pointNodes)
                    {
                        float x = float.Parse(pointNode.Attributes["X"].Value);
                        float y = float.Parse(pointNode.Attributes["Y"].Value);
                        PointF point = new PointF(x, y);

                        float distance = (float)Math.Sqrt(Math.Pow(clickedPoint.X - point.X, 2) + Math.Pow(clickedPoint.Y - point.Y, 2));

                        if (distance < tolerance && distance < minDistance && closestPoint!=point)
                        {
                            minDistance = distance;
                            closestPoint = point;
                        }
                    }

                    if (closestPoint.HasValue)
                    {
                        selectedPoint = closestPoint;
                        Console.WriteLine($"En yakın nokta seçildi: {selectedPoint}");
                    }
                    if (selectedPoint.HasValue && activeButton == line)
                    {
                        Line.HandleMouseClickSelect(selectedPoint.Value.X, selectedPoint.Value.Y, xmlHandler);  // Burada 'line' sınıfının instance'ını kullanıyoruz
                        string message = $"X={e.X}, Y={e.Y}";
                        toolTip1.Show(message, this, e.X, e.Y, 600);
                        this.Invalidate();
                    }
                    //else if (activeButton == point)
                    //{
                    //    Dot.HandleMouseClick(e.X, e.Y, xmlHandler);   // Burada 'dot' sınıfının instance'ını kullanıyoruz
                    //    string message = $"X={e.X}, Y={e.Y}";
                    //    toolTip1.Show(message, this, e.X, e.Y, 600);
                    //}
                }
                else
                {

                    if (activeButton == line)
                    {
                        Line.HandleMouseClick(e.X, e.Y, xmlHandler);  // Burada 'line' sınıfının instance'ını kullanıyoruz
                        string message = $"X={e.X}, Y={e.Y}";
                        toolTip1.Show(message, this, e.X, e.Y, 600);

                        this.Invalidate();
                    }
                    else if (activeButton == point)
                    {
                        Dot.HandleMouseClick(e.X, e.Y, xmlHandler);   // Burada 'dot' sınıfının instance'ını kullanıyoruz
                        string message = $"X={e.X}, Y={e.Y}";
                        toolTip1.Show(message, this, e.X, e.Y, 600);

                        this.Invalidate();
                    }
                }
            }
        }

        private void line_Click(object sender, EventArgs e)
        {
            
            if (activeButton == line)
            {
                activeButton = null;
            }
            else
            {
                activeButton = line;
            }
            UpdateButtonStyles();
        }   

        private void point_Click(object sender, EventArgs e)
        {
            if (activeButton == point)
            {
                activeButton = null;
            }
            else
            {
                activeButton = point;
            }
            UpdateButtonStyles();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {

            if (selectButton == select)
            {
                selectButton = null;
            }
            else
            {
                selectButton = select;
            }
            UpdateButtonStyles();
        }
        private void UpdateButtonStyles()
        {
            // Line butonunu kontrol et
            if (activeButton == line)
            {
                line.BackColor = Color.Gray; // Buton aktifse gri renk
            }
            else
            {
                line.BackColor = SystemColors.Control; // Buton aktif değilse varsayılan renk
            }

            // Point butonunu kontrol et
            if (activeButton == point)
            {
                point.BackColor = Color.Gray; // Buton aktifse gri renk
            }
            else
            {
                point.BackColor = SystemColors.Control; // Buton aktif değilse varsayılan renk
            }
            if (selectButton == select)
            {
                select.BackColor = Color.Gray; // Buton aktifse gri renk
            }
            else
            {
                select.BackColor = SystemColors.Control; // Buton aktif değilse varsayılan renk
            }
        }
    }
}
