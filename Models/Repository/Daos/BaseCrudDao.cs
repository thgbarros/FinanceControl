using Barros.FinanceControl.Models.Repository.Interface;
using NHibernate;
using System;

namespace Barros.FinanceControl.Models.Repository.Daos {

    public abstract class BaseCrudDao<T, Pk> : AbstractGenericDao<T, Pk>, IBaseCrudDAO<T, Pk> where T : class {        
        public BaseCrudDao(ISession session) : base(session) {}

        /// <summary>
        ///  Salva ou atualiza o objeto T passado como parâmetro.        
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public T save(T entity) {
            Type typeEntity = this.getKey(entity).GetType();

            /*Chaves do tipo inteiro não são possíveis testa-lás contra null, deve haver
             uma forma, mas até o momento não encontrei a solução. Dessa forma fiz um 
             parse para string na chave, caso seja do tipo "int", para que possa verificar
             se o valor atual da chave é 0, valor default assumido pelas variavéis do tipo
             int.
             P.s.: Talvez o tipo long tbm tenha que fazer a mesma coisa, não testei pois
             ainda não foi necessário.
             */
            if (this.getKey(entity) == null ||
                (typeEntity.Equals(typeof(int)) &&
                 this.getKey(entity).ToString().Equals("0")))
                this.insert(entity);
            else
                this.update(entity);

            return entity;
        }

        public abstract Pk getKey(T entity);
        
    }
}
