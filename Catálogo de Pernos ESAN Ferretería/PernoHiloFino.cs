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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Catálogo_de_Pernos_ESAN_Ferretería
{
    public partial class PernoHiloFino : Form
    {
        string conexión = @"Server=192.168.1.191\SQLEXPRESS;
                        Database=P_HiloFino;
                        Trusted_Connection=True;
                        Encrypt=True;
                        TrustServerCertificate=True;";
        public string MedidaSeleccionada { get; set; }

        Dictionary<string, string> mapaTablas = new Dictionary<string, string>()
    {
        { "Perno 1/2", "hf12" },
        { "Perno 1/4", "hf14" },
        { "Perno 3/8", "hf38" },
        { "Perno 5/16", "hf516" },
        { "Perno 5/8", "hf58" },
        { "Perno 7/16", "hf716" },
        { "Perno 9/16", "hf916" }
    };

        public PernoHiloFino()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;

            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = 0;

            this.Location = new Point(x, y);

            dgvPernoHF.ReadOnly = true;
            dgvPernoHF.AllowUserToAddRows = false;
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

        private void PernoHiloFino_Load(object sender, EventArgs e)
        {
            cmbPernoHF.Items.Clear();

            cmbPernoHF.Items.Add("Perno 1/2");
            cmbPernoHF.Items.Add("Perno 1/4");
            cmbPernoHF.Items.Add("Perno 3/8");
            cmbPernoHF.Items.Add("Perno 5/16");
            cmbPernoHF.Items.Add("Perno 5/8");
            cmbPernoHF.Items.Add("Perno 7/16");
            cmbPernoHF.Items.Add("Perno 9/16");

            string medidaDetectada = null;

            if (!string.IsNullOrEmpty(MedidaSeleccionada))
            {
                string primeraParte = MedidaSeleccionada.Split(' ')[0];
                primeraParte = primeraParte.Replace("\"", "");

                foreach (var item in cmbPernoHF.Items)
                {
                    string medidaCombo = item.ToString().Replace("Perno ", "");

                    if (medidaCombo == primeraParte)
                    {
                        medidaDetectada = item.ToString();
                        break;
                    }
                }
            }

            if (medidaDetectada != null)
                cmbPernoHF.SelectedItem = medidaDetectada;
            else
                cmbPernoHF.SelectedIndex = 0;

            if (cmbPernoHF.SelectedItem != null)
            {
                string seleccion = cmbPernoHF.SelectedItem.ToString();

                if (mapaTablas.ContainsKey(seleccion))
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

                    dgvPernoHF.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }

            if (dgvPernoHF.Columns.Count > 0)
            {
                dgvPernoHF.Columns[0].Width = 300;
            }
        }

        private void cmbPernoHF_TextChanged(object sender, EventArgs e)
        {
            LBResultados.Items.Clear();

            string textoBusqueda = cmbPernoHF.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                LBResultados.Visible = false;
                return;
            }

            foreach (var item in cmbPernoHF.Items)
            {
                string itemTexto = item.ToString().ToLower();

                if (itemTexto.StartsWith(textoBusqueda))
                {
                    LBResultados.Items.Add(item.ToString());
                }
            }

            LBResultados.Visible = LBResultados.Items.Count > 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LBResultados_Click(object sender, EventArgs e)
        {
            if (LBResultados.SelectedItem != null)
            {
                cmbPernoHF.Text = LBResultados.SelectedItem.ToString();

                LBResultados.Visible = false;

                string seleccion = cmbPernoHF.Text;
                if (mapaTablas.ContainsKey(seleccion))
                {
                    CargarDatos(mapaTablas[seleccion]);
                }
            }
        }

        private void cmbPernosHF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPernoHF.SelectedItem == null) return;

            string seleccion = cmbPernoHF.SelectedItem.ToString();

            if (mapaTablas.ContainsKey(seleccion))
            {
                CargarDatos(mapaTablas[seleccion]);
            }
        }
    }
}

