using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Catálogo_de_Pernos_ESAN_Ferretería
{
    public partial class m12 : Form
    {
        string conexión = @"Server=192.168.1.191\SQLEXPRESS;
                          Database=P_MilimetroPulgada;
                          User Id=usuario;
                          Password=esan;
                          Encrypt=True;
                          TrustServerCertificate=True;";
        public string MedidaSeleccionada { get; set; }
        Dictionary<string, string> mapaTablas = new Dictionary<string, string>()
    {
        { "M12 1.25", "M12" },
        { "M12 1.5", "M12_15" },
        { "M12 1.75", "M12_175" }
    };

        public m12()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;

            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = 0;

            this.Location = new Point(x, y);

            dgvM12.ReadOnly = true;
            dgvM12.AllowUserToAddRows = false;
        }

        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MOVE = 0xF010;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND)
            {
                int command = m.WParam.ToInt32() & 0xfff0;
                if (command == SC_MOVE)
                {
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void m12_Load(object sender, EventArgs e)
        {
            cmbM12.Items.Clear();

            cmbM12.Items.Add("M12 1.25");
            cmbM12.Items.Add("M12 1.5");
            cmbM12.Items.Add("M12 1.75");

            if (!string.IsNullOrEmpty(MedidaSeleccionada))
            {
                cmbM12.SelectedItem = MedidaSeleccionada;
            }
            else
            {
                cmbM12.SelectedIndex = 0;
            }
        }
        private void CargarDatos(string tabla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexión))
                {
                    string query = $"SELECT Milimetros, Largo12, DiametroEnPulgadas FROM {tabla}";

                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();

                    conexion.Open();
                    adaptador.Fill(dt);

                    dgvM12.DataSource = null;
                    dgvM12.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbM12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbM12.SelectedItem == null) return;

            string seleccion = cmbM12.SelectedItem.ToString();

            if (mapaTablas.ContainsKey(seleccion))
            {
                CargarDatos(mapaTablas[seleccion]);
            }
        }
    }
}
