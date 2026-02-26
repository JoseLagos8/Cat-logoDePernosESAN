namespace Catálogo_de_Pernos_ESAN_Ferretería
{
    partial class m8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(m8));
            label1 = new Label();
            dgvM8 = new DataGridView();
            milimetros = new DataGridViewTextBoxColumn();
            largom8 = new DataGridViewTextBoxColumn();
            diametroenpulgadasm8 = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvM8).BeginInit();
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
            label1.Location = new Point(297, 81);
            label1.Name = "label1";
            label1.Size = new Size(399, 38);
            label1.TabIndex = 3;
            label1.Text = "M8 en milimetros y pulgadas";
            // 
            // dgvM8
            // 
            dgvM8.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvM8.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvM8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvM8.Columns.AddRange(new DataGridViewColumn[] { milimetros, largom8, diametroenpulgadasm8 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvM8.DefaultCellStyle = dataGridViewCellStyle2;
            dgvM8.Location = new Point(101, 222);
            dgvM8.Name = "dgvM8";
            dgvM8.RowHeadersWidth = 51;
            dgvM8.Size = new Size(520, 614);
            dgvM8.TabIndex = 4;
            // 
            // milimetros
            // 
            milimetros.HeaderText = "Milimetros";
            milimetros.MinimumWidth = 6;
            milimetros.Name = "milimetros";
            milimetros.Width = 170;
            // 
            // largom8
            // 
            largom8.HeaderText = "Largo";
            largom8.MinimumWidth = 6;
            largom8.Name = "largom8";
            largom8.Width = 125;
            // 
            // diametroenpulgadasm8
            // 
            diametroenpulgadasm8.HeaderText = "Diametro en pulgadas";
            diametroenpulgadasm8.MinimumWidth = 6;
            diametroenpulgadasm8.Name = "diametroenpulgadasm8";
            diametroenpulgadasm8.Width = 170;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 38);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000021195;
            pictureBox1.Location = new Point(-1, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(885, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1000021195;
            pictureBox2.Location = new Point(340, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(885, 204);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // m8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(719, 848);
            Controls.Add(btnVolver);
            Controls.Add(dgvM8);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "m8";
            Text = "Pernos M8 (5/16\")";
            Load += m8_Load;
            ((System.ComponentModel.ISupportInitialize)dgvM8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvM8;
        private Button btnVolver;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn milimetros;
        private DataGridViewTextBoxColumn largom8;
        private DataGridViewTextBoxColumn diametroenpulgadasm8;
    }
}