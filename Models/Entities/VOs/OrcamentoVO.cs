using System;

namespace Barros.FinanceControl.Models.Entities.VOs {
    public class OrcamentoVO  {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public int TipoOrcamento { get; set; }
        public string Mes { get; set; }
        public int Ano { get; set; }
        public double Valor { get; set; }

        public OrcamentoVO(int id, string descricao, string categoria, int tipoOrcamento, 
                string mes, int ano, double valor)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Categoria = categoria;
            this.TipoOrcamento = tipoOrcamento;
            this.Mes = mes;
            this.Ano = ano;
            this.Valor = valor;
        }
    }
}
