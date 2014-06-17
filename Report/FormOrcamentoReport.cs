using Barros.FinanceControl.Models.Entities.VOs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Barros.FinanceControl.Report
{
    public partial class FormOrcamentoReport : Form
    {
        public FormOrcamentoReport(IList<OrcamentoVO> orcamentos)
        {
            InitializeComponent();
            this.OrcamentoVOBindingSource.DataSource = orcamentos;
        }

        private void FormOrcamentoReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
