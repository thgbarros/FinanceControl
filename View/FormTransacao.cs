using System.Windows.Forms;

namespace Barros.FinanceControl.View
{
    public partial class FormTransacao : Form
    {

        public FormTransacao()
        {
            InitializeComponent();            
        }

 
        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, System.EventArgs e)
        {            
            btnCancelar_Click(btnGravar, null);
        }
    }
}
