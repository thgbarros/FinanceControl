namespace Barros.FinanceControl.View
{
    partial class FormCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoria));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelConteudo = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxCategoriaPai = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbTipoReceita = new System.Windows.Forms.RadioButton();
            this.rbTipoDespesa = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanelConteudo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanelConteudo.SetColumnSpan(this.panel1, 3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 19);
            this.panel1.TabIndex = 61;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(145, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(86, 26);
            this.txtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descrição:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Categoria Pai:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(145, 69);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(335, 26);
            this.txtDescricao.TabIndex = 1;
            // 
            // tableLayoutPanelConteudo
            // 
            this.tableLayoutPanelConteudo.ColumnCount = 3;
            this.tableLayoutPanelConteudo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.39914F));
            this.tableLayoutPanelConteudo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.60086F));
            this.tableLayoutPanelConteudo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanelConteudo.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanelConteudo.Controls.Add(this.txtDescricao, 1, 2);
            this.tableLayoutPanelConteudo.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanelConteudo.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanelConteudo.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanelConteudo.Controls.Add(this.txtId, 1, 1);
            this.tableLayoutPanelConteudo.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanelConteudo.Controls.Add(this.flowLayoutPanel1, 0, 6);
            this.tableLayoutPanelConteudo.Controls.Add(this.cbxCategoriaPai, 1, 3);
            this.tableLayoutPanelConteudo.Controls.Add(this.flowLayoutPanel2, 1, 4);
            this.tableLayoutPanelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelConteudo.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelConteudo.Name = "tableLayoutPanelConteudo";
            this.tableLayoutPanelConteudo.RowCount = 7;
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelConteudo.Size = new System.Drawing.Size(510, 267);
            this.tableLayoutPanelConteudo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Tipo Categoria:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanelConteudo.SetColumnSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanelBotoes);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 202);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(504, 60);
            this.flowLayoutPanel1.TabIndex = 63;
            // 
            // tableLayoutPanelBotoes
            // 
            this.tableLayoutPanelBotoes.ColumnCount = 4;
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelBotoes.Controls.Add(this.btnGravar, 2, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.btnCancelar, 3, 0);
            this.tableLayoutPanelBotoes.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelBotoes.Name = "tableLayoutPanelBotoes";
            this.tableLayoutPanelBotoes.RowCount = 1;
            this.tableLayoutPanelBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBotoes.Size = new System.Drawing.Size(480, 52);
            this.tableLayoutPanelBotoes.TabIndex = 61;
            // 
            // btnGravar
            // 
            this.btnGravar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGravar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(243, 3);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(114, 46);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "F5 - Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(363, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 46);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "F6 - Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxCategoriaPai
            // 
            this.cbxCategoriaPai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCategoriaPai.DataSource = this.categoriaBindingSource;
            this.cbxCategoriaPai.DisplayMember = "Descricao";
            this.cbxCategoriaPai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoriaPai.FormattingEnabled = true;
            this.cbxCategoriaPai.Location = new System.Drawing.Point(145, 102);
            this.cbxCategoriaPai.Name = "cbxCategoriaPai";
            this.cbxCategoriaPai.Size = new System.Drawing.Size(335, 26);
            this.cbxCategoriaPai.TabIndex = 2;
            this.cbxCategoriaPai.ValueMember = "Descricao";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Barros.FinanceControl.Models.Entities.Categoria);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.rbTipoReceita);
            this.flowLayoutPanel2.Controls.Add(this.rbTipoDespesa);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(145, 135);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(335, 27);
            this.flowLayoutPanel2.TabIndex = 65;
            // 
            // rbTipoReceita
            // 
            this.rbTipoReceita.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbTipoReceita.AutoSize = true;
            this.rbTipoReceita.Checked = true;
            this.rbTipoReceita.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTipoReceita.Location = new System.Drawing.Point(3, 3);
            this.rbTipoReceita.Name = "rbTipoReceita";
            this.rbTipoReceita.Size = new System.Drawing.Size(80, 22);
            this.rbTipoReceita.TabIndex = 3;
            this.rbTipoReceita.TabStop = true;
            this.rbTipoReceita.Text = "Receita";
            this.rbTipoReceita.UseVisualStyleBackColor = true;
            // 
            // rbTipoDespesa
            // 
            this.rbTipoDespesa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbTipoDespesa.AutoSize = true;
            this.rbTipoDespesa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTipoDespesa.Location = new System.Drawing.Point(89, 3);
            this.rbTipoDespesa.Name = "rbTipoDespesa";
            this.rbTipoDespesa.Size = new System.Drawing.Size(90, 22);
            this.rbTipoDespesa.TabIndex = 4;
            this.rbTipoDespesa.Text = "Despesa";
            this.rbTipoDespesa.UseVisualStyleBackColor = true;
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 267);
            this.Controls.Add(this.tableLayoutPanelConteudo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Categoria";
            this.tableLayoutPanelConteudo.ResumeLayout(false);
            this.tableLayoutPanelConteudo.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelConteudo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBotoes;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxCategoriaPai;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton rbTipoReceita;
        private System.Windows.Forms.RadioButton rbTipoDespesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource categoriaBindingSource;


    }
}