namespace Catálogo_de_Pernos_ESAN_Ferretería
{
    partial class m14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(m14));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvM14 = new DataGridView();
            milimetro = new DataGridViewTextBoxColumn();
            largoperno = new DataGridViewTextBoxColumn();
            diametropulgada = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvM14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000021195;
            pictureBox1.Location = new Point(-21, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(688, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(8, 33, 131);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(249, 64);
            label1.Name = "label1";
            label1.Size = new Size(317, 60);
            label1.TabIndex = 21;
            label1.Text = "M14 en milimetros y pulgada\r\n\r\n";
            // 
            // dgvM14
            // 
            dgvM14.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvM14.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvM14.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvM14.Columns.AddRange(new DataGridViewColumn[] { milimetro, largoperno, diametropulgada });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvM14.DefaultCellStyle = dataGridViewCellStyle2;
            dgvM14.Location = new Point(60, 171);
            dgvM14.Margin = new Padding(3, 2, 3, 2);
            dgvM14.Name = "dgvM14";
            dgvM14.RowHeadersWidth = 51;
            dgvM14.Size = new Size(512, 459);
            dgvM14.TabIndex = 22;
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
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(10, 9);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(82, 28);
            btnVolver.TabIndex = 23;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(9, 38, 118);
            pictureBox2.Image = Properties.Resources.MER_Chillán1;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(189, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // m14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(664, 646);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox2);
            Controls.Add(dgvM14);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "m14";
            Text = "Pernos M14 (9/16\")";
            Load += m14_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvM14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvM14;
        private DataGridViewTextBoxColumn milimetro;
        private DataGridViewTextBoxColumn largoperno;
        private DataGridViewTextBoxColumn diametropulgada;
        private Button btnVolver;
        private PictureBox pictureBox2;
    }
}