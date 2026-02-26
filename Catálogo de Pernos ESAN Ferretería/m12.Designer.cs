namespace Catálogo_de_Pernos_ESAN_Ferretería
{
    partial class m12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(m12));
            btnVolver = new Button();
            label1 = new Label();
            dgvM12 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            largom12 = new DataGridViewTextBoxColumn();
            diametropulgadam12 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            cmbM12 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvM12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(97, 38);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(8, 33, 131);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(317, 83);
            label1.Name = "label1";
            label1.Size = new Size(415, 38);
            label1.TabIndex = 5;
            label1.Text = "M12 en milimetros y pulgadas";
            // 
            // dgvM12
            // 
            dgvM12.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvM12.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvM12.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvM12.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, largom12, diametropulgadam12 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvM12.DefaultCellStyle = dataGridViewCellStyle2;
            dgvM12.Location = new Point(283, 221);
            dgvM12.Name = "dgvM12";
            dgvM12.RowHeadersWidth = 51;
            dgvM12.Size = new Size(520, 688);
            dgvM12.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Milimetros";
            dataGridViewTextBoxColumn1.HeaderText = "Milimetros";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 170;
            // 
            // largom12
            // 
            largom12.DataPropertyName = "Largo12";
            largom12.HeaderText = "Largo";
            largom12.MinimumWidth = 6;
            largom12.Name = "largom12";
            largom12.Width = 125;
            // 
            // diametropulgadam12
            // 
            diametropulgadam12.DataPropertyName = "DiametroEnPulgadas";
            diametropulgadam12.HeaderText = "Diametro en pulgadas";
            diametropulgadam12.MinimumWidth = 6;
            diametropulgadam12.Name = "diametropulgadam12";
            diametropulgadam12.Width = 170;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000021195;
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(885, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1000021195;
            pictureBox2.Location = new Point(448, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(885, 204);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 221);
            label4.Name = "label4";
            label4.Size = new Size(224, 28);
            label4.TabIndex = 26;
            label4.Text = "Medidas de los pernos";
            // 
            // cmbM12
            // 
            cmbM12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbM12.FormattingEnabled = true;
            cmbM12.Location = new Point(12, 252);
            cmbM12.Name = "cmbM12";
            cmbM12.Size = new Size(224, 36);
            cmbM12.TabIndex = 25;
            cmbM12.SelectedIndexChanged += cmbM12_SelectedIndexChanged;
            // 
            // m12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(845, 930);
            Controls.Add(label4);
            Controls.Add(cmbM12);
            Controls.Add(dgvM12);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "m12";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pernos M12 (1/2\")";
            Load += m12_Load;
            ((System.ComponentModel.ISupportInitialize)dgvM12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label label1;
        private DataGridView dgvM12;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private ComboBox cmbM12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn largom12;
        private DataGridViewTextBoxColumn diametropulgadam12;
    }
}