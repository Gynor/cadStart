using System;
using System.Windows.Forms;

namespace cadStart
{
    public partial class PointInputDialog : Form
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public bool IsCancelled { get; private set; }

        public PointInputDialog()
        {
            InitializeComponent();
            IsCancelled = true; // Başlangıçta iptal varsayılan olarak ayarlanır
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtX.Text, out float x) &&
                float.TryParse(txtY.Text, out float y))
            {
                X = x;
                Y = y;
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
