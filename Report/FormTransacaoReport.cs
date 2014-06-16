using System;
using System.Windows.Forms;
using Barros.FinanceControl.Models.Service;
using Barros.FinanceControl.Models.Repository.Daos;
using Tecnomotor.InjectorTestPC.Models.Repositories;
using Barros.FinanceControl.Models.Entities;
using Microsoft.Reporting.WinForms;
using System.Data;
using System.Collections.Generic;
using Barros.FinanceControl.Models.Entities.VOs;

namespace Barros.FinanceControl.Report
{     

    public partial class FormTransacaoReport : Form  {        
        public FormTransacaoReport(IList<TransacaoVO> transacoes)
        {
            InitializeComponent();
            TransacaoVOBindingSource.DataSource = transacoes;
        }

        private void ReportTest_Load(object sender, EventArgs e)
        {            
            reportViewer1.RefreshReport();            
        }
    }
}
