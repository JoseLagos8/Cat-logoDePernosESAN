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
            label4 = new Label();
            btnM6 = new Button();
            btmM8 = new Button();
            btnM10 = new Button();
            btnM12 = new Button();
            txtBuscar = new TextBox();
            label3 = new Label();
            dgvHistorial = new DataGridView();
            milimetro = new DataGridViewTextBoxColumn();
            paso = new DataGridViewTextBoxColumn();
            pulgada = new DataGridViewTextBoxColumn();
            buscado = new DataGridViewTextBoxColumn();
            label5 = new Label();
            LBResultados = new ListBox();
            btnLimpiarHistorial = new Button();
            menuStrip1 = new MenuStrip();
            catálogosToolStripMenuItem = new ToolStripMenuItem();
            tuercasToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 24);
            label1.Name = "label1";
            label1.Size = new Size(391, 46);
            label1.TabIndex = 1;
            label1.Text = "CATÁLOGO DE PERNOS\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(354, 70);
            label2.Name = "label2";
            label2.Size = new Size(375, 28);
            label2.TabIndex = 2;
            label2.Text = "BÚSQUEDA RÁPIDA Y EQUIVALENCIAS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(323, 98);
            label4.Name = "label4";
            label4.Size = new Size(454, 28);
            label4.TabIndex = 5;
            label4.Text = "LAS PULGADAS SON MEDIDAS APROXIMADAS";
            // 
            // btnM6
            // 
            btnM6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnM6.Location = new Point(85, 401);
            btnM6.Name = "btnM6";
            btnM6.Size = new Size(129, 48);
            btnM6.TabIndex = 6;
            btnM6.Text = "M6 - 1.25 (1/4\")";
            btnM6.UseVisualStyleBackColor = true;
            btnM6.Click += btnM6_Click;
            // 
            // btmM8
            // 
            btmM8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btmM8.Location = new Point(270, 401);
            btmM8.Name = "btmM8";
            btmM8.Size = new Size(132, 48);
            btmM8.TabIndex = 7;
            btmM8.Text = "M8 - 1.25 (5/16\")";
            btmM8.UseVisualStyleBackColor = true;
            btmM8.Click += btmM8_Click;
            // 
            // btnM10
            // 
            btnM10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnM10.Location = new Point(457, 401);
            btnM10.Name = "btnM10";
            btnM10.Size = new Size(182, 48);
            btnM10.TabIndex = 8;
            btnM10.Text = "M10 - 1.25 y 1.5 (3/8\")";
            btnM10.UseVisualStyleBackColor = true;
            btnM10.Click += btnM10_Click;
            // 
            // btnM12
            // 
            btnM12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnM12.Location = new Point(700, 401);
            btnM12.Name = "btnM12";
            btnM12.Size = new Size(205, 48);
            btnM12.TabIndex = 9;
            btnM12.Text = "M12 - 1.25, 1.5 y 1.75 (1/2\")";
            btnM12.UseVisualStyleBackColor = true;
            btnM12.Click += btnM12_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(85, 158);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(324, 27);
            txtBuscar.TabIndex = 10;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 163);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 11;
            label3.Text = "Buscar:";
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Columns.AddRange(new DataGridViewColumn[] { milimetro, paso, pulgada, buscado });
            dgvHistorial.Location = new Point(483, 191);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(554, 193);
            dgvHistorial.TabIndex = 12;
            dgvHistorial.CellClick += dgvHistorial_CellClick;
            // 
            // milimetro
            // 
            milimetro.HeaderText = "Milimetro";
            milimetro.MinimumWidth = 6;
            milimetro.Name = "milimetro";
            milimetro.Width = 125;
            // 
            // paso
            // 
            paso.HeaderText = "Paso";
            paso.MinimumWidth = 6;
            paso.Name = "paso";
            paso.Width = 125;
            // 
            // pulgada
            // 
            pulgada.HeaderText = "Pulgada";
            pulgada.MinimumWidth = 6;
            pulgada.Name = "pulgada";
            pulgada.Width = 125;
            // 
            // buscado
            // 
            buscado.HeaderText = "Veces buscado";
            buscado.MinimumWidth = 6;
            buscado.Name = "buscado";
            buscado.Width = 125;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(483, 163);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 13;
            label5.Text = "Lo más buscado:";
            // 
            // LBResultados
            // 
            LBResultados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBResultados.FormattingEnabled = true;
            LBResultados.Location = new Point(85, 191);
            LBResultados.Name = "LBResultados";
            LBResultados.Size = new Size(324, 104);
            LBResultados.TabIndex = 14;
            LBResultados.DoubleClick += LBResultados_DoubleClick;
            // 
            // btnLimpiarHistorial
            // 
            btnLimpiarHistorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarHistorial.Location = new Point(891, 159);
            btnLimpiarHistorial.Name = "btnLimpiarHistorial";
            btnLimpiarHistorial.Size = new Size(146, 29);
            btnLimpiarHistorial.TabIndex = 15;
            btnLimpiarHistorial.Text = "Limpiar historial";
            btnLimpiarHistorial.UseVisualStyleBackColor = true;
            btnLimpiarHistorial.Click += btnLimpiarHistorial_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { catálogosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1143, 33);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // catálogosToolStripMenuItem
            // 
            catálogosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tuercasToolStripMenuItem });
            catálogosToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            catálogosToolStripMenuItem.Size = new Size(110, 29);
            catálogosToolStripMenuItem.Text = "Catálogos";
            // 
            // tuercasToolStripMenuItem
            // 
            tuercasToolStripMenuItem.Name = "tuercasToolStripMenuItem";
            tuercasToolStripMenuItem.Size = new Size(163, 30);
            tuercasToolStripMenuItem.Text = "Tuercas";
            tuercasToolStripMenuItem.Click += tuercasToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 517);
            Controls.Add(btnLimpiarHistorial);
            Controls.Add(LBResultados);
            Controls.Add(label5);
            Controls.Add(dgvHistorial);
            Controls.Add(label3);
            Controls.Add(txtBuscar);
            Controls.Add(btnM12);
            Controls.Add(btnM10);
            Controls.Add(btmM8);
            Controls.Add(btnM6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label4;
        private Button btnM6;
        private Button btmM8;
        private Button btnM10;
        private Button btnM12;
        private TextBox txtBuscar;
        private Label label3;
        private DataGridView dgvHistorial;
        private Label label5;
        private ListBox LBResultados;
        private DataGridViewTextBoxColumn milimetro;
        private DataGridViewTextBoxColumn paso;
        private DataGridViewTextBoxColumn pulgada;
        private DataGridViewTextBoxColumn buscado;
        private Button btnLimpiarHistorial;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem catálogosToolStripMenuItem;
        private ToolStripMenuItem tuercasToolStripMenuItem;
    }
}
