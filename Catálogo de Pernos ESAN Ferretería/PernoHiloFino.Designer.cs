namespace Catálogo_de_Pernos_ESAN_Ferretería
{
    partial class PernoHiloFino
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PernoHiloFino));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            cmbPernoHF = new ComboBox();
            dgvPernoHF = new DataGridView();
            btnVolver = new Button();
            LBResultados = new ListBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPernoHF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000021195;
            pictureBox1.Location = new Point(-30, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(722, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(8, 33, 131);
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(288, 64);
            label1.Name = "label1";
            label1.Size = new Size(268, 37);
            label1.TabIndex = 21;
            label1.Text = "Perno con Hilo Fino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 166);
            label2.Name = "label2";
            label2.Size = new Size(180, 21);
            label2.TabIndex = 24;
            label2.Text = "Medidas de los pernos";
            // 
            // cmbPernoHF
            // 
            cmbPernoHF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPernoHF.FormattingEnabled = true;
            cmbPernoHF.Location = new Point(10, 190);
            cmbPernoHF.Margin = new Padding(3, 2, 3, 2);
            cmbPernoHF.Name = "cmbPernoHF";
            cmbPernoHF.Size = new Size(196, 29);
            cmbPernoHF.TabIndex = 23;
            cmbPernoHF.SelectedIndexChanged += cmbPernosHF_SelectedIndexChanged;
            cmbPernoHF.TextChanged += cmbPernoHF_TextChanged;
            // 
            // dgvPernoHF
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPernoHF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPernoHF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPernoHF.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPernoHF.Location = new Point(254, 166);
            dgvPernoHF.Margin = new Padding(3, 2, 3, 2);
            dgvPernoHF.Name = "dgvPernoHF";
            dgvPernoHF.RowHeadersWidth = 51;
            dgvPernoHF.Size = new Size(402, 380);
            dgvPernoHF.TabIndex = 25;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(10, 9);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(82, 28);
            btnVolver.TabIndex = 26;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // LBResultados
            // 
            LBResultados.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBResultados.FormattingEnabled = true;
            LBResultados.ItemHeight = 19;
            LBResultados.Location = new Point(10, 221);
            LBResultados.Margin = new Padding(3, 2, 3, 2);
            LBResultados.Name = "LBResultados";
            LBResultados.Size = new Size(196, 80);
            LBResultados.TabIndex = 27;
            LBResultados.Click += LBResultados_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(9, 38, 118);
            pictureBox3.Image = Properties.Resources.MER_Chillán1;
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(189, 109);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // PernoHiloFino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(688, 628);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox3);
            Controls.Add(LBResultados);
            Controls.Add(dgvPernoHF);
            Controls.Add(label2);
            Controls.Add(cmbPernoHF);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "PernoHiloFino";
            Text = "Pernos de Hilo Fino";
            Load += PernoHiloFino_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPernoHF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ComboBox cmbPernoHF;
        private DataGridView dgvPernoHF;
        private Button btnVolver;
        private ListBox LBResultados;
        private PictureBox pictureBox3;
    }
}