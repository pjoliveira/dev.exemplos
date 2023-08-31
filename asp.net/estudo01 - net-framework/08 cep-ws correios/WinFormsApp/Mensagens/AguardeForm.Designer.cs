namespace WinFormsApp
{
    partial class AguardeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AguardeForm));
            this.FechaWindowButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nomeSistemalabel = new System.Windows.Forms.Label();
            this.LoadingPictureBox = new System.Windows.Forms.PictureBox();
            this.mensagemLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaWindowButton
            // 
            this.FechaWindowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FechaWindowButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FechaWindowButton.FlatAppearance.BorderSize = 0;
            this.FechaWindowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.FechaWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechaWindowButton.Image = ((System.Drawing.Image)(resources.GetObject("FechaWindowButton.Image")));
            this.FechaWindowButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FechaWindowButton.Location = new System.Drawing.Point(516, 0);
            this.FechaWindowButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FechaWindowButton.Name = "FechaWindowButton";
            this.FechaWindowButton.Size = new System.Drawing.Size(34, 32);
            this.FechaWindowButton.TabIndex = 14;
            this.FechaWindowButton.UseVisualStyleBackColor = true;
            this.FechaWindowButton.UseWaitCursor = true;
            this.FechaWindowButton.Click += new System.EventHandler(this.FechaWindowButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.nomeSistemalabel);
            this.panel1.Controls.Add(this.FechaWindowButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 32);
            this.panel1.TabIndex = 13;
            this.panel1.UseWaitCursor = true;
            // 
            // nomeSistemalabel
            // 
            this.nomeSistemalabel.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nomeSistemalabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nomeSistemalabel.Location = new System.Drawing.Point(0, 6);
            this.nomeSistemalabel.Name = "nomeSistemalabel";
            this.nomeSistemalabel.Size = new System.Drawing.Size(135, 23);
            this.nomeSistemalabel.TabIndex = 15;
            this.nomeSistemalabel.Text = " AGUARDE...";
            this.nomeSistemalabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nomeSistemalabel.UseWaitCursor = true;
            // 
            // LoadingPictureBox
            // 
            this.LoadingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LoadingPictureBox.Image")));
            this.LoadingPictureBox.Location = new System.Drawing.Point(12, 45);
            this.LoadingPictureBox.Name = "LoadingPictureBox";
            this.LoadingPictureBox.Size = new System.Drawing.Size(100, 89);
            this.LoadingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingPictureBox.TabIndex = 14;
            this.LoadingPictureBox.TabStop = false;
            this.LoadingPictureBox.UseWaitCursor = true;
            // 
            // mensagemLabel
            // 
            this.mensagemLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mensagemLabel.Location = new System.Drawing.Point(118, 45);
            this.mensagemLabel.Name = "mensagemLabel";
            this.mensagemLabel.Size = new System.Drawing.Size(406, 89);
            this.mensagemLabel.TabIndex = 15;
            this.mensagemLabel.Text = "mensagemLabel";
            this.mensagemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mensagemLabel.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 156);
            this.panel2.TabIndex = 16;
            this.panel2.UseWaitCursor = true;
            // 
            // AguardeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 156);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mensagemLabel);
            this.Controls.Add(this.LoadingPictureBox);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AguardeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AguardeForm";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.AguardeForm_Load);
            this.Shown += new System.EventHandler(this.AguardeForm_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FechaWindowButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nomeSistemalabel;
        private System.Windows.Forms.PictureBox LoadingPictureBox;
        private System.Windows.Forms.Label mensagemLabel;
        private System.Windows.Forms.Panel panel2;
    }
}