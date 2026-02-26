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
    public partial class PernosPulgadas : Form
    {
        string conexión = @"Server=192.168.1.191\SQLEXPRESS;
                            Database=P_Grandes;
                            Trusted_Connection=True;
                            Encrypt=True;
                            TrustServerCertificate=True;";

        string conexión2 = @"Server=JOLALA\SQLEXPRESS;
                            Database=P_HiloCorriente;
                            Trusted_Connection=True;
                            Encrypt=True;
                            TrustServerCertificate=True;";

        string conexión3 = @"Server=JOLALA\SQLEXPRESS;
                            Database=P_HiloFino;
                            Trusted_Connection=True;
                            Encrypt=True;
                            TrustServerCertificate=True;";

        public PernosPulgadas()
        {
            InitializeComponent();
            MostrarTodosLosDatos();

            this.StartPosition = FormStartPosition.Manual;

            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = 0;

            this.Location = new Point(x, y);

            dgvPernosPGeneral.ReadOnly = true;
            dgvPernosPGeneral.AllowUserToAddRows = false;
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

        public void MostrarTodosLosDatos()
        {
            dgvPernosPGeneral.Rows.Clear();

            CargarDatos(conexión, new string[] { "PernoCorriente", "PernoFino" }, "P. Grandes");
            CargarDatos(conexión2, new string[] { "hc12", "hc14", "hc38", "hc516", "hc58", "hc716", "hc916" }, "Hilo Corriente");
            CargarDatos(conexión3, new string[] { "hf12", "hf14", "hf38", "hf516", "hf58", "hf716", "hf916" }, "Hilo Fino");
        }

        private void CargarDatos(string cadenaConexion, string[] tablas, string tipoRosca)
        {
            using (SqlConnection cnn = new SqlConnection(cadenaConexion))
            {
                try
                {
                    cnn.Open();
                    foreach (string tabla in tablas)
                    {
                        string sql = $"SELECT * FROM {tabla}";

                        using (SqlCommand cmd = new SqlCommand(sql, cnn))
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string pernoCompleto = $"{reader[0].ToString()} - {tipoRosca}";
                                dgvPernosPGeneral.Rows.Add(pernoCompleto);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error en {tipoRosca}: {ex.Message}");
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
