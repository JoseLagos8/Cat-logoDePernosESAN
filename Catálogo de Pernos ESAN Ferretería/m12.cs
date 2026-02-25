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
        string conexión = @"Server=JOLALA\SQLEXPRESS;
                        Database=P_MilimetroPulgada;
                        Trusted_Connection=True;
                        Encrypt=True;
                        TrustServerCertificate=True;";
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
            MostrarDatosM12();
            cmbM12.Items.Add("M12 1.25");
            cmbM12.Items.Add("M12 1.5");
            cmbM12.Items.Add("M12 1.75");

            cmbM12.SelectedIndex = 0;
        }
        public void MostrarDatosM12()
        {
            string sql = "SELECT * FROM m12";

            using (SqlConnection cnn = new SqlConnection(conexión))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvM12.Rows.Add(reader[0], reader[1], reader[2]);
                        }
                    }
                }
            }
        }
        public void MostrarDatosM10()
        {
            string sql = "SELECT * FROM m12";

            using (SqlConnection cnn = new SqlConnection(conexión))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvM12.Rows.Add(reader[0], reader[1], reader[2]);
                        }
                    }
                }
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
            string seleccion = cmbM12.SelectedItem.ToString();

            if (mapaTablas.ContainsKey(seleccion))
            {
                CargarDatos(mapaTablas[seleccion]);
            }
        }
    }
}
