namespace WinFormsApp
{
    partial class BancoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BancoForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.linhaPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.idEmpresaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nomeRTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codfebrabanTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.botoesPanel = new System.Windows.Forms.Panel();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ConfirmarButton = new System.Windows.Forms.Button();
            this.barraTituloPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.botoesPanel.SuspendLayout();
            this.barraTituloPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linhaPanel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.idEmpresaTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nomeRTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nomeTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.codfebrabanTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.IDtextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 279);
            this.panel2.TabIndex = 15;
            // 
            // linhaPanel
            // 
            this.linhaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linhaPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaPanel.Location = new System.Drawing.Point(0, 278);
            this.linhaPanel.Name = "linhaPanel";
            this.linhaPanel.Size = new System.Drawing.Size(671, 1);
            this.linhaPanel.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "id Empresa";
            // 
            // idEmpresaTextBox
            // 
            this.idEmpresaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idEmpresaTextBox.Location = new System.Drawing.Point(283, 203);
            this.idEmpresaTextBox.Name = "idEmpresaTextBox";
            this.idEmpresaTextBox.Size = new System.Drawing.Size(173, 29);
            this.idEmpresaTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome Reduzido";
            // 
            // nomeRTextBox
            // 
            this.nomeRTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeRTextBox.Location = new System.Drawing.Point(12, 203);
            this.nomeRTextBox.Name = "nomeRTextBox";
            this.nomeRTextBox.Size = new System.Drawing.Size(198, 29);
            this.nomeRTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.Location = new System.Drawing.Point(12, 142);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(458, 29);
            this.nomeTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Codigo Febraban";
            // 
            // codfebrabanTextBox
            // 
            this.codfebrabanTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codfebrabanTextBox.Location = new System.Drawing.Point(12, 88);
            this.codfebrabanTextBox.Name = "codfebrabanTextBox";
            this.codfebrabanTextBox.Size = new System.Drawing.Size(140, 29);
            this.codfebrabanTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // IDtextBox
            // 
            this.IDtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDtextBox.Location = new System.Drawing.Point(489, 31);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(173, 29);
            this.IDtextBox.TabIndex = 0;
            // 
            // botoesPanel
            // 
            this.botoesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.botoesPanel.Controls.Add(this.CancelarButton);
            this.botoesPanel.Controls.Add(this.ConfirmarButton);
            this.botoesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botoesPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botoesPanel.Location = new System.Drawing.Point(0, 311);
            this.botoesPanel.Name = "botoesPanel";
            this.botoesPanel.Size = new System.Drawing.Size(671, 44);
            this.botoesPanel.TabIndex = 14;
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelarButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelarButton.FlatAppearance.BorderSize = 0;
            this.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarButton.ForeColor = System.Drawing.Color.Black;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.ImageKey = "registro;cancelar-48.png";
            this.CancelarButton.ImageList = this.imageList1;
            this.CancelarButton.Location = new System.Drawing.Point(359, 0);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(156, 44);
            this.CancelarButton.TabIndex = 17;
            this.CancelarButton.Text = "     Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "registro.confirmar-48.png");
            this.imageList1.Images.SetKeyName(1, "registro;cancelar-48.png");
            // 
            // ConfirmarButton
            // 
            this.ConfirmarButton.BackColor = System.Drawing.SystemColors.Control;
            this.ConfirmarButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ConfirmarButton.FlatAppearance.BorderSize = 0;
            this.ConfirmarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmarButton.ForeColor = System.Drawing.Color.Black;
            this.ConfirmarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfirmarButton.ImageKey = "registro.confirmar-48.png";
            this.ConfirmarButton.ImageList = this.imageList1;
            this.ConfirmarButton.Location = new System.Drawing.Point(515, 0);
            this.ConfirmarButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ConfirmarButton.Name = "ConfirmarButton";
            this.ConfirmarButton.Size = new System.Drawing.Size(156, 44);
            this.ConfirmarButton.TabIndex = 16;
            this.ConfirmarButton.Text = "     Confirmar";
            this.ConfirmarButton.UseVisualStyleBackColor = false;
            this.ConfirmarButton.Click += new System.EventHandler(this.ConfirmarButton_Click);
            // 
            // barraTituloPanel
            // 
            this.barraTituloPanel.BackColor = System.Drawing.Color.Blue;
            this.barraTituloPanel.Controls.Add(this.button1);
            this.barraTituloPanel.Controls.Add(this.tituloLabel);
            this.barraTituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTituloPanel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barraTituloPanel.Location = new System.Drawing.Point(0, 0);
            this.barraTituloPanel.Name = "barraTituloPanel";
            this.barraTituloPanel.Size = new System.Drawing.Size(671, 32);
            this.barraTituloPanel.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(25)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(637, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 32);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tituloLabel.Location = new System.Drawing.Point(3, 5);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(106, 24);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Banco - ";
            // 
            // BancoManuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 355);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.botoesPanel);
            this.Controls.Add(this.barraTituloPanel);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "BancoManuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BancoManuForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BancoManuForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BancoManuForm_KeyUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.botoesPanel.ResumeLayout(false);
            this.barraTituloPanel.ResumeLayout(false);
            this.barraTituloPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Panel botoesPanel;
        private System.Windows.Forms.Button ConfirmarButton;
        private System.Windows.Forms.Panel barraTituloPanel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomeRTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codfebrabanTextBox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idEmpresaTextBox;
        private System.Windows.Forms.Panel linhaPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
    }
}