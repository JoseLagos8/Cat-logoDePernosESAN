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
                        Database=PERNOS_ESAN;
                        Trusted_Connection=True;
                        Encrypt=True;
                        TrustServerCertificate=True;";
        public m12()
        {
            InitializeComponent();
        }

        private void m12_Load(object sender, EventArgs e)
        {
            MostrarDatosM12();
        }

        public void MostrarDatosM12()
        {
            string sql = "SELECT * FROM M12_125";

            using (SqlConnection cnn = new SqlConnection(conexión))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvM12.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                        }
                    }
                }
            }
            string sql2 = "SELECT * FROM M12_15";

            using (SqlConnection cnn = new SqlConnection(conexión))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql2, cnn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvM1215.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                        }
                    }
                }
            }
            string sql3 = "SELECT * FROM M12_175";

            using (SqlConnection cnn = new SqlConnection(conexión))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql3, cnn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvM12175.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
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
