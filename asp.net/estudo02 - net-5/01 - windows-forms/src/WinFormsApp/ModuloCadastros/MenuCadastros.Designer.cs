
namespace SistemaMenus
{
    partial class MenuCadastros
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonClasses = new System.Windows.Forms.Button();
            this.buttonBancos = new System.Windows.Forms.Button();
            this.panelForms = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelMenu.Controls.Add(this.buttonVoltar);
            this.panelMenu.Controls.Add(this.buttonClasses);
            this.panelMenu.Controls.Add(this.buttonBancos);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(785, 35);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonVoltar.FlatAppearance.BorderSize = 0;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar.Location = new System.Drawing.Point(232, 0);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(116, 35);
            this.buttonVoltar.TabIndex = 5;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonClasses
            // 
            this.buttonClasses.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonClasses.FlatAppearance.BorderSize = 0;
            this.buttonClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClasses.Location = new System.Drawing.Point(116, 0);
            this.buttonClasses.Name = "buttonClasses";
            this.buttonClasses.Size = new System.Drawing.Size(116, 35);
            this.buttonClasses.TabIndex = 4;
            this.buttonClasses.Text = "Classe";
            this.buttonClasses.UseVisualStyleBackColor = true;
            this.buttonClasses.Click += new System.EventHandler(this.buttonClasses_Click);
            // 
            // buttonBancos
            // 
            this.buttonBancos.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBancos.FlatAppearance.BorderSize = 0;
            this.buttonBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBancos.Location = new System.Drawing.Point(0, 0);
            this.buttonBancos.Name = "buttonBancos";
            this.buttonBancos.Size = new System.Drawing.Size(116, 35);
            this.buttonBancos.TabIndex = 3;
            this.buttonBancos.Text = "Banco";
            this.buttonBancos.UseVisualStyleBackColor = true;
            // 
            // panelForms
            // 
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(0, 35);
            this.panelForms.Margin = new System.Windows.Forms.Padding(2);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(785, 415);
            this.panelForms.TabIndex = 1;
            // 
            // MenuCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuCadastros";
            this.Text = "MenuCadastros";
            this.Load += new System.EventHandler(this.MenuCadastros_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonClasses;
        private System.Windows.Forms.Button buttonBancos;
    }
}