using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Service;

namespace Barros.FinanceControl.View {

    public partial class FormCategoria : Form {

        private CategoriaService categoriaService;
        private Categoria categoriaParaAlterar;

        public FormCategoria(CategoriaService categoriaService, Categoria categoria) : this(categoriaService){
            this.categoriaParaAlterar = categoria;

            txtId.Text = categoria.Id.ToString();
            txtDescricao.Text = categoria.Descricao;   
            if (categoria.CategoriaPai != null)         
                cbxCategoriaPai.SelectedItem = categoria.CategoriaPai;
        }

        public FormCategoria(CategoriaService categoriaService) {
            InitializeComponent();
            cbxCategoriaPai.DataSource = categoriaService.getAll();
            this.categoriaService = categoriaService;
        }

        private Categoria getCategoria() {
            Categoria categoria = categoriaParaAlterar;
            if (categoriaParaAlterar == null)
                categoria = new Categoria();

            categoria.Descricao = txtDescricao.Text;
            categoria.CategoriaPai = null;
            if (cbxCategoriaPai.Items.Count > 0 && cbxCategoriaPai.SelectedIndex >= 0) 
                categoria.CategoriaPai = ((IList<Categoria>)cbxCategoriaPai.DataSource)[cbxCategoriaPai.SelectedIndex];

            if (categoria.CategoriaPai != null && categoria.CategoriaPai.Equals(categoria)) {
                categoria.CategoriaPai = null;
                throw new InvalidOperationException("A categoria pai não pode ser a mesma categoria que está sendo cadastrada!");
            }

            if (rbTipoDespesa.Checked)
                categoria.TipoCategoria = TipoCategoria.DESPESA;
            else
                categoria.TipoCategoria = TipoCategoria.RECEITA;

            if (categoria.CategoriaPai != null && !categoria.TipoCategoria.Equals(categoria.CategoriaPai.TipoCategoria)) {
                categoria.TipoCategoria = TipoCategoria.NONE;
                throw new InvalidOperationException("A categoria pai não pode ter o tipo diferente da categoria que está sendo cadastrada!");
            }
                
            return categoria;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, System.EventArgs e)
        {
            try {
                categoriaService.save(getCategoria());
                btnCancelar_Click(btnGravar, null);
            } catch (InvalidOperationException ioe) {
                MessageBox.Show(ioe.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
