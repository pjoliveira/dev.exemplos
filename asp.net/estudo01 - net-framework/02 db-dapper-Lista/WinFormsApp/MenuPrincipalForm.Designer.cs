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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonListarBancos = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewBancos = new System.Windows.Forms.DataGridView();
            this.textBoxQuantRegistros = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSair,
            this.toolStripButtonListarBancos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(765, 28);
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
            this.toolStripButtonSair.Click += new System.EventHandler(this.toolStripButtonSair_Click);
            // 
            // toolStripButtonListarBancos
            // 
            this.toolStripButtonListarBancos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonListarBancos.Image")));
            this.toolStripButtonListarBancos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonListarBancos.Name = "toolStripButtonListarBancos";
            this.toolStripButtonListarBancos.Size = new System.Drawing.Size(208, 25);
            this.toolStripButtonListarBancos.Text = "Listar Cadastro de Bancos";
            this.toolStripButtonListarBancos.ToolTipText = "Listar o cadastro de Bancos";
            this.toolStripButtonListarBancos.Click += new System.EventHandler(this.toolStripButtonConectarDesconectar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxQuantRegistros);
            this.panel1.Controls.Add(this.dataGridViewBancos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 284);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewBancos
            // 
            this.dataGridViewBancos.AllowUserToAddRows = false;
            this.dataGridViewBancos.AllowUserToDeleteRows = false;
            this.dataGridViewBancos.AutoGenerateColumns = false;
            this.dataGridViewBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBancos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.fantasiaDataGridViewTextBoxColumn,
            this.empresaidDataGridViewTextBoxColumn});
            this.dataGridViewBancos.DataSource = this.bancoBindingSource;
            this.dataGridViewBancos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBancos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBancos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewBancos.Name = "dataGridViewBancos";
            this.dataGridViewBancos.ReadOnly = true;
            this.dataGridViewBancos.Size = new System.Drawing.Size(765, 284);
            this.dataGridViewBancos.TabIndex = 0;
            // 
            // textBoxQuantRegistros
            // 
            this.textBoxQuantRegistros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxQuantRegistros.Location = new System.Drawing.Point(0, 258);
            this.textBoxQuantRegistros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxQuantRegistros.Name = "textBoxQuantRegistros";
            this.textBoxQuantRegistros.Size = new System.Drawing.Size(765, 26);
            this.textBoxQuantRegistros.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 38);
            this.panel3.TabIndex = 2;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Frozen = true;
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fantasiaDataGridViewTextBoxColumn
            // 
            this.fantasiaDataGridViewTextBoxColumn.DataPropertyName = "Fantasia";
            this.fantasiaDataGridViewTextBoxColumn.HeaderText = "Fantasia";
            this.fantasiaDataGridViewTextBoxColumn.Name = "fantasiaDataGridViewTextBoxColumn";
            this.fantasiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresaidDataGridViewTextBoxColumn
            // 
            this.empresaidDataGridViewTextBoxColumn.DataPropertyName = "Empresa_id";
            this.empresaidDataGridViewTextBoxColumn.HeaderText = "Empresa_id";
            this.empresaidDataGridViewTextBoxColumn.Name = "empresaidDataGridViewTextBoxColumn";
            this.empresaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bancoBindingSource
            // 
            this.bancoBindingSource.DataSource = typeof(WinFormsApp.Banco);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuPrincipalForm";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSair;
        private System.Windows.Forms.ToolStripButton toolStripButtonListarBancos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewBancos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxQuantRegistros;
        private System.Windows.Forms.BindingSource bancoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaidDataGridViewTextBoxColumn;
    }
}

