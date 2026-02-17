using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Catálogo_de_Pernos_ESAN_Ferretería
{
    public partial class Catálogo_de_Tuercas : Form
    {
        string conexión = @"Server=JOLALA\SQLEXPRESS;
                        Database=TUERCAS_ESAN;
                        Trusted_Connection=True;
                        Encrypt=True;
                        TrustServerCertificate=True;";

        List<Tuerca> tuercas = new List<Tuerca>();
        Dictionary<string, int> contadorBusquedas = new Dictionary<string, int>();

        public Catálogo_de_Tuercas()
        {
            InitializeComponent();

            this.TopMost = true;
            this.ShowInTaskbar = true;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.Manual;
        }

        private void Catálogo_de_Tuercas_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Top;
            this.Location = new Point(x, y);

            CargarTuercas();

            dgvTuercas.DataSource = null;
            dgvTuercas.DataSource = tuercas;
        }
        public void CargarTuercas()
        {
            tuercas.Clear();

            tuercas.Add(new Tuerca { Milimetro = "M6", Paso = "1.25", Pulgada = "1/4" });

            tuercas.Add(new Tuerca { Milimetro = "M8", Paso = "1.25", Pulgada = "5/16" });

            tuercas.Add(new Tuerca { Milimetro = "M10", Paso = "1.25", Pulgada = "3/8" });
            tuercas.Add(new Tuerca { Milimetro = "M10", Paso = "1.5", Pulgada = "3/8" });

            tuercas.Add(new Tuerca { Milimetro = "M12", Paso = "1.25", Pulgada = "1/2" });
            tuercas.Add(new Tuerca { Milimetro = "M12", Paso = "1.5", Pulgada = "1/2" });
            tuercas.Add(new Tuerca { Milimetro = "M12", Paso = "1.75", Pulgada = "1/2" });
        }

        private void pernosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ventanaPernos = new Form1();
            this.Hide();

            ventanaPernos.FormClosed += (s, args) => this.Show();
            ventanaPernos.Show();
        }
    }
}
