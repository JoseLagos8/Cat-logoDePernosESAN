namespace Catálogo_de_Pernos_ESAN_Ferretería
{
    partial class PernoHiloCorriente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PernoHiloCorriente));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cmbPernoHC = new ComboBox();
            label2 = new Label();
            dgvPernoHC = new DataGridView();
            btnVolver = new Button();
            LBResultados = new ListBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPernoHC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000021195;
            pictureBox1.Location = new Point(-36, 1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(744, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(8, 33, 131);
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(286, 59);
            label1.Name = "label1";
            label1.Size = new Size(334, 37);
            label1.TabIndex = 20;
            label1.Text = "Perno con Hilo Corriente";
            // 
            // cmbPernoHC
            // 
            cmbPernoHC.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPernoHC.FormattingEnabled = true;
            cmbPernoHC.Location = new Point(19, 193);
            cmbPernoHC.Margin = new Padding(3, 2, 3, 2);
            cmbPernoHC.Name = "cmbPernoHC";
            cmbPernoHC.Size = new Size(196, 27);
            cmbPernoHC.TabIndex = 21;
            cmbPernoHC.SelectedIndexChanged += cmbPernoHC_SelectedIndexChanged;
            cmbPernoHC.TextChanged += cmbPernoHC_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 170);
            label2.Name = "label2";
            label2.Size = new Size(180, 21);
            label2.TabIndex = 22;
            label2.Text = "Medidas de los pernos";
            // 
            // dgvPernoHC
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPernoHC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPernoHC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPernoHC.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPernoHC.Location = new Point(256, 170);
            dgvPernoHC.Margin = new Padding(3, 2, 3, 2);
            dgvPernoHC.Name = "dgvPernoHC";
            dgvPernoHC.RowHeadersWidth = 51;
            dgvPernoHC.Size = new Size(379, 380);
            dgvPernoHC.TabIndex = 23;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(10, 9);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(82, 28);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // LBResultados
            // 
            LBResultados.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBResultados.FormattingEnabled = true;
            LBResultados.ItemHeight = 19;
            LBResultados.Location = new Point(19, 222);
            LBResultados.Margin = new Padding(3, 2, 3, 2);
            LBResultados.Name = "LBResultados";
            LBResultados.Size = new Size(196, 80);
            LBResultados.TabIndex = 28;
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
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // PernoHiloCorriente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(701, 601);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox3);
            Controls.Add(LBResultados);
            Controls.Add(dgvPernoHC);
            Controls.Add(label2);
            Controls.Add(cmbPernoHC);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "PernoHiloCorriente";
            Text = "Pernos de Hilo Corriente";
            Load += PernoHiloCorriente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPernoHC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cmbPernoHC;
        private Label label2;
        private DataGridView dgvPernoHC;
        private Button btnVolver;
        private ListBox LBResultados;
        private PictureBox pictureBox3;
    }
}