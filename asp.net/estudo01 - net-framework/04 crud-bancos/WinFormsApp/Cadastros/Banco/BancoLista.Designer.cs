namespace WinFormsApp
{
    partial class BancoLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BancoLista));
            this.barraTituloPanel = new System.Windows.Forms.Panel();
            this.descFormLabel = new System.Windows.Forms.Label();
            this.BotoesPanel = new System.Windows.Forms.Panel();
            this.BotoesToolStrip = new System.Windows.Forms.ToolStrip();
            this.VoltarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.OpcoesToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ConfigurarGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FiltrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportarTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportarXlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.RelatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NovoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AlterarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ExcluirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linhaPanel = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FiltrarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.campoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barraTituloPanel.SuspendLayout();
            this.BotoesPanel.SuspendLayout();
            this.BotoesToolStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTituloPanel
            // 
            this.barraTituloPanel.BackColor = System.Drawing.Color.Blue;
            this.barraTituloPanel.Controls.Add(this.descFormLabel);
            this.barraTituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTituloPanel.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.barraTituloPanel.Location = new System.Drawing.Point(0, 0);
            this.barraTituloPanel.Name = "barraTituloPanel";
            this.barraTituloPanel.Size = new System.Drawing.Size(865, 37);
            this.barraTituloPanel.TabIndex = 10;
            // 
            // descFormLabel
            // 
            this.descFormLabel.AutoSize = true;
            this.descFormLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Italic);
            this.descFormLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.descFormLabel.Location = new System.Drawing.Point(3, 4);
            this.descFormLabel.Name = "descFormLabel";
            this.descFormLabel.Size = new System.Drawing.Size(207, 28);
            this.descFormLabel.TabIndex = 0;
            this.descFormLabel.Text = "Cadastros/Banco";
            // 
            // BotoesPanel
            // 
            this.BotoesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.BotoesPanel.Controls.Add(this.BotoesToolStrip);
            this.BotoesPanel.Controls.Add(this.panel4);
            this.BotoesPanel.Controls.Add(this.panel1);
            this.BotoesPanel.Controls.Add(this.linhaPanel);
            this.BotoesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotoesPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.BotoesPanel.Location = new System.Drawing.Point(0, 401);
            this.BotoesPanel.Name = "BotoesPanel";
            this.BotoesPanel.Size = new System.Drawing.Size(865, 44);
            this.BotoesPanel.TabIndex = 11;
            // 
            // BotoesToolStrip
            // 
            this.BotoesToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotoesToolStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.BotoesToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.BotoesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VoltarToolStripButton,
            this.toolStripSeparator3,
            this.OpcoesToolStripDropDownButton1,
            this.NovoToolStripButton,
            this.AlterarToolStripButton,
            this.ExcluirToolStripButton});
            this.BotoesToolStrip.Location = new System.Drawing.Point(0, 5);
            this.BotoesToolStrip.Name = "BotoesToolStrip";
            this.BotoesToolStrip.Size = new System.Drawing.Size(865, 39);
            this.BotoesToolStrip.TabIndex = 25;
            this.BotoesToolStrip.Text = "toolStrip1";
            // 
            // VoltarToolStripButton
            // 
            this.VoltarToolStripButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.VoltarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("VoltarToolStripButton.Image")));
            this.VoltarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VoltarToolStripButton.Name = "VoltarToolStripButton";
            this.VoltarToolStripButton.Size = new System.Drawing.Size(84, 36);
            this.VoltarToolStripButton.Text = "Voltar";
            this.VoltarToolStripButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.VoltarToolStripButton.ToolTipText = "Voltar";
            this.VoltarToolStripButton.Click += new System.EventHandler(this.VoltarToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // OpcoesToolStripDropDownButton1
            // 
            this.OpcoesToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigurarGridToolStripMenuItem,
            this.toolStripSeparator1,
            this.FiltrosToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExportarTxtToolStripMenuItem,
            this.ExportarXlsToolStripMenuItem,
            this.toolStripSeparator4,
            this.RelatoriosToolStripMenuItem});
            this.OpcoesToolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("OpcoesToolStripDropDownButton1.Image")));
            this.OpcoesToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpcoesToolStripDropDownButton1.Name = "OpcoesToolStripDropDownButton1";
            this.OpcoesToolStripDropDownButton1.Size = new System.Drawing.Size(104, 36);
            this.OpcoesToolStripDropDownButton1.Text = "Opções";
            // 
            // ConfigurarGridToolStripMenuItem
            // 
            this.ConfigurarGridToolStripMenuItem.Name = "ConfigurarGridToolStripMenuItem";
            this.ConfigurarGridToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.ConfigurarGridToolStripMenuItem.Text = "Configurar Grid";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // FiltrosToolStripMenuItem
            // 
            this.FiltrosToolStripMenuItem.Name = "FiltrosToolStripMenuItem";
            this.FiltrosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.FiltrosToolStripMenuItem.Text = "Filtros";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // ExportarTxtToolStripMenuItem
            // 
            this.ExportarTxtToolStripMenuItem.Name = "ExportarTxtToolStripMenuItem";
            this.ExportarTxtToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.ExportarTxtToolStripMenuItem.Text = "Exportar TXT";
            // 
            // ExportarXlsToolStripMenuItem
            // 
            this.ExportarXlsToolStripMenuItem.Name = "ExportarXlsToolStripMenuItem";
            this.ExportarXlsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.ExportarXlsToolStripMenuItem.Text = "Exportar XLS";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // RelatoriosToolStripMenuItem
            // 
            this.RelatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.RelatoriosToolStripMenuItem.Name = "RelatoriosToolStripMenuItem";
            this.RelatoriosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.RelatoriosToolStripMenuItem.Text = "Relatórios";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 24);
            this.toolStripMenuItem1.Text = "ListaBancos";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // NovoToolStripButton
            // 
            this.NovoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NovoToolStripButton.Image")));
            this.NovoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NovoToolStripButton.Name = "NovoToolStripButton";
            this.NovoToolStripButton.Size = new System.Drawing.Size(81, 36);
            this.NovoToolStripButton.Text = "Novo";
            this.NovoToolStripButton.Click += new System.EventHandler(this.NovoToolStripButton_Click);
            // 
            // AlterarToolStripButton
            // 
            this.AlterarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AlterarToolStripButton.Image")));
            this.AlterarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlterarToolStripButton.Name = "AlterarToolStripButton";
            this.AlterarToolStripButton.Size = new System.Drawing.Size(90, 36);
            this.AlterarToolStripButton.Text = "Alterar";
            this.AlterarToolStripButton.Click += new System.EventHandler(this.AlterarToolStripButton_Click);
            // 
            // ExcluirToolStripButton
            // 
            this.ExcluirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ExcluirToolStripButton.Image")));
            this.ExcluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcluirToolStripButton.Name = "ExcluirToolStripButton";
            this.ExcluirToolStripButton.Size = new System.Drawing.Size(88, 36);
            this.ExcluirToolStripButton.Text = "Excluir";
            this.ExcluirToolStripButton.Click += new System.EventHandler(this.ExcluirToolStripButton_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(865, 1);
            this.panel4.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 1);
            this.panel1.TabIndex = 23;
            // 
            // linhaPanel
            // 
            this.linhaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linhaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.linhaPanel.Location = new System.Drawing.Point(0, 0);
            this.linhaPanel.Name = "linhaPanel";
            this.linhaPanel.Size = new System.Drawing.Size(865, 0);
            this.linhaPanel.TabIndex = 19;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "registro.adicionar-48.png");
            this.imageList1.Images.SetKeyName(1, "registro.editar-48.png");
            this.imageList1.Images.SetKeyName(2, "registro.excluir-48.png");
            this.imageList1.Images.SetKeyName(3, "form.voltar-48.png");
            this.imageList1.Images.SetKeyName(4, "form.configuracoes-48.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.FiltrarButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.campoComboBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BuscarTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 53);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 1);
            this.panel3.TabIndex = 5;
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.Location = new System.Drawing.Point(722, 21);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(82, 29);
            this.FiltrarButton.TabIndex = 4;
            this.FiltrarButton.Text = "filtrar";
            this.FiltrarButton.UseVisualStyleBackColor = true;
            this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar por";
            // 
            // campoComboBox
            // 
            this.campoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoComboBox.FormattingEnabled = true;
            this.campoComboBox.Location = new System.Drawing.Point(8, 21);
            this.campoComboBox.Name = "campoComboBox";
            this.campoComboBox.Size = new System.Drawing.Size(198, 29);
            this.campoComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite";
            // 
            // BuscarTextBox
            // 
            this.BuscarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuscarTextBox.Location = new System.Drawing.Point(212, 21);
            this.BuscarTextBox.Name = "BuscarTextBox";
            this.BuscarTextBox.Size = new System.Drawing.Size(504, 29);
            this.BuscarTextBox.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.fantasiaDataGridViewTextBoxColumn,
            this.empresaidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bancoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(865, 311);
            this.dataGridView1.TabIndex = 13;
            // 
            // bancoBindingSource
            // 
            this.bancoBindingSource.DataSource = typeof(WinFormsApp.Banco);
            this.bancoBindingSource.CurrentChanged += new System.EventHandler(this.bancoBindingSource_CurrentChanged);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // BancoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 445);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BotoesPanel);
            this.Controls.Add(this.barraTituloPanel);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BancoLista";
            this.Text = "BancoForm";
            this.Load += new System.EventHandler(this.BancoGridForm_Load);
            this.Shown += new System.EventHandler(this.BancoGridForm_Shown);
            this.barraTituloPanel.ResumeLayout(false);
            this.barraTituloPanel.PerformLayout();
            this.BotoesPanel.ResumeLayout(false);
            this.BotoesPanel.PerformLayout();
            this.BotoesToolStrip.ResumeLayout(false);
            this.BotoesToolStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTituloPanel;
        private System.Windows.Forms.Label descFormLabel;
        private System.Windows.Forms.Panel BotoesPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FiltrarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox campoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BuscarTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel linhaPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStrip BotoesToolStrip;
        private System.Windows.Forms.ToolStripButton VoltarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton OpcoesToolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton ExcluirToolStripButton;
        private System.Windows.Forms.ToolStripButton AlterarToolStripButton;
        private System.Windows.Forms.ToolStripButton NovoToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem ConfigurarGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem FiltrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExportarTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportarXlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem RelatoriosToolStripMenuItem;
        private System.Windows.Forms.BindingSource bancoBindingSource;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaidDataGridViewTextBoxColumn;
    }
}