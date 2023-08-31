namespace WinFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensagemForm));
            this.label1 = new System.Windows.Forms.Label();
            this.FecharWindowButton = new System.Windows.Forms.Button();
            this.perguntaTituloLabel = new System.Windows.Forms.Label();
            this.PerguntaTextoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.obsTituloLabel = new System.Windows.Forms.Label();
            this.ObsTextoLabel = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.imagemAlertaPictureBox = new System.Windows.Forms.PictureBox();
            this.imagemErroPictureBox = new System.Windows.Forms.PictureBox();
            this.imagemPerguntapictureBox = new System.Windows.Forms.PictureBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.ConfirmarButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemAlertaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemErroPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPerguntapictureBox)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "E-MANAGER";
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
            this.FecharWindowButton.Location = new System.Drawing.Point(492, 0);
            this.FecharWindowButton.Name = "FecharWindowButton";
            this.FecharWindowButton.Size = new System.Drawing.Size(29, 23);
            this.FecharWindowButton.TabIndex = 14;
            this.FecharWindowButton.UseVisualStyleBackColor = true;
            this.FecharWindowButton.UseWaitCursor = true;
            this.FecharWindowButton.Click += new System.EventHandler(this.FecharWindowButton_Click);
            // 
            // perguntaTituloLabel
            // 
            this.perguntaTituloLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.perguntaTituloLabel.ForeColor = System.Drawing.Color.Blue;
            this.perguntaTituloLabel.Location = new System.Drawing.Point(138, 27);
            this.perguntaTituloLabel.Name = "perguntaTituloLabel";
            this.perguntaTituloLabel.Size = new System.Drawing.Size(348, 16);
            this.perguntaTituloLabel.TabIndex = 0;
            this.perguntaTituloLabel.Text = "P E R G U N T A";
            this.perguntaTituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.perguntaTituloLabel.UseWaitCursor = true;
            // 
            // PerguntaTextoLabel
            // 
            this.PerguntaTextoLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.PerguntaTextoLabel.ForeColor = System.Drawing.Color.Black;
            this.PerguntaTextoLabel.Location = new System.Drawing.Point(138, 43);
            this.PerguntaTextoLabel.Name = "PerguntaTextoLabel";
            this.PerguntaTextoLabel.Size = new System.Drawing.Size(348, 36);
            this.PerguntaTextoLabel.TabIndex = 15;
            this.PerguntaTextoLabel.Text = "PerguntaTextoLabel";
            this.PerguntaTextoLabel.UseWaitCursor = true;
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
            this.panel1.Size = new System.Drawing.Size(521, 23);
            this.panel1.TabIndex = 13;
            this.panel1.UseWaitCursor = true;
            // 
            // obsTituloLabel
            // 
            this.obsTituloLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.obsTituloLabel.ForeColor = System.Drawing.Color.Blue;
            this.obsTituloLabel.Location = new System.Drawing.Point(138, 89);
            this.obsTituloLabel.Name = "obsTituloLabel";
            this.obsTituloLabel.Size = new System.Drawing.Size(348, 17);
            this.obsTituloLabel.TabIndex = 0;
            this.obsTituloLabel.Text = "O B S.";
            this.obsTituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.obsTituloLabel.UseWaitCursor = true;
            // 
            // ObsTextoLabel
            // 
            this.ObsTextoLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.ObsTextoLabel.ForeColor = System.Drawing.Color.Black;
            this.ObsTextoLabel.Location = new System.Drawing.Point(138, 107);
            this.ObsTextoLabel.Name = "ObsTextoLabel";
            this.ObsTextoLabel.Size = new System.Drawing.Size(348, 47);
            this.ObsTextoLabel.TabIndex = 15;
            this.ObsTextoLabel.Text = "ObsTextoLabel";
            this.ObsTextoLabel.UseWaitCursor = true;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.obsTituloLabel);
            this.panelContainer.Controls.Add(this.ObsTextoLabel);
            this.panelContainer.Controls.Add(this.imagemAlertaPictureBox);
            this.panelContainer.Controls.Add(this.imagemErroPictureBox);
            this.panelContainer.Controls.Add(this.imagemPerguntapictureBox);
            this.panelContainer.Controls.Add(this.perguntaTituloLabel);
            this.panelContainer.Controls.Add(this.PerguntaTextoLabel);
            this.panelContainer.Controls.Add(this.panelButtons);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(521, 220);
            this.panelContainer.TabIndex = 0;
            // 
            // imagemAlertaPictureBox
            // 
            this.imagemAlertaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagemAlertaPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagemAlertaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imagemAlertaPictureBox.Image")));
            this.imagemAlertaPictureBox.Location = new System.Drawing.Point(52, 0);
            this.imagemAlertaPictureBox.Name = "imagemAlertaPictureBox";
            this.imagemAlertaPictureBox.Size = new System.Drawing.Size(36, 169);
            this.imagemAlertaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemAlertaPictureBox.TabIndex = 14;
            this.imagemAlertaPictureBox.TabStop = false;
            this.imagemAlertaPictureBox.UseWaitCursor = true;
            // 
            // imagemErroPictureBox
            // 
            this.imagemErroPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagemErroPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imagemErroPictureBox.Image")));
            this.imagemErroPictureBox.Location = new System.Drawing.Point(30, 0);
            this.imagemErroPictureBox.Name = "imagemErroPictureBox";
            this.imagemErroPictureBox.Size = new System.Drawing.Size(22, 169);
            this.imagemErroPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemErroPictureBox.TabIndex = 14;
            this.imagemErroPictureBox.TabStop = false;
            this.imagemErroPictureBox.UseWaitCursor = true;
            // 
            // imagemPerguntapictureBox
            // 
            this.imagemPerguntapictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagemPerguntapictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imagemPerguntapictureBox.Image")));
            this.imagemPerguntapictureBox.Location = new System.Drawing.Point(0, 0);
            this.imagemPerguntapictureBox.Name = "imagemPerguntapictureBox";
            this.imagemPerguntapictureBox.Size = new System.Drawing.Size(30, 169);
            this.imagemPerguntapictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemPerguntapictureBox.TabIndex = 14;
            this.imagemPerguntapictureBox.TabStop = false;
            this.imagemPerguntapictureBox.UseWaitCursor = true;
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
            this.panelButtons.Location = new System.Drawing.Point(0, 169);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(519, 49);
            this.panelButtons.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 1);
            this.panel3.TabIndex = 19;
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelarButton.FlatAppearance.BorderSize = 0;
            this.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarButton.ForeColor = System.Drawing.Color.Black;
            this.CancelarButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelarButton.Image")));
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.ImageKey = "(none)";
            this.CancelarButton.Location = new System.Drawing.Point(241, 0);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(134, 49);
            this.CancelarButton.TabIndex = 17;
            this.CancelarButton.Text = "     Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // ConfirmarButton
            // 
            this.ConfirmarButton.BackColor = System.Drawing.SystemColors.Control;
            this.ConfirmarButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmarButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ConfirmarButton.FlatAppearance.BorderSize = 0;
            this.ConfirmarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmarButton.ForeColor = System.Drawing.Color.Black;
            this.ConfirmarButton.Image = ((System.Drawing.Image)(resources.GetObject("ConfirmarButton.Image")));
            this.ConfirmarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfirmarButton.ImageKey = "(none)";
            this.ConfirmarButton.Location = new System.Drawing.Point(375, 0);
            this.ConfirmarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConfirmarButton.Name = "ConfirmarButton";
            this.ConfirmarButton.Size = new System.Drawing.Size(144, 49);
            this.ConfirmarButton.TabIndex = 16;
            this.ConfirmarButton.Text = "     Confirmar";
            this.ConfirmarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfirmarButton.UseVisualStyleBackColor = false;
            this.ConfirmarButton.Click += new System.EventHandler(this.ConfirmarButton_Click);
            // 
            // MensagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 220);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MensagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MensagemForm";
            this.Load += new System.EventHandler(this.MensagemForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagemAlertaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemErroPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPerguntapictureBox)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FecharWindowButton;
        private System.Windows.Forms.Label perguntaTituloLabel;
        private System.Windows.Forms.Label PerguntaTextoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label obsTituloLabel;
        private System.Windows.Forms.Label ObsTextoLabel;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button ConfirmarButton;
        private System.Windows.Forms.PictureBox imagemAlertaPictureBox;
        private System.Windows.Forms.PictureBox imagemErroPictureBox;
        private System.Windows.Forms.PictureBox imagemPerguntapictureBox;
    }
}