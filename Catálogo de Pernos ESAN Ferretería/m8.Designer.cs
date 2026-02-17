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
            btnVolver = new Button();
            label1 = new Label();
            dgvM8 = new DataGridView();
            milimetros = new DataGridViewTextBoxColumn();
            diametropulgadas = new DataGridViewTextBoxColumn();
            largopulgadas = new DataGridViewTextBoxColumn();
            alternativa = new DataGridViewTextBoxColumn();
            diferencia = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvM8).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 36);
            label1.Name = "label1";
            label1.Size = new Size(462, 31);
            label1.TabIndex = 3;
            label1.Text = "M8 en milimetros, pulgadas y alternativas";
            // 
            // dgvM8
            // 
            dgvM8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvM8.Columns.AddRange(new DataGridViewColumn[] { milimetros, diametropulgadas, largopulgadas, alternativa, diferencia });
            dgvM8.Location = new Point(21, 127);
            dgvM8.Name = "dgvM8";
            dgvM8.RowHeadersWidth = 51;
            dgvM8.Size = new Size(767, 275);
            dgvM8.TabIndex = 4;
            // 
            // milimetros
            // 
            milimetros.HeaderText = "Milimetros";
            milimetros.MinimumWidth = 6;
            milimetros.Name = "milimetros";
            milimetros.Width = 125;
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
            alternativa.Width = 125;
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
            label2.Location = new Point(281, 67);
            label2.Name = "label2";
            label2.Size = new Size(268, 28);
            label2.TabIndex = 5;
            label2.Text = "PERNO FINO AUTOMOTRIZ";
            // 
            // m8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(dgvM8);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Name = "m8";
            Text = "m8";
            Load += m8_Load;
            ((System.ComponentModel.ISupportInitialize)dgvM8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label label1;
        private DataGridView dgvM8;
        private DataGridViewTextBoxColumn milimetros;
        private DataGridViewTextBoxColumn diametropulgadas;
        private DataGridViewTextBoxColumn largopulgadas;
        private DataGridViewTextBoxColumn alternativa;
        private DataGridViewTextBoxColumn diferencia;
        private Label label2;
    }
}