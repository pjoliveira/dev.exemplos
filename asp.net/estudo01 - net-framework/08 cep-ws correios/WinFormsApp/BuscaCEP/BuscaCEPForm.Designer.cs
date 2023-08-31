namespace WinFormsApp
{
    partial class BuscaCEPForm
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxLogradouro = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BuscaCEPButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarTextBox = new System.Windows.Forms.TextBox();
            this.barraTituloPanel = new System.Windows.Forms.Panel();
            this.descFormLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.textBoxLocalidade = new System.Windows.Forms.TextBox();
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.textBoxJson = new System.Windows.Forms.TextBox();
            this.cEPModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.barraTituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cEPModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxUF);
            this.panel2.Controls.Add(this.textBoxLocalidade);
            this.panel2.Controls.Add(this.textBoxComplemento);
            this.panel2.Controls.Add(this.textBoxBairro);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBoxLogradouro);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.BuscaCEPButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BuscarTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 229);
            this.panel2.TabIndex = 14;
            // 
            // textBoxLogradouro
            // 
            this.textBoxLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLogradouro.Location = new System.Drawing.Point(12, 61);
            this.textBoxLogradouro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLogradouro.Name = "textBoxLogradouro";
            this.textBoxLogradouro.Size = new System.Drawing.Size(644, 29);
            this.textBoxLogradouro.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 229);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 0);
            this.panel3.TabIndex = 5;
            // 
            // BuscaCEPButton
            // 
            this.BuscaCEPButton.Location = new System.Drawing.Point(205, 19);
            this.BuscaCEPButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuscaCEPButton.Name = "BuscaCEPButton";
            this.BuscaCEPButton.Size = new System.Drawing.Size(216, 32);
            this.BuscaCEPButton.TabIndex = 4;
            this.BuscaCEPButton.Text = "Buscar - ViaCEP";
            this.BuscaCEPButton.UseVisualStyleBackColor = true;
            this.BuscaCEPButton.Click += new System.EventHandler(this.BuscaCEPButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o CEP";
            // 
            // BuscarTextBox
            // 
            this.BuscarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuscarTextBox.Location = new System.Drawing.Point(12, 23);
            this.BuscarTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuscarTextBox.Name = "BuscarTextBox";
            this.BuscarTextBox.Size = new System.Drawing.Size(185, 29);
            this.BuscarTextBox.TabIndex = 0;
            // 
            // barraTituloPanel
            // 
            this.barraTituloPanel.BackColor = System.Drawing.Color.Blue;
            this.barraTituloPanel.Controls.Add(this.descFormLabel);
            this.barraTituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTituloPanel.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.barraTituloPanel.Location = new System.Drawing.Point(0, 0);
            this.barraTituloPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barraTituloPanel.Name = "barraTituloPanel";
            this.barraTituloPanel.Size = new System.Drawing.Size(681, 37);
            this.barraTituloPanel.TabIndex = 13;
            // 
            // descFormLabel
            // 
            this.descFormLabel.AutoSize = true;
            this.descFormLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Italic);
            this.descFormLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.descFormLabel.Location = new System.Drawing.Point(4, 6);
            this.descFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descFormLabel.Name = "descFormLabel";
            this.descFormLabel.Size = new System.Drawing.Size(142, 28);
            this.descFormLabel.TabIndex = 0;
            this.descFormLabel.Text = "Buscar CEP";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar - WS Correios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBairro.Location = new System.Drawing.Point(12, 100);
            this.textBoxBairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(644, 29);
            this.textBoxBairro.TabIndex = 8;
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxComplemento.Location = new System.Drawing.Point(12, 139);
            this.textBoxComplemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(644, 29);
            this.textBoxComplemento.TabIndex = 9;
            // 
            // textBoxLocalidade
            // 
            this.textBoxLocalidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLocalidade.Location = new System.Drawing.Point(12, 178);
            this.textBoxLocalidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLocalidade.Name = "textBoxLocalidade";
            this.textBoxLocalidade.Size = new System.Drawing.Size(552, 29);
            this.textBoxLocalidade.TabIndex = 10;
            // 
            // textBoxUF
            // 
            this.textBoxUF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUF.Location = new System.Drawing.Point(572, 178);
            this.textBoxUF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUF.Name = "textBoxUF";
            this.textBoxUF.Size = new System.Drawing.Size(84, 29);
            this.textBoxUF.TabIndex = 11;
            // 
            // textBoxJson
            // 
            this.textBoxJson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxJson.Location = new System.Drawing.Point(0, 274);
            this.textBoxJson.Multiline = true;
            this.textBoxJson.Name = "textBoxJson";
            this.textBoxJson.Size = new System.Drawing.Size(681, 96);
            this.textBoxJson.TabIndex = 15;
            // 
            // cEPModelBindingSource
            // 
            this.cEPModelBindingSource.AllowNew = false;
            this.cEPModelBindingSource.DataSource = typeof(WinFormsApp.CepModel);
            // 
            // BuscaCEPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 370);
            this.Controls.Add(this.textBoxJson);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.barraTituloPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BuscaCEPForm";
            this.Text = "BuscaCEPForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.barraTituloPanel.ResumeLayout(false);
            this.barraTituloPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cEPModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BuscaCEPButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BuscarTextBox;
        private System.Windows.Forms.Panel barraTituloPanel;
        private System.Windows.Forms.Label descFormLabel;
        private System.Windows.Forms.TextBox textBoxLogradouro;
        private System.Windows.Forms.BindingSource cEPModelBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.TextBox textBoxUF;
        private System.Windows.Forms.TextBox textBoxLocalidade;
        private System.Windows.Forms.TextBox textBoxJson;
    }
}