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
    public partial class PernosMilimetricos : Form
    {
        string conexión = @"Server=192.168.1.191\SQLEXPRESS;
                            Database=P_MilimetroPulgada;
                            Trusted_Connection=True;
                            Encrypt=True;
                            TrustServerCertificate=True;";

        public PernosMilimetricos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = 0;

            this.Location = new Point(x, y);

            dgvPernosMGeneral.ReadOnly = true;
            dgvPernosMGeneral.AllowUserToAddRows = false;
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
            string[] tablas = { "m6", "m8", "m10", "m12", "m14", "m16" };

            using (SqlConnection cnn = new SqlConnection(conexión))
            {
                cnn.Open();

                foreach (string tabla in tablas)
                {
                    string sql = $"SELECT * FROM {tabla}";

                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvPernosMGeneral.Rows.Add(reader[0], reader[1], reader[2]);
                            }
                        }
                    }
                }
            }
        }

        private void PernosMilimetricos_Load(object sender, EventArgs e)
        {
            MostrarTodosLosDatos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
