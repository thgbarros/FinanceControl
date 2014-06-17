using Barros.FinanceControl.Models.Entities;
using Barros.FinanceControl.Models.Entities.VOs;
using Barros.FinanceControl.Models.Repository.Daos;
using Barros.FinanceControl.Models.Repository.Interface;
using System;
using System.Collections.Generic;

namespace Barros.FinanceControl.Models.Service {
    
    public class OrcamentoService : BaseCrudService<Orcamento, int> {
        private OrcamentoDao dao;

        public OrcamentoService(OrcamentoDao dao) {
            this.dao = dao;
        }

        protected override IBaseCrudDAO<Orcamento, int> getDao() {
            return this.dao;
        }

        public override IList<Orcamento> thisValue(string value) {
            if (string.IsNullOrEmpty(value))
                return base.getAllListOrderBy(field);

            return dao.findByHql("from Orcamento o where o." + field + " like ?", "%" + value + "%");
        }

        protected override IList<Orcamento> getAllListOrderBy(string field, string orderBy) {
            if (!propertyIsValid(field))
                throw new ArgumentException("Propriedade inválida!");

            return dao.findByHql("from Orcamento order by " + field + " " + orderBy);
        }

        public IList<OrcamentoVO> getOrcamentoVOList(IList<Orcamento> orcamentos) {
            IList<OrcamentoVO> orcamentosVO = new List<OrcamentoVO>();
            
            foreach (Orcamento orc in orcamentos) {                
                orcamentosVO.Add(new OrcamentoVO(orc.Id, orc.Descricao, orc.Categoria.ToString(),
                                        (int)orc.TipoOrcamento, orc.Mes, orc.Ano, orc.Valor));
            }            
            return orcamentosVO;
        }

    }
}
