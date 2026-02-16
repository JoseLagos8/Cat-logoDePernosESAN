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


        List<Perno> pernos = new List<Perno>();

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

            CargarPernos();
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

        public void CargarPernos()
        {
            {
                pernos.Clear();

                pernos.Add(new Perno { Milimetro = "M6", Paso = "1.25", Pulgada = "1/4", Descripcion = "M6 x 1.25 (1/4\")", FormDestino = "FormM6" });

                pernos.Add(new Perno { Milimetro = "M8", Paso = "1.25", Pulgada = "5/16", Descripcion = "M8 x 1.25 (5/16\")", FormDestino = "FormM8" });

                pernos.Add(new Perno { Milimetro = "M10", Paso = "1.25", Pulgada = "3/8", Descripcion = "M10 x 1.25 (3/8\")", FormDestino = "FormM10_125" });
                pernos.Add(new Perno { Milimetro = "M10", Paso = "1.5", Pulgada = "3/8", Descripcion = "M10 x 1.5 (3/8\")", FormDestino = "FormM10_15" });

                pernos.Add(new Perno { Milimetro = "M12", Paso = "1.25", Pulgada = "1/2", Descripcion = "M12 x 1.25 (1/2\")", FormDestino = "FormM12_125" });
                pernos.Add(new Perno { Milimetro = "M12", Paso = "1.5", Pulgada = "1/2", Descripcion = "M12 x 1.5 (1/2\")", FormDestino = "FormM12_15" });
                pernos.Add(new Perno { Milimetro = "M12", Paso = "1.75", Pulgada = "1/2", Descripcion = "M12 x 1.75 (1/2\")", FormDestino = "FormM12_175" });
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.ToLower().Trim();

            var resultados = pernos
                .Where(p =>
                    p.Milimetro.ToLower().Contains(texto) ||
                    p.Paso.ToLower().Contains(texto) ||
                    p.Pulgada.ToLower().Contains(texto) ||
                    p.Descripcion.ToLower().Contains(texto)
                )
                .ToList();

            LBResultados.DataSource = null;
            LBResultados.DataSource = resultados;
            LBResultados.DisplayMember = "Descripcion";
            LBResultados.Visible = resultados.Count > 0;
        }
        private void LBResultados_DoubleClick(object sender, EventArgs e)
        {
            if (LBResultados.SelectedItem is Perno perno)
            {
                AbrirForm(perno.FormDestino);
                AgregarAlHistorial(perno);
            }
        }
        private void AbrirForm(string formDestino)
        {
            Form form = null;

            switch (formDestino)
            {
                case "FormM6": form = new m6(); break;
                case "FormM8": form = new m8(); break;

                case "FormM10_125": form = new m10(); break;
                case "FormM10_15": form = new m10(); break;

                case "FormM12_125": form = new m12(); break;
                case "FormM12_15": form = new m12(); break;
                case "FormM12_175": form = new m12(); break;
            }

            if (form != null)
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }
        
        private void AgregarAlHistorial(Perno p)
        {
            dgvHistorial.Rows.Add(
                p.Milimetro,
                p.Paso,
                p.Pulgada,
                DateTime.Now.ToString("dd/MM/yyyy HH:mm")
            );
        }
    }
}
