namespace Catálogo_de_Pernos_ESAN_Ferretería
{
    partial class PernosGrandes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PernosGrandes));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            btnVolver = new Button();
            cmbPernoG = new ComboBox();
            dgvPernoG = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPernoG).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000021195;
            pictureBox1.Location = new Point(0, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(885, 204);
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
            label1.Location = new Point(359, 82);
            label1.Name = "label1";
            label1.Size = new Size(321, 46);
            label1.TabIndex = 19;
            label1.Text = "PERNOS GRANDES";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 230);
            label4.Name = "label4";
            label4.Size = new Size(224, 28);
            label4.TabIndex = 26;
            label4.Text = "Medidas de los pernos";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 38);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // cmbPernoG
            // 
            cmbPernoG.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPernoG.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPernoG.FormattingEnabled = true;
            cmbPernoG.Location = new Point(40, 261);
            cmbPernoG.Name = "cmbPernoG";
            cmbPernoG.RightToLeft = RightToLeft.No;
            cmbPernoG.Size = new Size(224, 36);
            cmbPernoG.TabIndex = 28;
            cmbPernoG.SelectedIndexChanged += cmbPernoG_SelectedIndexChanged_1;
            // 
            // dgvPernoG
            // 
            dgvPernoG.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPernoG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPernoG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPernoG.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPernoG.Location = new Point(310, 230);
            dgvPernoG.Name = "dgvPernoG";
            dgvPernoG.RightToLeft = RightToLeft.No;
            dgvPernoG.RowHeadersWidth = 51;
            dgvPernoG.Size = new Size(459, 259);
            dgvPernoG.TabIndex = 29;
            // 
            // PernosGrandes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 510);
            Controls.Add(dgvPernoG);
            Controls.Add(cmbPernoG);
            Controls.Add(btnVolver);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PernosGrandes";
            Text = "Pernos Grandes con Hilo Fino y Corriente";
            Load += PernosGrandes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPernoG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Button btnVolver;
        private ComboBox cmbPernoG;
        private DataGridView dgvPernoG;
    }
}