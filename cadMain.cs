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
using System.Threading;

namespace cadStart
{
    public partial class cadMain : Form
    {
        private float zoomLevel = 1.0f;
        private const float maxZoomLevel = 1000.0f;
        private const float minZoomLevel = 0.1f;
        private PointF panOffset = PointF.Empty;
        private PointF panStartPoint = Point.Empty;
        private bool isPanning = false;
        PointF  lastMousePosition = PointF.Empty;
        private PointF originOffset; // Merkez noktası için offset



        private line Line;
        private dot Dot;
        private circle  Circle;
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

            this.MouseWheel += new MouseEventHandler(cadStart_MouseWheel);

            this.MouseDown += new MouseEventHandler(cadMain_MouseDown);

            this.MouseUp += new MouseEventHandler(cadStart_MouseUp);

            this.MouseMove += new MouseEventHandler(OnMouseMove);

            // XML dosyasını oluştur
            xmlHandler.CreateXmlFile();

            Line = new line();

            Dot = new dot();

            Circle = new circle();

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

            //e.Graphics.TranslateTransform(ClientSize.Width / 2, ClientSize.Height / 2); // Ortaya taşıma
            e.Graphics.TranslateTransform(panOffset.X, panOffset.Y);
            e.Graphics.ScaleTransform(zoomLevel, zoomLevel);

            zoomLabel.Text = $"Zoom: {zoomLevel:F2}x";

            // İstediğiniz renk ve fırça ile noktaları çizdirin
            Brush brush = new SolidBrush(Color.Blue);

            Pen pen = new Pen(Color.Black, 2f/zoomLevel);


            Draw.DrawPoints(g,brush, zoomLevel);

            Draw.DrawLines(g, pen);

            Draw.DrawCircle(g, pen);
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
                    float tolerance = 10f;

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
                    else if (selectedPoint.HasValue && activeButton == circle)
                    {
                        Circle.HandleMouseClickSelect(selectedPoint.Value.X, selectedPoint.Value.Y, xmlHandler);  // Burada 'line' sınıfının instance'ını kullanıyoruz
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
                    else if (activeButton == circle)
                    {
                        Circle.HandleMouseClick(e.X, e.Y, xmlHandler);   // Burada 'circle' sınıfının instance'ını kullanıyoruz
                        string message = $"X={e.X}, Y={e.Y}";
                        toolTip1.Show(message, this, e.X, e.Y, 600);

                        this.Invalidate();
                    }
                }
            }
            if (e.Button == MouseButtons.Middle)
            {
                isPanning = true;
                lastMousePosition = e.Location;
                Cursor = Cursors.Hand; // Pan sırasında el ikonuna geç
            }
        }
        private void circle_Click(object sender, EventArgs e)
        {
            if (activeButton == circle)
            {
                activeButton = null;
            }
            else
            {
                activeButton = circle;
            }
            UpdateButtonStyles();
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
            if (activeButton == circle)
            {
                circle.BackColor = Color.Gray; // Buton aktifse gri renk
            }
            else
            {
                circle.BackColor = SystemColors.Control; // Buton aktif değilse varsayılan renk
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
        private void ManualLine_Click(object sender, EventArgs e)
        {
            using (var lineDialog = new LineInputDialog())
            {
                var result = lineDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Get the start and end points from the dialog
                    var startPoint = lineDialog.StartPoint;
                    var endPoint = lineDialog.EndPoint;

                    // Use these points to add the line and save to XML
                    var line = new line();

                    line.addLineManual(startPoint, endPoint, xmlHandler);
                    xmlHandler.AddPointToXml(startPoint);
                    xmlHandler.AddPointToXml(endPoint);
                }
                else if (result == DialogResult.Cancel)
                {
                    // User cancelled the operation, do nothing
                    Console.WriteLine("Operation canceled by the user.");
                }
            }
            this.Invalidate();
        }
        private void ManualCircle_Click(object sender, EventArgs e)
        {
            using (var dialog = new CircleInputDialog())
            {
                var result = dialog.ShowDialog();
                if (!dialog.IsCancelled)
                {
                    float centerX = dialog.CenterX;
                    float centerY = dialog.CenterY;
                    float radius = dialog.Radius;
                    PointF center = new PointF(centerX, centerY);

                    // XML dosyasına çemberi yazma işlemi
                    var xmlHandler = new xmlOperations();
                    xmlHandler.AddCircle(centerX, centerY, radius,0,360);

                    xmlHandler.AddPointToXml(center);

                    // Çemberi çizmek için kendi yöntemlerinizi çağırabilirsiniz
                    // DrawCircle(centerX, centerY, radius);
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Invalidate();
        }
        private void ManualArc_Click(object sender, EventArgs e)
        {
            ArcInputDialog arcInput = new ArcInputDialog();
            arcInput.ShowDialog();

            if (!arcInput.IsCancelled)
            {
                // Kullanıcının girdilerini alın
                float centerX = arcInput.CenterX;
                float centerY = arcInput.CenterY;
                PointF center = new PointF(centerX, centerY);
                float radius = arcInput.Radius;
                float startAngle = arcInput.StartAngle;
                float sweepAngle = arcInput.SweepAngle;

                // Burada yay çizimi için gerekli işlemleri yapabilirsiniz
                // Ayrıca başlangıç ve bitiş noktalarını hesaplayabilirsiniz
                float startX = centerX + radius * (float)Math.Cos(startAngle * Math.PI / 180);
                float startY = centerY + radius * (float)Math.Sin(startAngle * Math.PI / 180);
                PointF start = new PointF(startX, startY);

                float endX = centerX + radius * (float)Math.Cos((startAngle + sweepAngle) * Math.PI / 180);
                float endY = centerY + radius * (float)Math.Sin((startAngle + sweepAngle) * Math.PI / 180);
                PointF end = new PointF(endX, endY);

                // XML dosyasına çemberi yazma işlemi
                var xmlHandler = new xmlOperations();
                xmlHandler.AddCircle(centerX, centerY, radius, startAngle, sweepAngle);

                xmlHandler.AddPointToXml(center);
                xmlHandler.AddPointToXml(start);
                xmlHandler.AddPointToXml(end);

            }
            else
            {
                MessageBox.Show("İşlem iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Invalidate();
        }
        private void ManualPoint_Click(object sender, EventArgs e)
        {
            PointInputDialog pointInput = new PointInputDialog();
            pointInput.ShowDialog();

            if (!pointInput.IsCancelled)
            {
                // Kullanıcının girdilerini alın
                float x = pointInput.X;
                float y = pointInput.Y;

                PointF point = new PointF(x, y);

                xmlHandler.AddPointToXml(point);
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Invalidate();
        }

        private void cadMain_Load(object sender, EventArgs e)
        {

        }

        private void cadStart_MouseWheel(object sender, MouseEventArgs e)
        {
            float zoomFactor = 1.2f;  // Zoom katsayısı
            PointF mousePosition = e.Location;

            PointF screenPosition = new PointF(
             (mousePosition.X - ClientSize.Width / 2 - panOffset.X) / zoomLevel,
             -(mousePosition.Y - ClientSize.Height / 2 - panOffset.Y) / zoomLevel
   );

            if (e.Delta > 0) // Zoom in
            {
                zoomLevel *= zoomFactor;
            }
            else if (e.Delta < 0) // Zoom out
            {
                zoomLevel /= zoomFactor;
            }

            // Zoom yaptıktan sonra mouse konumunu koruyarak kaydırma
            float newPanX = (mousePosition.X - panOffset.X) * zoomFactor - mousePosition.X;
            float newPanY = (mousePosition.Y - panOffset.Y) * zoomFactor - mousePosition.Y;

            panOffset.X += newPanX;
            panOffset.Y += newPanY;

            zoomLabel.Text = $"Zoom: {zoomLevel:F1}"; // Zoom seviyesini güncelle
            this.Invalidate();  // Ekranı yeniden çiz
        }


        private void OnMouseMove(object sender, MouseEventArgs e)
        {

            if (isPanning)
            {
                // Pan işlemi
                panOffset.X += (e.X - lastMousePosition.X) / zoomLevel;
                panOffset.Y += (e.Y - lastMousePosition.Y) / zoomLevel;
                lastMousePosition = e.Location;

                this.Invalidate(); // Ekranı yeniden çiz
            }
        }
        private void cadStart_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                isPanning = false;
                Cursor = Cursors.Default; // Pan sona erince imleci varsayılan yap
            }
        }
        private void Home_Click(object sender, EventArgs e)
        {
            zoomLevel = 1.0f;
            panOffset = PointF.Empty;

            this.Invalidate();  // Ekranı yeniden çiz
        }
    }
}
