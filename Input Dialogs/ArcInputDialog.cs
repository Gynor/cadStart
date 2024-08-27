using System;
using System.Windows.Forms;

namespace cadStart
{
    public partial class ArcInputDialog : Form
    {
        public float CenterX { get; private set; }
        public float CenterY { get; private set; }
        public float Radius { get; private set; }
        public float StartAngle { get; private set; }
        public float SweepAngle { get; private set; }
        public bool IsCancelled { get; private set; }

        public ArcInputDialog()
        {
            InitializeComponent();
            IsCancelled = true; // Başlangıçta iptal varsayılan olarak ayarlanır
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtCenterX.Text, out float centerX) &&
                float.TryParse(txtCenterY.Text, out float centerY) &&
                float.TryParse(txtRadius.Text, out float radius) &&
                float.TryParse(txtStartAngle.Text, out float startAngle) &&
                float.TryParse(txtSweepAngle.Text, out float sweepAngle))
            {
                CenterX = centerX;
                CenterY = centerY;
                Radius = radius;
                StartAngle = startAngle;
                SweepAngle = sweepAngle;
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
    }
}
