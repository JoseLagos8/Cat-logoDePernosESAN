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
        string conexión = @"Server=JOLALA\SQLEXPRESS;
                        Database=P_HiloFino;
                        Trusted_Connection=True;
                        Encrypt=True;
                        TrustServerCertificate=True;";

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
            cmbPernoHF.Items.Add("Perno 1/2");
            cmbPernoHF.Items.Add("Perno 1/4");
            cmbPernoHF.Items.Add("Perno 3/8");
            cmbPernoHF.Items.Add("Perno 5/16");
            cmbPernoHF.Items.Add("Perno 5/8");
            cmbPernoHF.Items.Add("Perno 7/16");
            cmbPernoHF.Items.Add("Perno 9/16");
        }


        private void cmbPernos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmbPernoHF.SelectedItem.ToString();

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

                    dgvPernoHF.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }

            dgvPernoHF.Columns[0].Width = 300;
        }

        private void cmbPernoHF_TextChanged(object sender, EventArgs e)
        {
            LBResultados.Items.Clear();

            string textoBusqueda = cmbPernoHF.Text.ToLower();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                LBResultados.Visible = false;
                return;
            }

            foreach (var item in cmbPernoHF.Items)
            {
                string itemTexto = item.ToString().ToLower();

                if (itemTexto.Contains(textoBusqueda))
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
    }
}

