namespace WinFormsApp
{
    partial class MenuPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonConectarDesconectar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSair,
            this.toolStripButtonConectarDesconectar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(648, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSair
            // 
            this.toolStripButtonSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonSair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSair.Image")));
            this.toolStripButtonSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSair.Name = "toolStripButtonSair";
            this.toolStripButtonSair.Size = new System.Drawing.Size(57, 25);
            this.toolStripButtonSair.Text = "Sair";
            this.toolStripButtonSair.ToolTipText = "Sair do sistema";
            // 
            // toolStripButtonConectarDesconectar
            // 
            this.toolStripButtonConectarDesconectar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonConectarDesconectar.Image")));
            this.toolStripButtonConectarDesconectar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConectarDesconectar.Name = "toolStripButtonConectarDesconectar";
            this.toolStripButtonConectarDesconectar.Size = new System.Drawing.Size(163, 25);
            this.toolStripButtonConectarDesconectar.Text = "Conectar ao SQLite";
            this.toolStripButtonConectarDesconectar.ToolTipText = "Conectar ao SQLite";
            this.toolStripButtonConectarDesconectar.Click += new System.EventHandler(this.toolStripButtonConectarDesconectar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(27, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 82);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(561, 26);
            this.textBox1.TabIndex = 0;
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 330);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MenuPrincipalForm";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSair;
        private System.Windows.Forms.ToolStripButton toolStripButtonConectarDesconectar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

