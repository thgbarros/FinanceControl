using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barros.FinanceControl.Controller {
    
    public class TransacaoController {
        private TransacaoService transacaoService;
        private List<Categoria> filtroCategoria = new List<Categoria>();
        private List<Conta> filtroConta = new List<Conta>();

        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public TransacaoController(TransacaoService transacaoService) {
            this.transacaoService = transacaoService;
        }

        public TransacaoController(TransacaoService transacaoService, List<Categoria> filtroCategoria) : 
            this(transacaoService){
                this.filtroCategoria = filtroCategoria;
        }

        public TransacaoController(TransacaoService transacaoService, List<Conta> filtroConta) : 
            this(transacaoService) {
                this.filtroConta = filtroConta;        
        }

        public TransacaoController(TransacaoService transacaoService, List<Conta> filtroConta, 
            List<Categoria> filtroCategoria) : this(transacaoService, filtroCategoria){
                this.filtroConta = filtroConta;
        }

        public TransacaoController addFiltro(Categoria categoria) {
            this.filtroCategoria.Add(categoria);
            return this;
        }

        public TransacaoController addFiltro(Conta conta) {
            this.filtroConta.Add(conta);
            return this;
        }

        public TransacaoController removeFiltro(Categoria categoria) {
            this.filtroCategoria.Remove(categoria);
            return this;
        }

        public TransacaoController removeFiltro(Conta conta) {
            this.filtroConta.Remove(conta);
            return this;
        }

        public IList<Transacao> getTodasTransacao() {
            return transacaoService.getAllListOfFilterInPeriod(
                        DataInicial, DataFinal, filtroCategoria, filtroConta);            

        }
    }
}
