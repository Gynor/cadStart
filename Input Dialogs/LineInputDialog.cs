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
    public partial class LineInputDialog : Form
    {
        public PointF StartPoint { get; private set; }
        public PointF EndPoint { get; private set; }
        public LineInputDialog()
        {
            InitializeComponent();
        }
        private void submit_Click(object sender, EventArgs e)
        {
            if (float.TryParse(StartX.Text, out float startX) &&
                float.TryParse(StartY.Text, out float startY) &&
                float.TryParse(EndX.Text, out float endX) &&
                float.TryParse(EndY.Text, out float endY))
            {
                // Set the points
                StartPoint = new PointF(startX, startY);
                EndPoint = new PointF(endX, endY);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli sayısal değerler girin.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LineInputDialog_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LineInputDialog_Load_1(object sender, EventArgs e)
        {

        }

        private void StartX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
