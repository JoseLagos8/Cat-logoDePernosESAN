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
    public partial class m10 : Form
    {
        string conexión = @"Server=192.168.1.191\SQLEXPRESS;
                        Database=P_MilimetroPulgada;
                        Trusted_Connection=True;
                        Encrypt=True;
                        TrustServerCertificate=True;";
        public string MedidaSeleccionada { get; set; }
        Dictionary<string, string> mapaTablas = new Dictionary<string, string>()
    {
        { "M10 1.25", "M10" },
        { "M10 1.5", "M10_15" }
    };
        public m10()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;

            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = 0;

            this.Location = new Point(x, y);

            dgvM10.ReadOnly = true;
            dgvM10.AllowUserToAddRows = false;
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
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void m10_Load(object sender, EventArgs e)
        {
            cmbM10.Items.Add("M10 1.25");
            cmbM10.Items.Add("M10 1.5");

            cmbM10.SelectedIndex = 0;

            if (!string.IsNullOrEmpty(MedidaSeleccionada))
            {
                cmbM10.SelectedItem = MedidaSeleccionada;
            }
        }

        private void cmbM10_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmbM10.SelectedItem.ToString();

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
                    string query = $"SELECT Milimetros, Largo10, DiametroEnPulgadas FROM {tabla}";

                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();

                    conexion.Open();
                    adaptador.Fill(dt);

                    dgvM10.DataSource = null;
                    dgvM10.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
            if (dgvM10.Rows.Count > 0)
            {
                dgvM10.Rows[0].Selected = true;
                dgvM10.FirstDisplayedScrollingRowIndex = 0;
            }
        }

    }
}
