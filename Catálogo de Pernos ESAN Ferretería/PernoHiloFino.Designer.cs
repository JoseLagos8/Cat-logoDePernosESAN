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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPernoHF).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000021195;
            pictureBox1.Location = new Point(-2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(885, 204);
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
            label1.Location = new Point(329, 86);
            label1.Name = "label1";
            label1.Size = new Size(336, 46);
            label1.TabIndex = 21;
            label1.Text = "Perno con Hilo Fino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 222);
            label2.Name = "label2";
            label2.Size = new Size(224, 28);
            label2.TabIndex = 24;
            label2.Text = "Medidas de los pernos";
            // 
            // cmbPernoHF
            // 
            cmbPernoHF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPernoHF.FormattingEnabled = true;
            cmbPernoHF.Location = new Point(12, 253);
            cmbPernoHF.Name = "cmbPernoHF";
            cmbPernoHF.Size = new Size(224, 36);
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
            dgvPernoHF.Location = new Point(290, 222);
            dgvPernoHF.Name = "dgvPernoHF";
            dgvPernoHF.RowHeadersWidth = 51;
            dgvPernoHF.Size = new Size(459, 507);
            dgvPernoHF.TabIndex = 25;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 38);
            btnVolver.TabIndex = 26;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // LBResultados
            // 
            LBResultados.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBResultados.FormattingEnabled = true;
            LBResultados.ItemHeight = 23;
            LBResultados.Location = new Point(12, 295);
            LBResultados.Name = "LBResultados";
            LBResultados.Size = new Size(224, 119);
            LBResultados.TabIndex = 27;
            LBResultados.Click += LBResultados_Click;
            // 
            // PernoHiloFino
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(786, 837);
            Controls.Add(LBResultados);
            Controls.Add(btnVolver);
            Controls.Add(dgvPernoHF);
            Controls.Add(label2);
            Controls.Add(cmbPernoHF);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PernoHiloFino";
            Text = "Pernos de Hilo Fino";
            Load += PernoHiloFino_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPernoHF).EndInit();
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
    }
}