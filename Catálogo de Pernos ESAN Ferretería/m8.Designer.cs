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
            diametropulgadas = new DataGridViewTextBoxColumn();
            largopulgadas = new DataGridViewTextBoxColumn();
            alternativa = new DataGridViewTextBoxColumn();
            diferencia = new DataGridViewTextBoxColumn();
            label2 = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvM8).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(205, 36);
            label1.Name = "label1";
            label1.Size = new Size(462, 31);
            label1.TabIndex = 3;
            label1.Text = "M8 en milimetros, pulgadas y alternativas";
            // 
            // dgvM8
            // 
            dgvM8.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvM8.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvM8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvM8.Columns.AddRange(new DataGridViewColumn[] { milimetros, diametropulgadas, largopulgadas, alternativa, diferencia });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvM8.DefaultCellStyle = dataGridViewCellStyle2;
            dgvM8.Dock = DockStyle.Bottom;
            dgvM8.Location = new Point(0, 125);
            dgvM8.Name = "dgvM8";
            dgvM8.RowHeadersWidth = 51;
            dgvM8.Size = new Size(800, 614);
            dgvM8.TabIndex = 4;
            // 
            // milimetros
            // 
            milimetros.HeaderText = "Milimetros";
            milimetros.MinimumWidth = 6;
            milimetros.Name = "milimetros";
            milimetros.Width = 200;
            // 
            // diametropulgadas
            // 
            diametropulgadas.HeaderText = "Diametro en pulgadas";
            diametropulgadas.MinimumWidth = 6;
            diametropulgadas.Name = "diametropulgadas";
            diametropulgadas.Width = 125;
            // 
            // largopulgadas
            // 
            largopulgadas.HeaderText = "Largo en pulgadas";
            largopulgadas.MinimumWidth = 6;
            largopulgadas.Name = "largopulgadas";
            largopulgadas.Width = 125;
            // 
            // alternativa
            // 
            alternativa.HeaderText = "Alternativa";
            alternativa.MinimumWidth = 6;
            alternativa.Name = "alternativa";
            alternativa.Width = 150;
            // 
            // diferencia
            // 
            diferencia.HeaderText = "Diferencia";
            diferencia.MinimumWidth = 6;
            diferencia.Name = "diferencia";
            diferencia.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(281, 67);
            label2.Name = "label2";
            label2.Size = new Size(268, 28);
            label2.TabIndex = 5;
            label2.Text = "PERNO FINO AUTOMOTRIZ";
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
            // m8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 739);
            Controls.Add(btnVolver);
            Controls.Add(label2);
            Controls.Add(dgvM8);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "m8";
            Text = "Pernos M8 (5/16\")";
            Load += m8_Load;
            ((System.ComponentModel.ISupportInitialize)dgvM8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvM8;
        private Label label2;
        private DataGridViewTextBoxColumn milimetros;
        private DataGridViewTextBoxColumn diametropulgadas;
        private DataGridViewTextBoxColumn largopulgadas;
        private DataGridViewTextBoxColumn alternativa;
        private DataGridViewTextBoxColumn diferencia;
        private Button btnVolver;
    }
}