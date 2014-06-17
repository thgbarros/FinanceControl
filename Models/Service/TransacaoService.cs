using System;
using System.Collections.Generic;
using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Repository.Daos;
using Barros.FinanceControl.Models.Repository.Interface;
using Barros.FinanceControl.Models.Entities.VOs;


namespace Barros.FinanceControl.Models.Service {
    
    public class TransacaoService : BaseCrudService<Transacao, int> {
        private TransacaoDao dao;

        public TransacaoService(TransacaoDao dao) {
            this.dao = dao;
        }

        protected override IBaseCrudDAO<Transacao, int> getDao() {
            return this.dao;
        }

        public override IList<Transacao> thisValue(string value) {
            if (string.IsNullOrEmpty(value))
                return base.getAllListOrderBy(field);
            
            if (!field.Equals("Data") && !field.Equals("Valor"))
                return dao.findByHql("from Transacao c where c." + field + " like ?", "%" + value + "%");
            else if (field.Equals("Data"))
                return dao.findByHql("from Transacao c where c." + field + " = ?", DateTime.Parse(value));
            else
                return dao.findByHql("from Transacao c where c." + field + " = ?", value);
        }

        protected override IList<Transacao> getAllListOrderBy(string field, string orderBy) {
            if (!propertyIsValid(field))
                throw new ArgumentException("Propriedade inválida!");

            return dao.findByHql("from Transacao order by " + field + " " + orderBy);
        }

        public IList<Transacao> getAllListUntilDate(DateTime date) {
            return dao.findByHql("from Transacao t where t.Data <= ? order by t.Id asc, t.Data asc", date);
        }

        public IList<Transacao> getAllListOfPeriod(DateTime dateInit, DateTime dateFinish) {
            return dao.findByHql("from Transacao t where t.Data <= ? and t.Data <= ? order by t.Id asc, t.Data asc", dateInit, dateFinish);
        }

        public IList<Transacao> getAllListOfFilterInPeriod(DateTime dateInit, DateTime dateFinish, 
            List<Categoria> categorias, List<Conta> contas) {

            string hql = "from Transacao t where t.Data >= :dataIni and t.Data <= :dataFim";
            Dictionary<String, Object> parans = new Dictionary<string, object>();

            parans.Add("dataIni", dateInit);
            parans.Add("dataFim", dateFinish);
            

            for (int i = 0; i < categorias.Count; i++ )  {
                Categoria categoria = categorias[i];

                if (i == 0)
                    hql += " and (";
                hql += " Categoria.id =:catId" + categoria.Id;
                parans.Add("catId" + categoria.Id, categoria.Id);

                if (i < categorias.Count - 1)
                    hql += " or";
                else
                    hql += " )";
                
            }

            for (int i = 0; i < contas.Count; i++) {
                Conta conta = contas[i];

                if (i == 0)
                    hql += " and (";
                hql += " Conta.id = :contId" + conta.Id;
                parans.Add("contId" + conta.Id, conta.Id);

                if (i < contas.Count - 1)
                    hql += " or";
                else
                    hql += " )";
            }

            hql += " order by t.Data asc, t.Id asc";

            return dao.findByHql(hql, parans);
        }

        public IList<TransacaoVO> getTransacaoVOList(IList<Transacao> transacoes) {
            IList<TransacaoVO> transacaoesVO = new List<TransacaoVO>();
            List<Conta> contasAdd = new List<Conta>();
            foreach (Transacao trans in transacoes) {
                Conta conta = trans.Conta;
                double saldoInicial = 0;
                double saldo = 0;

                if (!contasAdd.Contains(conta))  {
                    contasAdd.Add(conta);
                    saldoInicial = conta.SaldoInicial;
                    saldo = conta.Saldo;
                } else {
                    saldoInicial = 0;
                    saldo = 0;
                }
                
                transacaoesVO.Add(new TransacaoVO(trans.Id, trans.Data, trans.Descricao, 
                        trans.Categoria.ToString(), trans.Conta.ToString(), saldoInicial , 
                            saldo, trans.Valor));
            }
            contasAdd = null;
            return transacaoesVO;
        }
    }
}
