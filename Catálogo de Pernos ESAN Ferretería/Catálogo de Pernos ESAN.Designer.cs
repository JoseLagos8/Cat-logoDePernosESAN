namespace Catálogo_de_Pernos_ESAN_Ferretería
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtBuscar = new TextBox();
            label3 = new Label();
            LBResultados = new ListBox();
            pictureBox1 = new PictureBox();
            btnCerrar = new Button();
            gpbFiltro = new GroupBox();
            btnPernosMGeneral = new Button();
            btnPernosPGeneral = new Button();
            btnPernoGrande = new Button();
            btnPernoHC = new Button();
            btnPernoHF = new Button();
            btnM16 = new Button();
            btnM14 = new Button();
            btnM12 = new Button();
            btnM10 = new Button();
            btnM8 = new Button();
            btnM6 = new Button();
            label9 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gpbFiltro.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(8, 33, 131);
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(396, 60);
            label1.Name = "label1";
            label1.Size = new Size(391, 46);
            label1.TabIndex = 1;
            label1.Text = "CATÁLOGO DE PERNOS\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(8, 33, 131);
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(396, 106);
            label2.Name = "label2";
            label2.Size = new Size(430, 31);
            label2.TabIndex = 2;
            label2.Text = "BÚSQUEDA RÁPIDA Y EQUIVALENCIAS";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(349, 227);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(324, 34);
            txtBuscar.TabIndex = 10;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(259, 223);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 11;
            label3.Text = "Buscar:";
            // 
            // LBResultados
            // 
            LBResultados.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBResultados.FormattingEnabled = true;
            LBResultados.ItemHeight = 23;
            LBResultados.Location = new Point(349, 267);
            LBResultados.Name = "LBResultados";
            LBResultados.Size = new Size(324, 418);
            LBResultados.TabIndex = 14;
            LBResultados.DoubleClick += LBResultados_DoubleClick_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000021195;
            pictureBox1.Location = new Point(-8, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(885, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(249, 710);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(219, 40);
            btnCerrar.TabIndex = 18;
            btnCerrar.Text = "CERRAR APLICACIÓN";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // gpbFiltro
            // 
            gpbFiltro.Controls.Add(btnPernosMGeneral);
            gpbFiltro.Controls.Add(btnPernosPGeneral);
            gpbFiltro.Controls.Add(btnPernoGrande);
            gpbFiltro.Controls.Add(btnPernoHC);
            gpbFiltro.Controls.Add(btnPernoHF);
            gpbFiltro.Controls.Add(btnM16);
            gpbFiltro.Controls.Add(btnM14);
            gpbFiltro.Controls.Add(btnM12);
            gpbFiltro.Controls.Add(btnM10);
            gpbFiltro.Controls.Add(btnM8);
            gpbFiltro.Controls.Add(btnM6);
            gpbFiltro.Controls.Add(label9);
            gpbFiltro.Controls.Add(label8);
            gpbFiltro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpbFiltro.Location = new Point(12, 224);
            gpbFiltro.Name = "gpbFiltro";
            gpbFiltro.Size = new Size(213, 526);
            gpbFiltro.TabIndex = 19;
            gpbFiltro.TabStop = false;
            gpbFiltro.Text = "Filtro";
            // 
            // btnPernosMGeneral
            // 
            btnPernosMGeneral.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPernosMGeneral.Location = new Point(6, 59);
            btnPernosMGeneral.Name = "btnPernosMGeneral";
            btnPernosMGeneral.Size = new Size(186, 29);
            btnPernosMGeneral.TabIndex = 31;
            btnPernosMGeneral.Text = "Todos los pernos";
            btnPernosMGeneral.UseVisualStyleBackColor = true;
            btnPernosMGeneral.Click += btnPernosMGeneral_Click;
            // 
            // btnPernosPGeneral
            // 
            btnPernosPGeneral.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPernosPGeneral.Location = new Point(6, 368);
            btnPernosPGeneral.Name = "btnPernosPGeneral";
            btnPernosPGeneral.Size = new Size(186, 29);
            btnPernosPGeneral.TabIndex = 30;
            btnPernosPGeneral.Text = "Todos los pernos";
            btnPernosPGeneral.UseVisualStyleBackColor = true;
            btnPernosPGeneral.Click += btnPernosPGeneral_Click;
            // 
            // btnPernoGrande
            // 
            btnPernoGrande.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPernoGrande.Location = new Point(6, 473);
            btnPernoGrande.Name = "btnPernoGrande";
            btnPernoGrande.Size = new Size(186, 29);
            btnPernoGrande.TabIndex = 29;
            btnPernoGrande.Text = "Pernos grandes";
            btnPernoGrande.UseVisualStyleBackColor = true;
            btnPernoGrande.Click += btnPernoGrande_Click;
            // 
            // btnPernoHC
            // 
            btnPernoHC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPernoHC.Location = new Point(6, 438);
            btnPernoHC.Name = "btnPernoHC";
            btnPernoHC.Size = new Size(186, 29);
            btnPernoHC.TabIndex = 28;
            btnPernoHC.Text = "Perno Hilo Corriente";
            btnPernoHC.UseVisualStyleBackColor = true;
            btnPernoHC.Click += btnPernoHC_Click;
            // 
            // btnPernoHF
            // 
            btnPernoHF.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPernoHF.Location = new Point(6, 403);
            btnPernoHF.Name = "btnPernoHF";
            btnPernoHF.Size = new Size(186, 29);
            btnPernoHF.TabIndex = 27;
            btnPernoHF.Text = "Perno Hilo Fino";
            btnPernoHF.UseVisualStyleBackColor = true;
            btnPernoHF.Click += btnPernoHF_Click;
            // 
            // btnM16
            // 
            btnM16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnM16.Location = new Point(6, 269);
            btnM16.Name = "btnM16";
            btnM16.Size = new Size(186, 29);
            btnM16.TabIndex = 26;
            btnM16.Text = "M16 (5/8\")";
            btnM16.UseVisualStyleBackColor = true;
            btnM16.Click += btnM16_Click;
            // 
            // btnM14
            // 
            btnM14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnM14.Location = new Point(6, 234);
            btnM14.Name = "btnM14";
            btnM14.Size = new Size(186, 29);
            btnM14.TabIndex = 25;
            btnM14.Text = "M14 (9/16\")";
            btnM14.UseVisualStyleBackColor = true;
            btnM14.Click += btnM14_Click;
            // 
            // btnM12
            // 
            btnM12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnM12.Location = new Point(6, 199);
            btnM12.Name = "btnM12";
            btnM12.Size = new Size(186, 29);
            btnM12.TabIndex = 24;
            btnM12.Text = "M12 (1/2\")";
            btnM12.UseVisualStyleBackColor = true;
            btnM12.Click += btnM12_Click;
            // 
            // btnM10
            // 
            btnM10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnM10.Location = new Point(6, 164);
            btnM10.Name = "btnM10";
            btnM10.Size = new Size(186, 29);
            btnM10.TabIndex = 21;
            btnM10.Text = "M10 (3/8\")";
            btnM10.UseVisualStyleBackColor = true;
            btnM10.Click += btnM10_Click;
            // 
            // btnM8
            // 
            btnM8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnM8.Location = new Point(6, 129);
            btnM8.Name = "btnM8";
            btnM8.Size = new Size(186, 29);
            btnM8.TabIndex = 23;
            btnM8.Text = "M8 (5/16\")";
            btnM8.UseVisualStyleBackColor = true;
            btnM8.Click += btnM8_Click;
            // 
            // btnM6
            // 
            btnM6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnM6.Location = new Point(6, 94);
            btnM6.Name = "btnM6";
            btnM6.Size = new Size(186, 29);
            btnM6.TabIndex = 20;
            btnM6.Text = "M6 (1/4\")";
            btnM6.UseVisualStyleBackColor = true;
            btnM6.Click += btnM6_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 33);
            label9.Name = "label9";
            label9.Size = new Size(178, 23);
            label9.TabIndex = 22;
            label9.Text = "Pernos en milimetros";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 342);
            label8.Name = "label8";
            label8.Size = new Size(164, 23);
            label8.TabIndex = 20;
            label8.Text = "Pernos en pulgadas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(866, 762);
            Controls.Add(gpbFiltro);
            Controls.Add(btnCerrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(LBResultados);
            Controls.Add(label3);
            Controls.Add(txtBuscar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Catálogo de Pernos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gpbFiltro.ResumeLayout(false);
            gpbFiltro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtBuscar;
        private Label label3;
        private ListBox LBResultados;
        private PictureBox pictureBox1;
        private Button btnCerrar;
        private GroupBox gpbFiltro;
        private Label label9;
        private Label label8;
        private Button btnM8;
        private Button btnM6;
        private Button btnPernoHC;
        private Button btnPernoHF;
        private Button btnM16;
        private Button btnM14;
        private Button btnM12;
        private Button btnM10;
        private Button btnPernoGrande;
        private Button btnPernosMGeneral;
        private Button btnPernosPGeneral;
    }
}
