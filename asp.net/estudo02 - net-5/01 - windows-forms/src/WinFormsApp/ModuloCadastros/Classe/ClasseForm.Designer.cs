
namespace ModuloCadastros
{
    partial class ClasseForm
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
            this.TextBoxDescricao = new System.Windows.Forms.TextBox();
            this.TextBoxID = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxEmpresaID = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(599, 340);
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Controls.Add(this.label3);
            this.panelDataGrid.Controls.Add(this.label2);
            this.panelDataGrid.Controls.Add(this.label1);
            this.panelDataGrid.Controls.Add(this.TextBoxEmpresaID);
            this.panelDataGrid.Controls.Add(this.TextBoxID);
            this.panelDataGrid.Controls.Add(this.TextBoxDescricao);
            this.panelDataGrid.Size = new System.Drawing.Size(597, 260);
            // 
            // panelButtons
            // 
            this.panelButtons.Location = new System.Drawing.Point(0, 293);
            this.panelButtons.Size = new System.Drawing.Size(597, 45);
            // 
            // panelTitulo
            // 
            this.panelTitulo.Size = new System.Drawing.Size(597, 33);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(297, 0);
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // ConfirmarButton
            // 
            this.ConfirmarButton.Location = new System.Drawing.Point(447, 0);
            this.ConfirmarButton.Click += new System.EventHandler(this.ConfirmarButton_Click);
            // 
            // TextBoxDescricao
            // 
            this.TextBoxDescricao.Location = new System.Drawing.Point(11, 103);
            this.TextBoxDescricao.Name = "TextBoxDescricao";
            this.TextBoxDescricao.Size = new System.Drawing.Size(396, 30);
            this.TextBoxDescricao.TabIndex = 1;
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(11, 37);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(100, 30);
            this.TextBoxID.TabIndex = 2;
            // 
            // TextBoxEmpresaID
            // 
            this.TextBoxEmpresaID.Location = new System.Drawing.Point(428, 103);
            this.TextBoxEmpresaID.Name = "TextBoxEmpresaID";
            this.TextBoxEmpresaID.Size = new System.Drawing.Size(100, 30);
            this.TextBoxEmpresaID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(420, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 6;
            this.label3.Tag = " ";
            this.label3.Text = "Empresa";
            // 
            // ClasseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 340);
            this.Name = "ClasseForm";
            this.Text = "ClasseForm";
            this.panel1.ResumeLayout(false);
            this.panelDataGrid.ResumeLayout(false);
            this.panelDataGrid.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TextBoxEmpresaID;
        private System.Windows.Forms.MaskedTextBox TextBoxID;
        private System.Windows.Forms.TextBox TextBoxDescricao;
    }
}