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
    public partial class PernosGrandes : Form
    {
        string conexión = @"Server=192.168.1.191\SQLEXPRESS;
                        Database=P_Grandes;
                        Trusted_Connection=True;
                        Encrypt=True;
                        TrustServerCertificate=True;";

        Dictionary<string, string> mapaTablas = new Dictionary<string, string>()
    {
        { "Perno Fino", "PernoFino" },
        { "Perno Corriente", "PernoCorriente" }
    };

        public PernosGrandes()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;

            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = 0;

            this.Location = new Point(x, y);

            dgvPernoG.ReadOnly = true;
            dgvPernoG.AllowUserToAddRows = false;
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

        private void PernosGrandes_Load(object sender, EventArgs e)
        {
            cmbPernoG.Items.Add("Perno Fino");
            cmbPernoG.Items.Add("Perno Corriente");

            cmbPernoG.SelectedIndex = 0;
        }

        private void cmbPernoG_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string seleccion = cmbPernoG.SelectedItem.ToString();

            if (mapaTablas.ContainsKey(seleccion))
            {
                CargarDatos(mapaTablas[seleccion]);
            }
        }
        private void CargarDatos(string tabla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexión))
                {
                    string query = $"SELECT * FROM {tabla}";

                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();

                    conexion.Open();
                    adaptador.Fill(dt);

                    dgvPernoG.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
            if (dgvPernoG.Columns.Count > 0)
            {
                dgvPernoG.Columns[0].Width = 300;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
