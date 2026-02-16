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
    public partial class m6 : Form
    {
        string conexión = @"Server=JOLALA\SQLEXPRESS;
                        Database=PERNOS_ESAN;
                        Trusted_Connection=True;
                        Encrypt=True;
                        TrustServerCertificate=True;";
        public m6()
        {
            InitializeComponent();
        }

        private void m6_Load(object sender, EventArgs e)
        {
            MostrarDatosM6();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      

        public void MostrarDatosM6()
        {
            string sql = "SELECT * FROM M6_125";

            using (SqlConnection cnn = new SqlConnection(conexión))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvM6.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                        }
                    }
                }
            }
        }
    }
}

/*
    string sql = "SELECT * FROM M6_125";

using (SqlConnection cnn = new SqlConnection(conexión))
{
        cnn.Open();
        using (SqlCommand cmd = new SqlCommand(sql, cnn))
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dgvM6.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
            }
        }
}
*/