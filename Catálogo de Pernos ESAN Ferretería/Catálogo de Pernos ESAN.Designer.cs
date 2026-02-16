namespace Catálogo_de_Pernos_ESAN_Ferretería
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnM6 = new Button();
            btmM8 = new Button();
            btnM10 = new Button();
            btnM12 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 23);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 1;
            label1.Text = "CATÁLOGO DE PERNOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 43);
            label2.Name = "label2";
            label2.Size = new Size(266, 20);
            label2.TabIndex = 2;
            label2.Text = "BÚSQUEDA RÁPIDA Y EQUIVALENCIAS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 63);
            label4.Name = "label4";
            label4.Size = new Size(322, 20);
            label4.TabIndex = 5;
            label4.Text = "LAS PULGADAS SON MEDIDAS APROXIMADAS";
            // 
            // btnM6
            // 
            btnM6.Location = new Point(157, 222);
            btnM6.Name = "btnM6";
            btnM6.Size = new Size(129, 48);
            btnM6.TabIndex = 6;
            btnM6.Text = "M6 - 1.25 (1/4\")";
            btnM6.UseVisualStyleBackColor = true;
            btnM6.Click += btnM6_Click;
            // 
            // btmM8
            // 
            btmM8.Location = new Point(311, 222);
            btmM8.Name = "btmM8";
            btmM8.Size = new Size(132, 48);
            btmM8.TabIndex = 7;
            btmM8.Text = "M8 - 1.25 (5/16\")";
            btmM8.UseVisualStyleBackColor = true;
            btmM8.Click += btmM8_Click;
            // 
            // btnM10
            // 
            btnM10.Location = new Point(461, 222);
            btnM10.Name = "btnM10";
            btnM10.Size = new Size(182, 48);
            btnM10.TabIndex = 8;
            btnM10.Text = "M10 - 1.25 y 1.5 (3/8\")";
            btnM10.UseVisualStyleBackColor = true;
            btnM10.Click += btnM10_Click;
            // 
            // btnM12
            // 
            btnM12.Location = new Point(157, 297);
            btnM12.Name = "btnM12";
            btnM12.Size = new Size(205, 48);
            btnM12.TabIndex = 9;
            btnM12.Text = "M12 - 1.25, 1.5 y 1.75 (1/2\")";
            btnM12.UseVisualStyleBackColor = true;
            btnM12.Click += btnM12_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 27);
            textBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 117);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 11;
            label3.Text = "Buscar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(btnM12);
            Controls.Add(btnM10);
            Controls.Add(btmM8);
            Controls.Add(btnM6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label4;
        private Button btnM6;
        private Button btmM8;
        private Button btnM10;
        private Button btnM12;
        private TextBox textBox1;
        private Label label3;
    }
}
