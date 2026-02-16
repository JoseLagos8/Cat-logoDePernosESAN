using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Catálogo_de_Pernos_ESAN_Ferretería
{

    public partial class Form1 : Form

    {
        string conexión = @"Server=JOLALA\SQLEXPRESS;
                        Database=PERNOS_ESAN;
                        Trusted_Connection=True;
                        Encrypt=True;
                        TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();

            this.TopMost = true;
            this.ShowInTaskbar = true;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.Manual;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Top;

            this.Location = new Point(x, y);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnM6_Click(object sender, EventArgs e)
        {
            this.Hide();
            m6 formM6 = new m6();
            formM6.ShowDialog();
            this.Show();
        }

        private void btmM8_Click(object sender, EventArgs e)
        {
            this.Hide();
            m8 formM8 = new m8();
            formM8.ShowDialog();
            this.Show();
        }

        private void btnM10_Click(object sender, EventArgs e)
        {
            this.Hide();
            m10 formM10 = new m10();
            formM10.ShowDialog();
            this.Show();
        }

        private void btnM12_Click(object sender, EventArgs e)
        {
            this.Hide();
            m12 formM12 = new m12();
            formM12.ShowDialog();
            this.Show();
        }
    }
}
