namespace Barros.FinanceControl.View
{
    partial class FormUsuarioView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarioView));
            this.tableLayoutPanelContainer = new System.Windows.Forms.TableLayoutPanel();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBloqueioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanelAcoes = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.btnBloquear = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.tableLayoutPanelPesquisa = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCampoSelecionado = new System.Windows.Forms.ComboBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
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
            this.tableLayoutPanelContainer.Controls.Add(this.usuarioDataGridView, 0, 0);
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
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataBloqueioDataGridViewTextBoxColumn});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuarioDataGridView.Location = new System.Drawing.Point(4, 4);
            this.usuarioDataGridView.MultiSelect = false;
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuarioDataGridView.Size = new System.Drawing.Size(676, 353);
            this.usuarioDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Login";
            this.dataGridViewTextBoxColumn2.HeaderText = "Login";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 350;
            // 
            // dataBloqueioDataGridViewTextBoxColumn
            // 
            this.dataBloqueioDataGridViewTextBoxColumn.DataPropertyName = "DataBloqueio";
            this.dataBloqueioDataGridViewTextBoxColumn.HeaderText = "DataBloqueio";
            this.dataBloqueioDataGridViewTextBoxColumn.Name = "dataBloqueioDataGridViewTextBoxColumn";
            this.dataBloqueioDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataBloqueioDataGridViewTextBoxColumn.Width = 180;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Barros.FinanceControl.Models.Entities.Usuario);
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
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBotoes.Controls.Add(this.btnFechar, 6, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btnDesbloquear, 3, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btnBloquear, 2, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btnIncluir, 1, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btnAjuda, 0, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btn, 5, 0);
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
            this.btnFechar.Location = new System.Drawing.Point(575, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(90, 46);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Esc - Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDesbloquear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesbloquear.Location = new System.Drawing.Point(290, 5);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(87, 46);
            this.btnDesbloquear.TabIndex = 3;
            this.btnDesbloquear.Text = "F7 - Desbloq.";
            this.btnDesbloquear.UseCompatibleTextRendering = true;
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // btnBloquear
            // 
            this.btnBloquear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBloquear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloquear.Location = new System.Drawing.Point(195, 5);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBloquear.Size = new System.Drawing.Size(87, 46);
            this.btnBloquear.TabIndex = 2;
            this.btnBloquear.Text = "F6 - Bloquear";
            this.btnBloquear.UseCompatibleTextRendering = true;
            this.btnBloquear.UseVisualStyleBackColor = true;
            this.btnBloquear.Click += new System.EventHandler(this.btnBloquear_Click);
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
            // btn
            // 
            this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn.Location = new System.Drawing.Point(480, 5);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(87, 46);
            this.btn.TabIndex = 4;
            this.btn.Text = "F12 - ";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Visible = false;
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
            this.cbxCampoSelecionado.Items.AddRange(new object[] {
            "Login"});
            this.cbxCampoSelecionado.Location = new System.Drawing.Point(70, 3);
            this.cbxCampoSelecionado.Name = "cbxCampoSelecionado";
            this.cbxCampoSelecionado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxCampoSelecionado.Size = new System.Drawing.Size(122, 24);
            this.cbxCampoSelecionado.TabIndex = 1;
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
            // FormUsuarioView
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
            this.Name = "FormUsuarioView";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Usuários";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormClienteView_KeyDown);
            this.tableLayoutPanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.tableLayoutPanelAcoes.ResumeLayout(false);
            this.tableLayoutPanelBotoes.ResumeLayout(false);
            this.tableLayoutPanelPesquisa.ResumeLayout(false);
            this.tableLayoutPanelPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContainer;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
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
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnBloquear;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCampoSelecionado;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBloqueioDataGridViewTextBoxColumn;

    }
}