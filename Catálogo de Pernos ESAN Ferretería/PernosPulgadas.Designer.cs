namespace Catálogo_de_Pernos_ESAN_Ferretería
{
    partial class PernosPulgadas
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvPernosPGeneral = new DataGridView();
            diametroxlargo = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPernosPGeneral).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000021195;
            pictureBox1.Location = new Point(-4, -10);
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
            label1.Location = new Point(307, 63);
            label1.Name = "label1";
            label1.Size = new Size(331, 46);
            label1.TabIndex = 20;
            label1.Text = "Pernos en pulgadas";
            // 
            // dgvPernosPGeneral
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPernosPGeneral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPernosPGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPernosPGeneral.Columns.AddRange(new DataGridViewColumn[] { diametroxlargo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPernosPGeneral.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPernosPGeneral.Location = new Point(12, 236);
            dgvPernosPGeneral.Name = "dgvPernosPGeneral";
            dgvPernosPGeneral.RowHeadersWidth = 51;
            dgvPernosPGeneral.Size = new Size(647, 601);
            dgvPernosPGeneral.TabIndex = 21;
            // 
            // diametroxlargo
            // 
            diametroxlargo.HeaderText = "Diametro x Largo en pulgadas";
            diametroxlargo.MinimumWidth = 6;
            diametroxlargo.Name = "diametroxlargo";
            diametroxlargo.Width = 330;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 38);
            btnVolver.TabIndex = 22;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // PernosPulgadas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(671, 941);
            Controls.Add(btnVolver);
            Controls.Add(dgvPernosPGeneral);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PernosPulgadas";
            Text = "PernosPulgadas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPernosPGeneral).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvPernosPGeneral;
        private DataGridViewTextBoxColumn diametroxlargo;
        private Button btnVolver;
    }
}