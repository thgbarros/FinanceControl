namespace Barros.FinanceControl.View
{
    partial class FormContaView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContaView));
            this.tableLayoutPanelContainer = new System.Windows.Forms.TableLayoutPanel();
            this.contaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanelAcoes = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnTransacoes = new System.Windows.Forms.Button();
            this.tableLayoutPanelPesquisa = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCampoSelecionado = new System.Windows.Forms.ComboBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaBindingSource)).BeginInit();
            this.tableLayoutPanelAcoes.SuspendLayout();
            this.tableLayoutPanelBotoes.SuspendLayout();
            this.tableLayoutPanelPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelContainer
            // 
            this.tableLayoutPanelContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelContainer.ColumnCount = 1;
            this.tableLayoutPanelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContainer.Controls.Add(this.contaDataGridView, 0, 0);
            this.tableLayoutPanelContainer.Controls.Add(this.tableLayoutPanelAcoes, 0, 1);
            this.tableLayoutPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelContainer.Name = "tableLayoutPanelContainer";
            this.tableLayoutPanelContainer.RowCount = 2;
            this.tableLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelContainer.Size = new System.Drawing.Size(684, 462);
            this.tableLayoutPanelContainer.TabIndex = 0;
            // 
            // contaDataGridView
            // 
            this.contaDataGridView.AutoGenerateColumns = false;
            this.contaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.descricaoDataGridViewTextBoxColumn,
            this.saldoInicialDataGridViewTextBoxColumn});
            this.contaDataGridView.DataSource = this.contaBindingSource;
            this.contaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contaDataGridView.Location = new System.Drawing.Point(4, 4);
            this.contaDataGridView.MultiSelect = false;
            this.contaDataGridView.Name = "contaDataGridView";
            this.contaDataGridView.ReadOnly = true;
            this.contaDataGridView.RowTemplate.ReadOnly = true;
            this.contaDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.contaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contaDataGridView.Size = new System.Drawing.Size(676, 353);
            this.contaDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.descricaoDataGridViewTextBoxColumn.Width = 350;
            // 
            // saldoInicialDataGridViewTextBoxColumn
            // 
            this.saldoInicialDataGridViewTextBoxColumn.DataPropertyName = "SaldoInicial";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.saldoInicialDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.saldoInicialDataGridViewTextBoxColumn.HeaderText = "Saldo Inicial";
            this.saldoInicialDataGridViewTextBoxColumn.Name = "saldoInicialDataGridViewTextBoxColumn";
            this.saldoInicialDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldoInicialDataGridViewTextBoxColumn.Width = 150;
            // 
            // contaBindingSource
            // 
            this.contaBindingSource.DataSource = typeof(Barros.FinanceControl.Models.Entities.Conta);
            // 
            // tableLayoutPanelAcoes
            // 
            this.tableLayoutPanelAcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelAcoes.ColumnCount = 1;
            this.tableLayoutPanelAcoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAcoes.Controls.Add(this.tableLayoutPanelBotoes, 0, 1);
            this.tableLayoutPanelAcoes.Controls.Add(this.tableLayoutPanelPesquisa, 0, 0);
            this.tableLayoutPanelAcoes.Location = new System.Drawing.Point(4, 364);
            this.tableLayoutPanelAcoes.Name = "tableLayoutPanelAcoes";
            this.tableLayoutPanelAcoes.RowCount = 2;
            this.tableLayoutPanelAcoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelAcoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelAcoes.Size = new System.Drawing.Size(676, 94);
            this.tableLayoutPanelAcoes.TabIndex = 1;
            // 
            // tableLayoutPanelBotoes
            // 
            this.tableLayoutPanelBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelBotoes.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanelBotoes.ColumnCount = 7;
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.62874F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.51497F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBotoes.Controls.Add(this.btnFechar, 6, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btnExcluir, 3, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btnAlterar, 2, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btnIncluir, 1, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btnAjuda, 0, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btnTransacoes, 5, 0);
            this.tableLayoutPanelBotoes.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanelBotoes.Name = "tableLayoutPanelBotoes";
            this.tableLayoutPanelBotoes.RowCount = 1;
            this.tableLayoutPanelBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanelBotoes.Size = new System.Drawing.Size(670, 56);
            this.tableLayoutPanelBotoes.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFechar.Location = new System.Drawing.Point(573, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(92, 46);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Esc - Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(290, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 46);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "F7 - Excluir";
            this.btnExcluir.UseCompatibleTextRendering = true;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(195, 5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAlterar.Size = new System.Drawing.Size(87, 46);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "F6 - Alterar";
            this.btnAlterar.UseCompatibleTextRendering = true;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIncluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(100, 5);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(87, 46);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "F5 - Incluir";
            this.btnIncluir.UseCompatibleTextRendering = true;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAjuda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.Location = new System.Drawing.Point(5, 5);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(87, 46);
            this.btnAjuda.TabIndex = 0;
            this.btnAjuda.Text = "F1 - Ajuda";
            this.btnAjuda.UseCompatibleTextRendering = true;
            this.btnAjuda.UseVisualStyleBackColor = true;
            // 
            // btnTransacoes
            // 
            this.btnTransacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTransacoes.Location = new System.Drawing.Point(456, 5);
            this.btnTransacoes.Name = "btnTransacoes";
            this.btnTransacoes.Size = new System.Drawing.Size(109, 46);
            this.btnTransacoes.TabIndex = 4;
            this.btnTransacoes.Text = "F12 - Transações";
            this.btnTransacoes.UseVisualStyleBackColor = true;
            this.btnTransacoes.Click += new System.EventHandler(this.btnVeiculos_Click);
            // 
            // tableLayoutPanelPesquisa
            // 
            this.tableLayoutPanelPesquisa.ColumnCount = 5;
            this.tableLayoutPanelPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.04004F));
            this.tableLayoutPanelPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.16596F));
            this.tableLayoutPanelPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.04337F));
            this.tableLayoutPanelPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.6338F));
            this.tableLayoutPanelPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.11682F));
            this.tableLayoutPanelPesquisa.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelPesquisa.Controls.Add(this.cbxCampoSelecionado, 1, 0);
            this.tableLayoutPanelPesquisa.Controls.Add(this.txtBusca, 3, 0);
            this.tableLayoutPanelPesquisa.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanelPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPesquisa.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelPesquisa.Name = "tableLayoutPanelPesquisa";
            this.tableLayoutPanelPesquisa.RowCount = 1;
            this.tableLayoutPanelPesquisa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPesquisa.Size = new System.Drawing.Size(670, 26);
            this.tableLayoutPanelPesquisa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Campo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxCampoSelecionado
            // 
            this.cbxCampoSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCampoSelecionado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCampoSelecionado.FormattingEnabled = true;
            this.cbxCampoSelecionado.Location = new System.Drawing.Point(70, 3);
            this.cbxCampoSelecionado.Name = "cbxCampoSelecionado";
            this.cbxCampoSelecionado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxCampoSelecionado.Size = new System.Drawing.Size(122, 24);
            this.cbxCampoSelecionado.TabIndex = 1;
            this.cbxCampoSelecionado.SelectedValueChanged += new System.EventHandler(this.cbxCampoSelecionado_SelectedValueChanged);
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPesquisa.SetColumnSpan(this.txtBusca, 2);
            this.txtBusca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(265, 3);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(402, 22);
            this.txtBusca.TabIndex = 3;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormContaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.tableLayoutPanelContainer);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContaView";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Contas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormClienteView_KeyDown);
            this.tableLayoutPanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaBindingSource)).EndInit();
            this.tableLayoutPanelAcoes.ResumeLayout(false);
            this.tableLayoutPanelBotoes.ResumeLayout(false);
            this.tableLayoutPanelPesquisa.ResumeLayout(false);
            this.tableLayoutPanelPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContainer;
        private System.Windows.Forms.DataGridView contaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAcoes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnTransacoes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCampoSelecionado;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource contaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoInicialDataGridViewTextBoxColumn;

    }
}