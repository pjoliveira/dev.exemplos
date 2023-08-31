
namespace SistemaMenus
{
    partial class MenuParametros
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
            this.panelForms = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonPaises = new System.Windows.Forms.Button();
            this.buttonEstados = new System.Windows.Forms.Button();
            this.buttonMunicipios = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForms
            // 
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(0, 35);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(785, 415);
            this.panelForms.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonVoltar);
            this.panelMenu.Controls.Add(this.buttonPaises);
            this.panelMenu.Controls.Add(this.buttonEstados);
            this.panelMenu.Controls.Add(this.buttonMunicipios);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(785, 35);
            this.panelMenu.TabIndex = 2;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonVoltar.FlatAppearance.BorderSize = 0;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar.Location = new System.Drawing.Point(447, 0);
            this.buttonVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(149, 35);
            this.buttonVoltar.TabIndex = 6;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonPaises
            // 
            this.buttonPaises.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPaises.FlatAppearance.BorderSize = 0;
            this.buttonPaises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPaises.Location = new System.Drawing.Point(298, 0);
            this.buttonPaises.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPaises.Name = "buttonPaises";
            this.buttonPaises.Size = new System.Drawing.Size(149, 35);
            this.buttonPaises.TabIndex = 5;
            this.buttonPaises.Text = "Paises";
            this.buttonPaises.UseVisualStyleBackColor = true;
            // 
            // buttonEstados
            // 
            this.buttonEstados.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonEstados.FlatAppearance.BorderSize = 0;
            this.buttonEstados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEstados.Location = new System.Drawing.Point(149, 0);
            this.buttonEstados.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEstados.Name = "buttonEstados";
            this.buttonEstados.Size = new System.Drawing.Size(149, 35);
            this.buttonEstados.TabIndex = 4;
            this.buttonEstados.Text = "Estado";
            this.buttonEstados.UseVisualStyleBackColor = true;
            // 
            // buttonMunicipios
            // 
            this.buttonMunicipios.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonMunicipios.FlatAppearance.BorderSize = 0;
            this.buttonMunicipios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMunicipios.Location = new System.Drawing.Point(0, 0);
            this.buttonMunicipios.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMunicipios.Name = "buttonMunicipios";
            this.buttonMunicipios.Size = new System.Drawing.Size(149, 35);
            this.buttonMunicipios.TabIndex = 3;
            this.buttonMunicipios.Text = "Municipios";
            this.buttonMunicipios.UseVisualStyleBackColor = true;
            // 
            // MenuParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuParametros";
            this.Text = "MenuParametros";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonPaises;
        private System.Windows.Forms.Button buttonEstados;
        private System.Windows.Forms.Button buttonMunicipios;
    }
}