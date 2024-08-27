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
    public partial class CircleInputDialog : Form
    {
        public float CenterX { get; private set; }
        public float CenterY { get; private set; }
        public float Radius { get; private set; }
        public bool IsCancelled { get; private set; }

        public CircleInputDialog()
        {
            InitializeComponent();
            IsCancelled = true; // Başlangıçta iptal varsayılan olarak ayarlanır
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtCenterX.Text, out float centerX) &&
                float.TryParse(txtCenterY.Text, out float centerY) &&
                float.TryParse(txtRadius.Text, out float radius))
            {
                CenterX = centerX;
                CenterY = centerY;
                Radius = radius;
                IsCancelled = false; // Kullanıcı giriş yaptı ve iptal edilmedi
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli sayısal değerler girin.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsCancelled = true; // İptal durumunu kaydet
            this.Close();
        }

        private void txtCenterX_TextChanged(object sender, EventArgs e)
        {

        }

        private void CircleInputDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
