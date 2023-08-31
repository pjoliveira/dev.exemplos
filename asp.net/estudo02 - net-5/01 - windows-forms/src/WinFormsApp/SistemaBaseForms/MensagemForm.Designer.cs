namespace SistemaBaseForms
{
    partial class MensagemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensagemForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.imageListButtons = new System.Windows.Forms.ImageList(this.components);
            this.ConfirmarButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FecharWindowButton = new System.Windows.Forms.Button();
            this.imagemAlertaPictureBox = new System.Windows.Forms.PictureBox();
            this.imagemErroPictureBox = new System.Windows.Forms.PictureBox();
            this.imagemPerguntapictureBox = new System.Windows.Forms.PictureBox();
            this.panelMensagem2OBS = new System.Windows.Forms.Panel();
            this.obsTituloLabel = new System.Windows.Forms.Label();
            this.ObsTextoLabel = new System.Windows.Forms.Label();
            this.panelMensagem1 = new System.Windows.Forms.Panel();
            this.perguntaTituloLabel = new System.Windows.Forms.Label();
            this.PerguntaTextoLabel = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemAlertaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemErroPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPerguntapictureBox)).BeginInit();
            this.panelMensagem2OBS.SuspendLayout();
            this.panelMensagem1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.panelMensagem1);
            this.panelContainer.Controls.Add(this.panelMensagem2OBS);
            this.panelContainer.Controls.Add(this.panel2);
            this.panelContainer.Controls.Add(this.panelButtons);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(579, 263);
            this.panelContainer.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.White;
            this.panelButtons.Controls.Add(this.panel3);
            this.panelButtons.Controls.Add(this.CancelarButton);
            this.panelButtons.Controls.Add(this.ConfirmarButton);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Font = new System.Drawing.Font("Consolas", 12F);
            this.panelButtons.ForeColor = System.Drawing.SystemColors.Control;
            this.panelButtons.Location = new System.Drawing.Point(0, 212);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(577, 49);
            this.panelButtons.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 1);
            this.panel3.TabIndex = 19;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelarButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.FlatAppearance.BorderSize = 0;
            this.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.ForeColor = System.Drawing.Color.Black;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.ImageKey = "registro;cancelar-48.png";
            this.CancelarButton.ImageList = this.imageListButtons;
            this.CancelarButton.Location = new System.Drawing.Point(301, 2);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(130, 45);
            this.CancelarButton.TabIndex = 17;
            this.CancelarButton.Text = "     Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // imageListButtons
            // 
            this.imageListButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButtons.ImageStream")));
            this.imageListButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButtons.Images.SetKeyName(0, "registro.confirmar-48.png");
            this.imageListButtons.Images.SetKeyName(1, "registro;cancelar-48.png");
            // 
            // ConfirmarButton
            // 
            this.ConfirmarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmarButton.BackColor = System.Drawing.SystemColors.Control;
            this.ConfirmarButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmarButton.FlatAppearance.BorderSize = 0;
            this.ConfirmarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmarButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ConfirmarButton.ForeColor = System.Drawing.Color.Black;
            this.ConfirmarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfirmarButton.ImageKey = "registro.confirmar-48.png";
            this.ConfirmarButton.ImageList = this.imageListButtons;
            this.ConfirmarButton.Location = new System.Drawing.Point(432, 2);
            this.ConfirmarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConfirmarButton.Name = "ConfirmarButton";
            this.ConfirmarButton.Size = new System.Drawing.Size(144, 45);
            this.ConfirmarButton.TabIndex = 16;
            this.ConfirmarButton.Text = "     Confirmar";
            this.ConfirmarButton.UseVisualStyleBackColor = false;
            this.ConfirmarButton.Click += new System.EventHandler(this.ConfirmarButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.imagemAlertaPictureBox);
            this.panel2.Controls.Add(this.imagemErroPictureBox);
            this.panel2.Controls.Add(this.imagemPerguntapictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 189);
            this.panel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FecharWindowButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 23);
            this.panel1.TabIndex = 20;
            this.panel1.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mensagem";
            this.label1.UseWaitCursor = true;
            // 
            // FecharWindowButton
            // 
            this.FecharWindowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FecharWindowButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FecharWindowButton.FlatAppearance.BorderSize = 0;
            this.FecharWindowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.FecharWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FecharWindowButton.Image = ((System.Drawing.Image)(resources.GetObject("FecharWindowButton.Image")));
            this.FecharWindowButton.Location = new System.Drawing.Point(548, 0);
            this.FecharWindowButton.Name = "FecharWindowButton";
            this.FecharWindowButton.Size = new System.Drawing.Size(29, 23);
            this.FecharWindowButton.TabIndex = 14;
            this.FecharWindowButton.UseVisualStyleBackColor = true;
            this.FecharWindowButton.UseWaitCursor = true;
            // 
            // imagemAlertaPictureBox
            // 
            this.imagemAlertaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagemAlertaPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagemAlertaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imagemAlertaPictureBox.Image")));
            this.imagemAlertaPictureBox.Location = new System.Drawing.Point(57, 0);
            this.imagemAlertaPictureBox.Name = "imagemAlertaPictureBox";
            this.imagemAlertaPictureBox.Size = new System.Drawing.Size(36, 189);
            this.imagemAlertaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemAlertaPictureBox.TabIndex = 19;
            this.imagemAlertaPictureBox.TabStop = false;
            // 
            // imagemErroPictureBox
            // 
            this.imagemErroPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagemErroPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagemErroPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imagemErroPictureBox.Image")));
            this.imagemErroPictureBox.Location = new System.Drawing.Point(30, 0);
            this.imagemErroPictureBox.Name = "imagemErroPictureBox";
            this.imagemErroPictureBox.Size = new System.Drawing.Size(27, 189);
            this.imagemErroPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemErroPictureBox.TabIndex = 20;
            this.imagemErroPictureBox.TabStop = false;
            // 
            // imagemPerguntapictureBox
            // 
            this.imagemPerguntapictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagemPerguntapictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagemPerguntapictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imagemPerguntapictureBox.Image")));
            this.imagemPerguntapictureBox.Location = new System.Drawing.Point(0, 0);
            this.imagemPerguntapictureBox.Name = "imagemPerguntapictureBox";
            this.imagemPerguntapictureBox.Size = new System.Drawing.Size(30, 189);
            this.imagemPerguntapictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemPerguntapictureBox.TabIndex = 21;
            this.imagemPerguntapictureBox.TabStop = false;
            // 
            // panelMensagem2OBS
            // 
            this.panelMensagem2OBS.Controls.Add(this.ObsTextoLabel);
            this.panelMensagem2OBS.Controls.Add(this.obsTituloLabel);
            this.panelMensagem2OBS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMensagem2OBS.Location = new System.Drawing.Point(152, 113);
            this.panelMensagem2OBS.Name = "panelMensagem2OBS";
            this.panelMensagem2OBS.Size = new System.Drawing.Size(425, 99);
            this.panelMensagem2OBS.TabIndex = 21;
            // 
            // obsTituloLabel
            // 
            this.obsTituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.obsTituloLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.obsTituloLabel.ForeColor = System.Drawing.Color.Blue;
            this.obsTituloLabel.Location = new System.Drawing.Point(0, 0);
            this.obsTituloLabel.Name = "obsTituloLabel";
            this.obsTituloLabel.Size = new System.Drawing.Size(425, 17);
            this.obsTituloLabel.TabIndex = 16;
            this.obsTituloLabel.Text = "O B S.";
            this.obsTituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ObsTextoLabel
            // 
            this.ObsTextoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObsTextoLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.ObsTextoLabel.ForeColor = System.Drawing.Color.Black;
            this.ObsTextoLabel.Location = new System.Drawing.Point(0, 17);
            this.ObsTextoLabel.Name = "ObsTextoLabel";
            this.ObsTextoLabel.Size = new System.Drawing.Size(425, 82);
            this.ObsTextoLabel.TabIndex = 17;
            this.ObsTextoLabel.Text = "ObsTextoLabel";
            // 
            // panelMensagem1
            // 
            this.panelMensagem1.Controls.Add(this.PerguntaTextoLabel);
            this.panelMensagem1.Controls.Add(this.perguntaTituloLabel);
            this.panelMensagem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMensagem1.Location = new System.Drawing.Point(152, 23);
            this.panelMensagem1.Name = "panelMensagem1";
            this.panelMensagem1.Size = new System.Drawing.Size(425, 90);
            this.panelMensagem1.TabIndex = 22;
            // 
            // perguntaTituloLabel
            // 
            this.perguntaTituloLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.perguntaTituloLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.perguntaTituloLabel.ForeColor = System.Drawing.Color.Blue;
            this.perguntaTituloLabel.Location = new System.Drawing.Point(0, 0);
            this.perguntaTituloLabel.Name = "perguntaTituloLabel";
            this.perguntaTituloLabel.Size = new System.Drawing.Size(425, 16);
            this.perguntaTituloLabel.TabIndex = 16;
            this.perguntaTituloLabel.Text = "P E R G U N T A";
            this.perguntaTituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PerguntaTextoLabel
            // 
            this.PerguntaTextoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PerguntaTextoLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.PerguntaTextoLabel.ForeColor = System.Drawing.Color.Black;
            this.PerguntaTextoLabel.Location = new System.Drawing.Point(0, 16);
            this.PerguntaTextoLabel.Name = "PerguntaTextoLabel";
            this.PerguntaTextoLabel.Size = new System.Drawing.Size(425, 74);
            this.PerguntaTextoLabel.TabIndex = 17;
            this.PerguntaTextoLabel.Text = "PerguntaTextoLabel";
            // 
            // MensagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 263);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MensagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MensagemForm";
            this.Load += new System.EventHandler(this.MensagemForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemAlertaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemErroPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPerguntapictureBox)).EndInit();
            this.panelMensagem2OBS.ResumeLayout(false);
            this.panelMensagem1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button ConfirmarButton;
        public System.Windows.Forms.ImageList imageListButtons;
        private System.Windows.Forms.Panel panelMensagem1;
        private System.Windows.Forms.Label PerguntaTextoLabel;
        private System.Windows.Forms.Label perguntaTituloLabel;
        private System.Windows.Forms.Panel panelMensagem2OBS;
        private System.Windows.Forms.Label ObsTextoLabel;
        private System.Windows.Forms.Label obsTituloLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imagemAlertaPictureBox;
        private System.Windows.Forms.PictureBox imagemErroPictureBox;
        private System.Windows.Forms.PictureBox imagemPerguntapictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FecharWindowButton;
    }
}