namespace Catálogo_de_Pernos_ESAN_Ferretería
{
    partial class m10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(m10));
            btnVolver = new Button();
            label1 = new Label();
            dgvM10 = new DataGridView();
            Milimetro = new DataGridViewTextBoxColumn();
            Largo10 = new DataGridViewTextBoxColumn();
            DiametroEnPulgadas = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            cmbM10 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvM10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 38);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(8, 33, 131);
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(314, 67);
            label1.Name = "label1";
            label1.Size = new Size(489, 46);
            label1.TabIndex = 4;
            label1.Text = "M10 en milimetros y pulgada";
            // 
            // dgvM10
            // 
            dgvM10.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvM10.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvM10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvM10.Columns.AddRange(new DataGridViewColumn[] { Milimetro, Largo10, DiametroEnPulgadas });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvM10.DefaultCellStyle = dataGridViewCellStyle2;
            dgvM10.Location = new Point(366, 226);
            dgvM10.Name = "dgvM10";
            dgvM10.RowHeadersWidth = 51;
            dgvM10.Size = new Size(500, 689);
            dgvM10.TabIndex = 6;
            // 
            // Milimetro
            // 
            Milimetro.DataPropertyName = "Milimetros";
            Milimetro.HeaderText = "Milimetro";
            Milimetro.MinimumWidth = 6;
            Milimetro.Name = "Milimetro";
            Milimetro.Width = 125;
            // 
            // Largo10
            // 
            Largo10.DataPropertyName = "Largo10";
            Largo10.HeaderText = "Largo";
            Largo10.MinimumWidth = 6;
            Largo10.Name = "Largo10";
            Largo10.Width = 125;
            // 
            // DiametroEnPulgadas
            // 
            DiametroEnPulgadas.DataPropertyName = "DiametroEnPulgadas";
            DiametroEnPulgadas.HeaderText = "Diametro en pulgadas";
            DiametroEnPulgadas.MinimumWidth = 6;
            DiametroEnPulgadas.Name = "DiametroEnPulgadas";
            DiametroEnPulgadas.Width = 200;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000021195;
            pictureBox1.Location = new Point(-1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(885, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1000021195;
            pictureBox2.Location = new Point(536, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(642, 204);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 249);
            label4.Name = "label4";
            label4.Size = new Size(224, 28);
            label4.TabIndex = 24;
            label4.Text = "Medidas de los pernos";
            // 
            // cmbM10
            // 
            cmbM10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbM10.FormattingEnabled = true;
            cmbM10.Location = new Point(12, 280);
            cmbM10.Name = "cmbM10";
            cmbM10.Size = new Size(224, 36);
            cmbM10.TabIndex = 23;
            cmbM10.SelectedIndexChanged += cmbM10_SelectedIndexChanged;
            // 
            // m10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(878, 950);
            Controls.Add(label4);
            Controls.Add(cmbM10);
            Controls.Add(dgvM10);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "m10";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pernos M10 (3/8\")";
            Load += m10_Load;
            ((System.ComponentModel.ISupportInitialize)dgvM10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVolver;
        private Label label1;
        private DataGridView dgvM10;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private ComboBox cmbM10;
        private DataGridViewTextBoxColumn Milimetro;
        private DataGridViewTextBoxColumn Largo10;
        private DataGridViewTextBoxColumn DiametroEnPulgadas;
    }
}