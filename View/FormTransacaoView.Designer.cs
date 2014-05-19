using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Repository.Daos;
using Barros.FinanceControl.Models.Service;
using Barros.FinanceControl.Utils;
using Tecnomotor.InjectorTestPC.Models.Repositories;

namespace Barros.FinanceControl.View
{
    partial class FormTransacaoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransacaoView));
            this.tableLayoutPanelFiltro = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanelContaCategoria = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.checkedListBoxCategoria = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBoxConta = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanelAcoes = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.tableLayoutPanelPesquisa = new System.Windows.Forms.TableLayoutPanel();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCampoSelecionado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelConteudo = new System.Windows.Forms.TableLayoutPanel();
            this.transacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewSaldo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanelFiltro.SuspendLayout();
            this.tableLayoutPanelContaCategoria.SuspendLayout();
            this.tableLayoutPanelAcoes.SuspendLayout();
            this.tableLayoutPanelBotoes.SuspendLayout();
            this.tableLayoutPanelPesquisa.SuspendLayout();
            this.tableLayoutPanelContainer.SuspendLayout();
            this.tableLayoutPanelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transacaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacaoBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelFiltro
            // 
            this.tableLayoutPanelFiltro.ColumnCount = 6;
            this.tableLayoutPanelFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelFiltro.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanelFiltro.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanelFiltro.Controls.Add(this.maskedDataFinal, 4, 0);
            this.tableLayoutPanelFiltro.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanelFiltro.Controls.Add(this.maskedDataInicial, 2, 0);
            this.tableLayoutPanelFiltro.Controls.Add(this.button1, 5, 0);
            this.tableLayoutPanelFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFiltro.Location = new System.Drawing.Point(149, 3);
            this.tableLayoutPanelFiltro.Name = "tableLayoutPanelFiltro";
            this.tableLayoutPanelFiltro.RowCount = 1;
            this.tableLayoutPanelFiltro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanelFiltro.Size = new System.Drawing.Size(532, 31);
            this.tableLayoutPanelFiltro.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Filtro:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data Final:";
            // 
            // maskedDataFinal
            // 
            this.maskedDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedDataFinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedDataFinal.Location = new System.Drawing.Point(355, 4);
            this.maskedDataFinal.Mask = "00/00/0000";
            this.maskedDataFinal.Name = "maskedDataFinal";
            this.maskedDataFinal.Size = new System.Drawing.Size(84, 22);
            this.maskedDataFinal.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data Inicial:";
            // 
            // maskedDataInicial
            // 
            this.maskedDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedDataInicial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedDataInicial.Location = new System.Drawing.Point(175, 4);
            this.maskedDataInicial.Mask = "00/00/0000";
            this.maskedDataInicial.Name = "maskedDataInicial";
            this.maskedDataInicial.Size = new System.Drawing.Size(84, 22);
            this.maskedDataInicial.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(445, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "F9 - Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelContaCategoria
            // 
            this.tableLayoutPanelContaCategoria.ColumnCount = 1;
            this.tableLayoutPanelContaCategoria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContaCategoria.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanelContaCategoria.Controls.Add(this.checkedListBoxCategoria, 0, 3);
            this.tableLayoutPanelContaCategoria.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanelContaCategoria.Controls.Add(this.checkedListBoxConta, 0, 1);
            this.tableLayoutPanelContaCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContaCategoria.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelContaCategoria.Name = "tableLayoutPanelContaCategoria";
            this.tableLayoutPanelContaCategoria.RowCount = 4;
            this.tableLayoutPanelContainer.SetRowSpan(this.tableLayoutPanelContaCategoria, 2);
            this.tableLayoutPanelContaCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelContaCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContaCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelContaCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContaCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelContaCategoria.Size = new System.Drawing.Size(140, 410);
            this.tableLayoutPanelContaCategoria.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Categorias";
            // 
            // checkedListBoxCategoria
            // 
            this.checkedListBoxCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxCategoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxCategoria.FormattingEnabled = true;
            this.checkedListBoxCategoria.HorizontalScrollbar = true;
            this.checkedListBoxCategoria.Location = new System.Drawing.Point(3, 245);
            this.checkedListBoxCategoria.Name = "checkedListBoxCategoria";
            this.checkedListBoxCategoria.ScrollAlwaysVisible = true;
            this.checkedListBoxCategoria.Size = new System.Drawing.Size(134, 162);
            this.checkedListBoxCategoria.TabIndex = 4;
            this.checkedListBoxCategoria.ThreeDCheckBoxes = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contas";
            // 
            // checkedListBoxConta
            // 
            this.checkedListBoxConta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxConta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxConta.FormattingEnabled = true;
            this.checkedListBoxConta.HorizontalScrollbar = true;
            this.checkedListBoxConta.Location = new System.Drawing.Point(3, 40);
            this.checkedListBoxConta.Name = "checkedListBoxConta";
            this.checkedListBoxConta.ScrollAlwaysVisible = true;
            this.checkedListBoxConta.Size = new System.Drawing.Size(134, 162);
            this.checkedListBoxConta.TabIndex = 2;
            this.checkedListBoxConta.ThreeDCheckBoxes = true;
            this.checkedListBoxConta.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxConta_SelectedIndexChanged);
            // 
            // tableLayoutPanelAcoes
            // 
            this.tableLayoutPanelAcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelAcoes.ColumnCount = 1;
            this.tableLayoutPanelContainer.SetColumnSpan(this.tableLayoutPanelAcoes, 2);
            this.tableLayoutPanelAcoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAcoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAcoes.Controls.Add(this.tableLayoutPanelBotoes, 0, 1);
            this.tableLayoutPanelAcoes.Controls.Add(this.tableLayoutPanelPesquisa, 0, 0);
            this.tableLayoutPanelAcoes.Location = new System.Drawing.Point(3, 421);
            this.tableLayoutPanelAcoes.Name = "tableLayoutPanelAcoes";
            this.tableLayoutPanelAcoes.RowCount = 2;
            this.tableLayoutPanelAcoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.55319F));
            this.tableLayoutPanelAcoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.44681F));
            this.tableLayoutPanelAcoes.Size = new System.Drawing.Size(678, 112);
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
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBotoes.Controls.Add(this.btnFechar, 6, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btnExcluir, 3, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btnAlterar, 2, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btnIncluir, 1, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btnAjuda, 0, 0);
            this.tableLayoutPanelBotoes.Location = new System.Drawing.Point(3, 50);
            this.tableLayoutPanelBotoes.Name = "tableLayoutPanelBotoes";
            this.tableLayoutPanelBotoes.RowCount = 1;
            this.tableLayoutPanelBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanelBotoes.Size = new System.Drawing.Size(672, 59);
            this.tableLayoutPanelBotoes.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFechar.Location = new System.Drawing.Point(575, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(92, 49);
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
            this.btnExcluir.Size = new System.Drawing.Size(87, 49);
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
            this.btnAlterar.Size = new System.Drawing.Size(87, 49);
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
            this.btnIncluir.Size = new System.Drawing.Size(87, 49);
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
            this.btnAjuda.Size = new System.Drawing.Size(87, 49);
            this.btnAjuda.TabIndex = 0;
            this.btnAjuda.Text = "F1 - Ajuda";
            this.btnAjuda.UseCompatibleTextRendering = true;
            this.btnAjuda.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelPesquisa
            // 
            this.tableLayoutPanelPesquisa.ColumnCount = 7;
            this.tableLayoutPanelPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.291667F));
            this.tableLayoutPanelPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.226191F));
            this.tableLayoutPanelPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.166667F));
            this.tableLayoutPanelPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.779762F));
            this.tableLayoutPanelPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.81548F));
            this.tableLayoutPanelPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.226191F));
            this.tableLayoutPanelPesquisa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.34524F));
            this.tableLayoutPanelPesquisa.Controls.Add(this.txtBusca, 6, 0);
            this.tableLayoutPanelPesquisa.Controls.Add(this.label2, 5, 0);
            this.tableLayoutPanelPesquisa.Controls.Add(this.cbxCampoSelecionado, 4, 0);
            this.tableLayoutPanelPesquisa.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanelPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPesquisa.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelPesquisa.Name = "tableLayoutPanelPesquisa";
            this.tableLayoutPanelPesquisa.RowCount = 1;
            this.tableLayoutPanelPesquisa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPesquisa.Size = new System.Drawing.Size(672, 41);
            this.tableLayoutPanelPesquisa.TabIndex = 1;
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(376, 9);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(293, 22);
            this.txtBusca.TabIndex = 3;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxCampoSelecionado
            // 
            this.cbxCampoSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCampoSelecionado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCampoSelecionado.FormattingEnabled = true;
            this.cbxCampoSelecionado.Location = new System.Drawing.Point(201, 8);
            this.cbxCampoSelecionado.Name = "cbxCampoSelecionado";
            this.cbxCampoSelecionado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxCampoSelecionado.Size = new System.Drawing.Size(107, 24);
            this.cbxCampoSelecionado.TabIndex = 1;
            this.cbxCampoSelecionado.SelectedValueChanged += new System.EventHandler(this.cbxCampoSelecionado_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Campo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanelContainer
            // 
            this.tableLayoutPanelContainer.ColumnCount = 2;
            this.tableLayoutPanelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.37628F));
            this.tableLayoutPanelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.62372F));
            this.tableLayoutPanelContainer.Controls.Add(this.tableLayoutPanelAcoes, 0, 2);
            this.tableLayoutPanelContainer.Controls.Add(this.tableLayoutPanelContaCategoria, 0, 0);
            this.tableLayoutPanelContainer.Controls.Add(this.tableLayoutPanelFiltro, 1, 0);
            this.tableLayoutPanelContainer.Controls.Add(this.tableLayoutPanelConteudo, 1, 1);
            this.tableLayoutPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelContainer.Name = "tableLayoutPanelContainer";
            this.tableLayoutPanelContainer.RowCount = 3;
            this.tableLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelContainer.Size = new System.Drawing.Size(684, 536);
            this.tableLayoutPanelContainer.TabIndex = 0;
            // 
            // tableLayoutPanelConteudo
            // 
            this.tableLayoutPanelConteudo.ColumnCount = 1;
            this.tableLayoutPanelConteudo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelConteudo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelConteudo.Controls.Add(this.transacaoDataGridView, 0, 0);
            this.tableLayoutPanelConteudo.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelConteudo.Location = new System.Drawing.Point(149, 40);
            this.tableLayoutPanelConteudo.Name = "tableLayoutPanelConteudo";
            this.tableLayoutPanelConteudo.RowCount = 2;
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.64075F));
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.35925F));
            this.tableLayoutPanelConteudo.Size = new System.Drawing.Size(532, 373);
            this.tableLayoutPanelConteudo.TabIndex = 4;
            // 
            // transacaoDataGridView
            // 
            this.transacaoDataGridView.AutoGenerateColumns = false;
            this.transacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.contaDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.transacaoDataGridView.DataSource = this.transacaoBindingSource;
            this.transacaoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transacaoDataGridView.Location = new System.Drawing.Point(3, 3);
            this.transacaoDataGridView.Name = "transacaoDataGridView";
            this.transacaoDataGridView.Size = new System.Drawing.Size(526, 209);
            this.transacaoDataGridView.TabIndex = 0;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataGridViewCellStyle1.Format = "d";
            this.dataDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.Width = 250;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // contaDataGridViewTextBoxColumn
            // 
            this.contaDataGridViewTextBoxColumn.DataPropertyName = "Conta";
            this.contaDataGridViewTextBoxColumn.HeaderText = "Conta";
            this.contaDataGridViewTextBoxColumn.Name = "contaDataGridViewTextBoxColumn";
            this.contaDataGridViewTextBoxColumn.Width = 150;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            this.valorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.Width = 150;
            // 
            // transacaoBindingSource
            // 
            this.transacaoBindingSource.DataSource = typeof(Barros.FinanceControl.Models.Entities.Transacao);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.45627F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.54373F));
            this.tableLayoutPanel1.Controls.Add(this.lblSaldoTotal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewSaldo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 218);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 152);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridViewSaldo
            // 
            this.dataGridViewSaldo.AutoGenerateColumns = false;
            this.dataGridViewSaldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaldo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewSaldo, 2);
            this.dataGridViewSaldo.DataSource = this.transacaoBindingSource;
            this.dataGridViewSaldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSaldo.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSaldo.Name = "dataGridViewSaldo";
            this.dataGridViewSaldo.Size = new System.Drawing.Size(520, 95);
            this.dataGridViewSaldo.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle3.Format = "d";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Conta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Saldo Atual";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(311, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Saldo Total:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoTotal.ForeColor = System.Drawing.Color.Black;
            this.lblSaldoTotal.Location = new System.Drawing.Point(320, 109);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(203, 34);
            this.lblSaldoTotal.TabIndex = 3;
            this.lblSaldoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTransacaoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 536);
            this.Controls.Add(this.tableLayoutPanelContainer);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTransacaoView";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transações Cadastradas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTransacaoView_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormClienteView_KeyDown);
            this.tableLayoutPanelFiltro.ResumeLayout(false);
            this.tableLayoutPanelFiltro.PerformLayout();
            this.tableLayoutPanelContaCategoria.ResumeLayout(false);
            this.tableLayoutPanelContaCategoria.PerformLayout();
            this.tableLayoutPanelAcoes.ResumeLayout(false);
            this.tableLayoutPanelBotoes.ResumeLayout(false);
            this.tableLayoutPanelPesquisa.ResumeLayout(false);
            this.tableLayoutPanelPesquisa.PerformLayout();
            this.tableLayoutPanelContainer.ResumeLayout(false);
            this.tableLayoutPanelConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transacaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacaoBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaldo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.BindingSource transacaoBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFiltro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedDataFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedDataInicial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContaCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox checkedListBoxCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBoxConta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAcoes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPesquisa;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCampoSelecionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelConteudo;
        private System.Windows.Forms.DataGridView transacaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label label8;

    }
}