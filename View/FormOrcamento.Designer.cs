namespace Barros.FinanceControl.View
{
    partial class FormOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrcamento));
            this.tableLayoutPanelConteudo = new System.Windows.Forms.TableLayoutPanel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbTipoMes = new System.Windows.Forms.RadioButton();
            this.rbTipoAno = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMesSelecionado = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanelConteudo.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelConteudo
            // 
            this.tableLayoutPanelConteudo.ColumnCount = 3;
            this.tableLayoutPanelConteudo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.04925F));
            this.tableLayoutPanelConteudo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.95075F));
            this.tableLayoutPanelConteudo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelConteudo.Controls.Add(this.txtValor, 0, 6);
            this.tableLayoutPanelConteudo.Controls.Add(this.txtDescricao, 1, 2);
            this.tableLayoutPanelConteudo.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanelConteudo.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanelConteudo.Controls.Add(this.txtId, 1, 1);
            this.tableLayoutPanelConteudo.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanelConteudo.Controls.Add(this.flowLayoutPanel2, 1, 3);
            this.tableLayoutPanelConteudo.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanelConteudo.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanelConteudo.Controls.Add(this.cbxCategoria, 1, 4);
            this.tableLayoutPanelConteudo.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanelConteudo.Controls.Add(this.cbxMesSelecionado, 1, 5);
            this.tableLayoutPanelConteudo.Controls.Add(this.flowLayoutPanel1, 0, 7);
            this.tableLayoutPanelConteudo.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelConteudo.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelConteudo.Name = "tableLayoutPanelConteudo";
            this.tableLayoutPanelConteudo.RowCount = 8;
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28818F));
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28564F));
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28564F));
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28564F));
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28564F));
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28463F));
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28463F));
            this.tableLayoutPanelConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelConteudo.Size = new System.Drawing.Size(495, 282);
            this.tableLayoutPanelConteudo.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(147, 183);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(150, 26);
            this.txtValor.TabIndex = 70;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(147, 63);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(314, 26);
            this.txtDescricao.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descrição:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(147, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(86, 26);
            this.txtId.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanelConteudo.SetColumnSpan(this.panel1, 3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 24);
            this.panel1.TabIndex = 61;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.rbTipoMes);
            this.flowLayoutPanel2.Controls.Add(this.rbTipoAno);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(147, 93);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(314, 24);
            this.flowLayoutPanel2.TabIndex = 65;
            // 
            // rbTipoMes
            // 
            this.rbTipoMes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbTipoMes.AutoSize = true;
            this.rbTipoMes.Checked = true;
            this.rbTipoMes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTipoMes.Location = new System.Drawing.Point(3, 3);
            this.rbTipoMes.Name = "rbTipoMes";
            this.rbTipoMes.Size = new System.Drawing.Size(76, 22);
            this.rbTipoMes.TabIndex = 3;
            this.rbTipoMes.TabStop = true;
            this.rbTipoMes.Text = "Mensal";
            this.rbTipoMes.UseVisualStyleBackColor = true;
            // 
            // rbTipoAno
            // 
            this.rbTipoAno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbTipoAno.AutoSize = true;
            this.rbTipoAno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTipoAno.Location = new System.Drawing.Point(85, 3);
            this.rbTipoAno.Name = "rbTipoAno";
            this.rbTipoAno.Size = new System.Drawing.Size(65, 22);
            this.rbTipoAno.TabIndex = 4;
            this.rbTipoAno.Text = "Anual";
            this.rbTipoAno.UseVisualStyleBackColor = true;
            this.rbTipoAno.CheckedChanged += new System.EventHandler(this.rbTipoAno_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Tipo Orçamento:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Categoria:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCategoria.DisplayMember = "Descricao";
            this.cbxCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(147, 123);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(314, 26);
            this.cbxCategoria.TabIndex = 2;
            this.cbxCategoria.ValueMember = "Descricao";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 67;
            this.label3.Text = "Mês:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxMesSelecionado
            // 
            this.cbxMesSelecionado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxMesSelecionado.DisplayMember = "Descricao";
            this.cbxMesSelecionado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMesSelecionado.FormattingEnabled = true;
            this.cbxMesSelecionado.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbxMesSelecionado.Location = new System.Drawing.Point(147, 153);
            this.cbxMesSelecionado.Name = "cbxMesSelecionado";
            this.cbxMesSelecionado.Size = new System.Drawing.Size(150, 26);
            this.cbxMesSelecionado.TabIndex = 68;
            this.cbxMesSelecionado.ValueMember = "Descricao";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanelConteudo.SetColumnSpan(this.flowLayoutPanel1, 3);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanelBotoes);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 216);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(489, 60);
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
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 69;
            this.label4.Text = "Valor:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 282);
            this.Controls.Add(this.tableLayoutPanelConteudo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormOrcamento";
            this.tableLayoutPanelConteudo.ResumeLayout(false);
            this.tableLayoutPanelConteudo.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelConteudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBotoes;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton rbTipoMes;
        private System.Windows.Forms.RadioButton rbTipoAno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMesSelecionado;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
    }
}