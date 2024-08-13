using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadStart
{
    public partial class cadMain : Form
    {
        public cadMain()
        {
            InitializeComponent();
        }

        private void cadMain_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // e.Graphics nesnesi üzerinden çizim yapıyoruz.
            Graphics g = e.Graphics;

            // Yüksek hassasiyetli çizim için SmoothingMode'u ayarlayalım
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Örnek olarak bir dikdörtgen çizelim
            Pen pen = new Pen(Color.Black, 1);
            g.DrawRectangle(pen, 50, 50, 200, 100);

            // Bir daire (çember) çizelim
            g.DrawEllipse(pen, new Rectangle(100, 100, 100, 100));

            // Serbest bir çizgi çizelim
            g.DrawLine(pen, 10, 10, 300, 200);
        }
    }
}
