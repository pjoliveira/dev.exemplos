
namespace WinFormsApp
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonMenuParametros = new System.Windows.Forms.Button();
            this.buttonMenuCadastros = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.buttonMenuParametros);
            this.panel1.Controls.Add(this.buttonMenuCadastros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 35);
            this.panel1.TabIndex = 0;
            // 
            // buttonSair
            // 
            this.buttonSair.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Location = new System.Drawing.Point(298, 0);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(149, 35);
            this.buttonSair.TabIndex = 2;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonMenuParametros
            // 
            this.buttonMenuParametros.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonMenuParametros.FlatAppearance.BorderSize = 0;
            this.buttonMenuParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuParametros.Location = new System.Drawing.Point(149, 0);
            this.buttonMenuParametros.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMenuParametros.Name = "buttonMenuParametros";
            this.buttonMenuParametros.Size = new System.Drawing.Size(149, 35);
            this.buttonMenuParametros.TabIndex = 1;
            this.buttonMenuParametros.Text = "Parametros";
            this.buttonMenuParametros.UseVisualStyleBackColor = true;
            this.buttonMenuParametros.Click += new System.EventHandler(this.buttonMenuParametros_Click);
            // 
            // buttonMenuCadastros
            // 
            this.buttonMenuCadastros.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonMenuCadastros.FlatAppearance.BorderSize = 0;
            this.buttonMenuCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuCadastros.Location = new System.Drawing.Point(0, 0);
            this.buttonMenuCadastros.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMenuCadastros.Name = "buttonMenuCadastros";
            this.buttonMenuCadastros.Size = new System.Drawing.Size(149, 35);
            this.buttonMenuCadastros.TabIndex = 0;
            this.buttonMenuCadastros.Text = "Cadastros";
            this.buttonMenuCadastros.UseVisualStyleBackColor = true;
            this.buttonMenuCadastros.Click += new System.EventHandler(this.buttonMenuCadastros_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 315);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Aplicação estudo 01";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonMenuParametros;
        private System.Windows.Forms.Button buttonMenuCadastros;
    }
}

