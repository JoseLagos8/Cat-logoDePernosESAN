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

    public partial class m16 : Form
    {
        string conexión = @"Server=192.168.1.191\SQLEXPRESS;
                          Database=P_MilimetroPulgada;
                          User Id=usuario;
                          Password=esan;
                          Encrypt=True;
                          TrustServerCertificate=True;";

        public m16()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;

            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = 0;

            this.Location = new Point(x, y);

            dgvM16.ReadOnly = true;
            dgvM16.AllowUserToAddRows = false;
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

        private void m16_Load(object sender, EventArgs e)
        {
            MostrarDatosM16();
        }

        public void MostrarDatosM16()
        {
            string sql = "SELECT * FROM m16";

            using (SqlConnection cnn = new SqlConnection(conexión))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvM16.Rows.Add(reader[0], reader[1], reader[2]);
                        }
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
