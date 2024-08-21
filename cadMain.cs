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

namespace cadStart
{
    public partial class cadMain : Form
    {
        public cadMain()
        {
            InitializeComponent();
            this.MouseClick += new MouseEventHandler(this.OnMouseClick);

            xmlOperations.CreateXmlFile();
        }
        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            // Capture the X and Y coordinates of the mouse click
            float x = e.X;
            float y = e.Y;

            // Create a PointF using the captured coordinates
            PointF clickedPoint = new PointF(x, y);

            // You can now use clickedPoint for other operations
            MessageBox.Show($"Clicked at: X={clickedPoint.X}, Y={clickedPoint.Y}");
        }


    }
}
