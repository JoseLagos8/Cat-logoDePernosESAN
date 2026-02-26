using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Data;
using Microsoft.Win32;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Catálogo_de_Pernos_ESAN_Ferretería
{
    public partial class Form1 : Form
    {
        // Cadenas de conexión
        string conexión = @"Server=192.168.1.191\SQLEXPRESS;
                            Database=P_MilimetroPulgada;
                            Trusted_Connection=True;
                            Encrypt=True;
                            TrustServerCertificate=True;";

        string conexión2 = @"Server=192.168.1.191\SQLEXPRESS;
                            Database=P_Grandes;
                            Trusted_Connection=True;
                            Encrypt=True;
                            TrustServerCertificate=True;";

        string conexión3 = @"Server=192.168.1.191\SQLEXPRESS;
                            Database=P_HiloCorriente;
                            Trusted_Connection=True;
                            Encrypt=True;
                            TrustServerCertificate=True;";

        string conexión4 = @"Server=192.168.1.191\SQLEXPRESS;
                            Database=P_HiloFino;
                            Trusted_Connection=True;
                            Encrypt=True;
                            TrustServerCertificate=True;";

        private bool cierreAutorizado = false;

        List<Perno> pernos = new List<Perno>();

        private List<string> BuscarEnBase(string conexionString, string texto)
        {
            List<string> resultados = new List<string>();

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();

                DataTable tablas = con.GetSchema("Tables");

                foreach (DataRow row in tablas.Rows)
                {
                    string nombreTabla = row["TABLE_NAME"].ToString();

                    try
                    {
                        string query = $"SELECT * FROM [{nombreTabla}] WHERE [Diametro X Largo en pulgadas] LIKE @texto";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    resultados.Add(reader[0].ToString());
                                }
                            }
                        }
                    }
                    catch
                    {

                    }
                }
            }

            return resultados;
        }
        public class ResultadoBusqueda
        {
            public string Texto { get; set; }
            public string Formulario { get; set; }

            public override string ToString()
            {
                return Texto;
            }
        }

        public Form1()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }

        private void ConfiguracionInicial()
        {
            this.TopMost = true;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.Manual;

            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Top;
            this.Location = new Point(x, y);

            ConfigurarInicioAutomatico();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarPernos();
        }

        public void CargarPernos()
        {
            pernos.Clear();
            pernos.Add(new Perno { Milimetro = "M6", Paso = "1.25", Pulgada = "1/4", Descripcion = "M6 x 1.25 (1/4\")", FormDestino = "FormM6" });
            pernos.Add(new Perno { Milimetro = "M8", Paso = "1.25", Pulgada = "5/16", Descripcion = "M8 x 1.25 (5/16\")", FormDestino = "FormM8" });
            pernos.Add(new Perno { Milimetro = "M10", Paso = "1.25", Pulgada = "3/8", Descripcion = "M10 x 1.25 (3/8\")", FormDestino = "FormM10_125" });
            pernos.Add(new Perno { Milimetro = "M10", Paso = "1.5", Pulgada = "3/8", Descripcion = "M10 x 1.5 (3/8\")", FormDestino = "FormM10_15" });
            pernos.Add(new Perno { Milimetro = "M12", Paso = "1.25", Pulgada = "1/2", Descripcion = "M12 x 1.25 (1/2\")", FormDestino = "FormM12_125" });
            pernos.Add(new Perno { Milimetro = "M12", Paso = "1.5", Pulgada = "1/2", Descripcion = "M12 x 1.5 (1/2\")", FormDestino = "FormM12_15" });
            pernos.Add(new Perno { Milimetro = "M12", Paso = "1.75", Pulgada = "1/2", Descripcion = "M12 x 1.75 (1/2\")", FormDestino = "FormM12_175" });
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(texto))
            {
                LBResultados.Visible = false;
                return;
            }

            List<ResultadoBusqueda> resultados = new List<ResultadoBusqueda>();

            resultados.AddRange(
                pernos
                .Where(p => p.Descripcion.ToLower().Contains(texto) ||
                            p.Milimetro.ToLower().Contains(texto))
                .Select(p => new ResultadoBusqueda
                {
                    Texto = p.Descripcion,
                    Formulario = p.FormDestino
                })
            );

            resultados.AddRange(BuscarEnBaseConFormulario(conexión2, texto, "FormGrandes"));
            resultados.AddRange(BuscarEnBaseConFormulario(conexión3, texto, "FormHiloCorriente"));
            resultados.AddRange(BuscarEnBaseConFormulario(conexión4, texto, "FormHiloFino"));

            LBResultados.DataSource = null;
            LBResultados.DataSource = resultados;
            LBResultados.Visible = resultados.Count > 0;
        }
        private string ObtenerNombreAmigable(string nombreForm)
        {
            switch (nombreForm)
            {
                case "FormGrandes":
                    return "Pernos Grandes";

                case "FormHiloCorriente":
                    return "Perno Hilo Corriente";

                case "FormHiloFino":
                    return "Perno Hilo Fino";

                case "FormM6":
                case "FormM8":
                case "FormM10_125":
                case "FormM10_15":
                case "FormM12_125":
                case "FormM12_15":
                case "FormM12_175":
                    return "Perno Métrico";

                default:
                    return nombreForm;
            }
        }


        private List<ResultadoBusqueda> BuscarEnBaseConFormulario(string conexionString, string texto, string nombreForm)
        {
            List<ResultadoBusqueda> resultados = new List<ResultadoBusqueda>();

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                con.Open();
                DataTable tablas = con.GetSchema("Tables");

                foreach (DataRow row in tablas.Rows)
                {
                    string nombreTabla = row["TABLE_NAME"].ToString();

                    try
                    {
                        string query = $"SELECT [Diametro X Largo en pulgadas] FROM {nombreTabla} WHERE [Diametro X Largo en pulgadas] LIKE @texto";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    resultados.Add(new ResultadoBusqueda
                                    {
                                        Texto = reader[0].ToString() + " (" + ObtenerNombreAmigable(nombreForm) + ")",
                                        Formulario = nombreForm
                                    });
                                }
                            }
                        }
                    }
                    catch { }
                }
            }

            return resultados;
        }

        private void AbrirForm(string formDestino)
        {
            Form form = null;
            switch (formDestino)
            {
                case "FormM6": form = new m6(); break;
                case "FormM8": form = new m8(); break;
                case "FormM10_125": case "FormM10_15": form = new m10(); break;
                case "FormM12_125":
                case "FormM12_15":
                case "FormM12_175": form = new m12(); break;
            }
            if (form != null) { this.Hide(); form.ShowDialog(); this.Show(); }
        }
      
        private void ConfigurarInicioAutomatico()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                rk.SetValue("CatalogoPernosESAN", Application.ExecutablePath);
            }
            catch { }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicación?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cierreAutorizado = true;
                Application.Exit();
            }
        }

        public class HistorialItem
        {
            public string Codigo { get; set; }
            public string Paso { get; set; }
            public int Cantidad { get; set; }
        }

        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MOVE = 0xF010;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt32() & 0xfff0) == SC_MOVE) return;
            base.WndProc(ref m);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!cierreAutorizado)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }
        

        private void LBResultados_DoubleClick_1(object sender, EventArgs e)
        {
            if (LBResultados.SelectedItem is ResultadoBusqueda seleccionado)
            {
                Form formAbrir = null;

                switch (seleccionado.Formulario)
                {
                    case "FormM6": formAbrir = new m6(); break;
                    case "FormM8": formAbrir = new m8(); break;

                    case "FormM10_125":
                    case "FormM10_15":

                        m10 formM10 = new m10();

                        string medidaLimpia = seleccionado.Texto;

                        if (medidaLimpia.Contains("1.25"))
                            formM10.MedidaSeleccionada = "M10 1.25";
                        else if (medidaLimpia.Contains("1.5"))
                            formM10.MedidaSeleccionada = "M10 1.5";

                        formAbrir = formM10;
                        break;

                    case "FormM12_125":
                    case "FormM12_15":
                    case "FormM12_175":

                        m12 formM12 = new m12();

                        if (seleccionado.Texto.Contains("1.25"))
                            formM12.MedidaSeleccionada = "M12 1.25";
                        else if (seleccionado.Texto.Contains("1.5"))
                            formM12.MedidaSeleccionada = "M12 1.5";
                        else if (seleccionado.Texto.Contains("1.75"))
                            formM12.MedidaSeleccionada = "M12 1.75";

                        formAbrir = formM12;
                        break;

                    case "FormGrandes":
                        formAbrir = new PernosGrandes();
                        break;

                    case "FormHiloCorriente":

                        PernoHiloCorriente formHC = new PernoHiloCorriente();

                        formHC.MedidaSeleccionada = seleccionado.Texto;

                        formAbrir = formHC;

                        break;

                    case "FormHiloFino":

                        PernoHiloFino formHiloFino = new PernoHiloFino();
                        formHiloFino.MedidaSeleccionada = seleccionado.Texto;

                        formAbrir = formHiloFino;
                        break;
                }

                if (formAbrir != null)
                {
                    this.Hide();
                    formAbrir.ShowDialog();
                    this.Show();
                }
            }
        }

        //BOTONES DE LOS FORMS.
        private void btnM6_Click(object sender, EventArgs e)
        {
            m6 m6 = new m6();
            m6.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            m6.Show();
        }

        private void btnM8_Click(object sender, EventArgs e)
        {
            m8 m8 = new m8();
            m8.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            m8.Show();
        }

        private void btnM10_Click(object sender, EventArgs e)
        {
            m10 m10 = new m10();
            m10.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            m10.Show();
        }

        private void btnM12_Click(object sender, EventArgs e)
        {
            m12 m12 = new m12();
            m12.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            m12.Show();
        }

        private void btnM14_Click(object sender, EventArgs e)
        {
            m14 m14 = new m14();
            m14.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            m14.Show();
        }

        private void btnM16_Click(object sender, EventArgs e)
        {
            m16 m16 = new m16();
            m16.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            m16.Show();
        }

        private void btnPernoHF_Click(object sender, EventArgs e)
        {
            PernoHiloFino PernoHF = new PernoHiloFino();
            PernoHF.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            PernoHF.Show();
        }

        private void btnPernoHC_Click(object sender, EventArgs e)
        {
            PernoHiloCorriente PernoHC = new PernoHiloCorriente();
            PernoHC.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            PernoHC.Show();
        }

        private void btnPernoGrande_Click(object sender, EventArgs e)
        {
            PernosGrandes PernoG = new PernosGrandes();
            PernoG.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            PernoG.Show();
        }

        private void btnPernosMGeneral_Click(object sender, EventArgs e)
        {
            PernosMilimetricos PernoMGeneral = new PernosMilimetricos();
            PernoMGeneral.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            PernoMGeneral.Show();
        }

        private void btnPernosPGeneral_Click(object sender, EventArgs e)
        {
            PernosPulgadas PernoPGeneral = new PernosPulgadas();
            PernoPGeneral.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            PernoPGeneral.Show();
        }
    }
}