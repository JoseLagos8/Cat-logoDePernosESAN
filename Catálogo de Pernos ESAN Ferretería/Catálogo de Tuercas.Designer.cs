namespace Catálogo_de_Pernos_ESAN_Ferretería
{
    partial class Catálogo_de_Tuercas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catálogo_de_Tuercas));
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            catálogoToolStripMenuItem = new ToolStripMenuItem();
            pernosToolStripMenuItem = new ToolStripMenuItem();
            dgvTuercas = new DataGridView();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTuercas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(8, 33, 131);
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(319, 104);
            label1.Name = "label1";
            label1.Size = new Size(407, 46);
            label1.TabIndex = 26;
            label1.Text = "CATÁLOGO DE TUERCAS";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { catálogoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(764, 33);
            menuStrip1.TabIndex = 27;
            menuStrip1.Text = "menuStrip1";
            // 
            // catálogoToolStripMenuItem
            // 
            catálogoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pernosToolStripMenuItem });
            catálogoToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            catálogoToolStripMenuItem.Name = "catálogoToolStripMenuItem";
            catálogoToolStripMenuItem.Size = new Size(110, 29);
            catálogoToolStripMenuItem.Text = "Catálogos";
            // 
            // pernosToolStripMenuItem
            // 
            pernosToolStripMenuItem.Name = "pernosToolStripMenuItem";
            pernosToolStripMenuItem.Size = new Size(224, 30);
            pernosToolStripMenuItem.Text = "Pernos";
            pernosToolStripMenuItem.Click += pernosToolStripMenuItem_Click;
            // 
            // dgvTuercas
            // 
            dgvTuercas.BackgroundColor = SystemColors.ButtonFace;
            dgvTuercas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTuercas.Location = new Point(74, 305);
            dgvTuercas.Name = "dgvTuercas";
            dgvTuercas.RowHeadersWidth = 51;
            dgvTuercas.Size = new Size(610, 310);
            dgvTuercas.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1000021195;
            pictureBox1.Location = new Point(0, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(764, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // Catálogo_de_Tuercas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(764, 653);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvTuercas);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Catálogo_de_Tuercas";
            Text = "Catálogo de Tuercas";
            Load += Catálogo_de_Tuercas_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTuercas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem catálogoToolStripMenuItem;
        private ToolStripMenuItem pernosToolStripMenuItem;
        private DataGridView dgvTuercas;
        private PictureBox pictureBox1;
    }
}