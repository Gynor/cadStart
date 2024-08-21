using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace cadStart.Libs.Shapes
{
    internal class circle
    {
        /*        
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
    public partial class Form1 : Form
    {
        private PictureBox pictureBox;

        public Form1()
        {
            // PictureBox'ı form üzerinde başlatma
            pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            this.Controls.Add(pictureBox);

            // Paint olayına bir event handler ekleme
            pictureBox.Paint += pictureBox_Paint;
        }
        public void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            DrawCircle(e.Graphics, 100, 100, 50, 0, 180);

        }
        private void DrawCircle(Graphics g, float centerX, float centerY, float radius, float startAngle, float sweepAngle)
        {
            // Çizim için bir kalem oluşturma
            Pen pen = new Pen(Color.Black, 2);

            // Parametrik denklem ile çember yayının noktalarını hesaplama
            int pointsCount = 1000; // Nokta sayısı, çizimin hassasiyetini belirler
            PointF[] points = new PointF[pointsCount];

            for (int i = 0; i < pointsCount; i++)
            {
                float theta = startAngle + (sweepAngle * i) / (pointsCount - 1);
                double angleRad = Math.PI * theta / 180.0; // Açıyı radyana çevirme
                float x = centerX + radius * (float)Math.Cos(angleRad);
                float y = centerY + radius * (float)Math.Sin(angleRad);
                points[i] = new PointF(x, y);
            }

            // Hesaplanan noktaları birleştirerek çemberi çizme
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

         */
    }
}
