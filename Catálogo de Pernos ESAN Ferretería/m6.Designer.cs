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
            btnVolver = new Button();
            dgvM6 = new DataGridView();
            milimetros = new DataGridViewTextBoxColumn();
            diametropulgadas = new DataGridViewTextBoxColumn();
            largopulgadas = new DataGridViewTextBoxColumn();
            alternativa = new DataGridViewTextBoxColumn();
            diferencia = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnMostrar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvM6).BeginInit();
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
            // dgvM6
            // 
            dgvM6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvM6.Columns.AddRange(new DataGridViewColumn[] { milimetros, diametropulgadas, largopulgadas, alternativa, diferencia });
            dgvM6.Location = new Point(79, 149);
            dgvM6.Name = "dgvM6";
            dgvM6.RowHeadersWidth = 51;
            dgvM6.Size = new Size(650, 188);
            dgvM6.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 51);
            label1.Name = "label1";
            label1.Size = new Size(284, 20);
            label1.TabIndex = 2;
            label1.Text = "M6 en milimetros, pulgadas y alternativas";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(79, 114);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(94, 29);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 71);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 4;
            label2.Text = "PERNOS FINOS";
            // 
            // m6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnMostrar);
            Controls.Add(label1);
            Controls.Add(dgvM6);
            Controls.Add(btnVolver);
            Name = "m6";
            Text = "m6";
            Load += m6_Load;
            ((System.ComponentModel.ISupportInitialize)dgvM6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private DataGridView dgvM6;
        private Label label1;
        private Button btnMostrar;
        private DataGridViewTextBoxColumn milimetros;
        private DataGridViewTextBoxColumn diametropulgadas;
        private DataGridViewTextBoxColumn largopulgadas;
        private DataGridViewTextBoxColumn alternativa;
        private DataGridViewTextBoxColumn diferencia;
        private Label label2;
    }
}