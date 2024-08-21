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
        private bool isLineMode = false;
        private bool isDotMode = false;
        private System.Windows.Forms.Button activeButton;
        xmlOperations xmlHandler = new xmlOperations();

        public cadMain()
        {
            InitializeComponent();
            //this.MouseClick += new MouseEventHandler(this.OnMouseClick);

            this.MouseDown += new MouseEventHandler(cadMain_MouseDown);
            // XML dosyasını oluştur
            xmlHandler.CreateXmlFile();

            Line = new line();

            Dot = new dot();

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
                if (activeButton == line)
                {
                    Line.HandleMouseClick(e.X, e.Y, xmlHandler);  // Burada 'line' sınıfının instance'ını kullanıyoruz
                    string message = $"X={e.X}, Y={e.Y}";
                    toolTip1.Show(message, this, e.X, e.Y);
                }
                else if (activeButton == point)
                {
                    Dot.HandleMouseClick(e.X, e.Y, xmlHandler);   // Burada 'dot' sınıfının instance'ını kullanıyoruz
                    string message = $"X={e.X}, Y={e.Y}";
                    toolTip1.Show(message, this, e.X, e.Y);
                }
            }
        }
        

        private void line_Click(object sender, EventArgs e)
        {
            activeButton = line;
        }   

        private void point_Click(object sender, EventArgs e)
        {
            activeButton = point;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
