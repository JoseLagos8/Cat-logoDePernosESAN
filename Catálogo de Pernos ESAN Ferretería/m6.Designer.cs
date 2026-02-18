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
            dgvM6 = new DataGridView();
            milimetros = new DataGridViewTextBoxColumn();
            diametropulgadas = new DataGridViewTextBoxColumn();
            largopulgadas = new DataGridViewTextBoxColumn();
            alternativa = new DataGridViewTextBoxColumn();
            diferencia = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvM6).BeginInit();
            SuspendLayout();
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
            dgvM6.Columns.AddRange(new DataGridViewColumn[] { milimetros, diametropulgadas, largopulgadas, alternativa, diferencia });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvM6.DefaultCellStyle = dataGridViewCellStyle2;
            dgvM6.Dock = DockStyle.Bottom;
            dgvM6.Location = new Point(0, 112);
            dgvM6.Name = "dgvM6";
            dgvM6.RowHeadersWidth = 51;
            dgvM6.Size = new Size(800, 729);
            dgvM6.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 12);
            label1.Name = "label1";
            label1.Size = new Size(568, 38);
            label1.TabIndex = 2;
            label1.Text = "M6 en milimetros, pulgadas y alternativas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(281, 50);
            label2.Name = "label2";
            label2.Size = new Size(217, 38);
            label2.TabIndex = 4;
            label2.Text = "PERNOS FINOS";
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
            // m6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 841);
            Controls.Add(btnVolver);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvM6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "m6";
            Text = "Pernos M6 (1/4\")";
            Load += m6_Load;
            ((System.ComponentModel.ISupportInitialize)dgvM6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvM6;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn milimetros;
        private DataGridViewTextBoxColumn diametropulgadas;
        private DataGridViewTextBoxColumn largopulgadas;
        private DataGridViewTextBoxColumn alternativa;
        private DataGridViewTextBoxColumn diferencia;
        private Button btnVolver;
    }
}