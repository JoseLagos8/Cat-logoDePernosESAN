namespace Catálogo_de_Pernos_ESAN_Ferretería
{
    partial class m6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(m6));
            label1 = new Label();
            btnVolver = new Button();
            dgvM6 = new DataGridView();
            milimetro = new DataGridViewTextBoxColumn();
            largoperno = new DataGridViewTextBoxColumn();
            diametropulgada = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvM6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(8, 33, 131);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(320, 88);
            label1.Name = "label1";
            label1.Size = new Size(387, 38);
            label1.TabIndex = 2;
            label1.Text = "M6 en milimetros y pulgada\r\n";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 38);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // dgvM6
            // 
            dgvM6.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvM6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvM6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvM6.Columns.AddRange(new DataGridViewColumn[] { milimetro, largoperno, diametropulgada });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvM6.DefaultCellStyle = dataGridViewCellStyle2;
            dgvM6.Location = new Point(122, 207);
            dgvM6.Name = "dgvM6";
            dgvM6.RowHeadersWidth = 51;
            dgvM6.Size = new Size(585, 612);
            dgvM6.TabIndex = 6;
            // 
            // milimetro
            // 
            milimetro.HeaderText = "Milimetro";
            milimetro.MinimumWidth = 6;
            milimetro.Name = "milimetro";
            milimetro.Width = 125;
            // 
            // largoperno
            // 
            largoperno.HeaderText = "Largo";
            largoperno.MinimumWidth = 6;
            largoperno.Name = "largoperno";
            largoperno.Width = 125;
            // 
            // diametropulgada
            // 
            diametropulgada.HeaderText = "Diametro en pulgadas";
            diametropulgada.MinimumWidth = 6;
            diametropulgada.Name = "diametropulgada";
            diametropulgada.Width = 280;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000021195;
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(885, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1000021195;
            pictureBox2.Location = new Point(112, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(885, 204);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // m6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(772, 841);
            Controls.Add(dgvM6);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "m6";
            Text = "Pernos M6 (1/4\")";
            Load += m6_Load;
            ((System.ComponentModel.ISupportInitialize)dgvM6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnVolver;
        private DataGridView dgvM6;
        private DataGridViewTextBoxColumn milimetro;
        private DataGridViewTextBoxColumn largoperno;
        private DataGridViewTextBoxColumn diametropulgada;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}