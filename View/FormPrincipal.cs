using System;
using System.Windows.Forms;
using Barros.FinanceControl.View;
using Barros.FinanceControl.Models.Entities;

namespace Barros.FinanceControl{

    public partial class FormPrincipal : Form{
        private static FormPrincipal formPrincipal;
        private Form childForm = null;        

        private FormPrincipal() {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();            
            InitializeComponent();
        }

        private void showMdiForm(Form form) {
            if (form == null)
                return;
            
            if (childForm == null)
                childForm = form;
            else if (!childForm.GetType().Equals(form.GetType()) || childForm.IsDisposed) {
                childForm.Close();
                childForm = null;
                childForm = form;
            }

            childForm.MdiParent = this;
            childForm.MaximizeBox = false;
            childForm.MinimizeBox = false;
            childForm.Show();
            childForm.WindowState = FormWindowState.Maximized;            
        }

        public static FormPrincipal getInstance()
        {
            if (formPrincipal != null)
                return formPrincipal;

            formPrincipal = new FormPrincipal();
            return formPrincipal;
        }

        public void enablePanelBotoes() {
            tableLayoutPanelBotoes.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarioToolStripMenuItem_Click(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contasToolStripMenuItem_Click(null, null);
        }        

        private void relatóriosPorPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                showMdiForm(new FormUsuarioView());
            } catch (Exception ex) { }            
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMdiForm(new FormContaView()); 
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMdiForm(new FormCategoriaView());
        }

        private void transacoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanelBotoes.Visible = false;
            showMdiForm(new FormTransacaoView());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTransacoes_Click(object sender, EventArgs e)
        {            
            transacoesToolStripMenuItem_Click(null, null);
        }

        private void logofToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioLogado.getInstance().logout();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }
       
    }
}
