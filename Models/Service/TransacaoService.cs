using System;
using System.Collections.Generic;
using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Repository.Daos;
using Barros.FinanceControl.Models.Repository.Interface;


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

            return dao.findByHql("from Transacao c where c." + field + " like ?", "%" + value + "%");
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

            foreach (Categoria categoria in categorias) {
                hql += " and Categoria.id = :catId" + categoria.Id;
                parans.Add("catId" + categoria.Id, categoria.Id);
            }

            foreach (Conta conta in contas) {
                hql += " and Conta.id = :contId" + conta.Id;
                parans.Add("contId" + conta.Id, conta.Id);
            }

            hql += " order by t.Id asc, t.Data asc";

            return dao.findByHql(hql, parans);
        }
    }
}
