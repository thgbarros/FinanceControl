using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barros.FinanceControl.Models.Repository.Interface {

    /// <summary>
    /// BaseCrudDao.
    /// 
    /// @Author Thiago Barros
    /// </summary>
    /// <typeparam name="T">Tipo genérico que indica o tipo que será persistido no banco de dados.</typeparam>
    /// <typeparam name="k">Tipo genérico que indica o tipo da chave do objeto persistido no banco de dados.</typeparam>
    public interface IBaseCrudDAO<T, k> {

        /// <summary>
        /// Insere ou atualiza a entidade passada como parâmetro.
        /// </summary>
        /// <param name="entity">Entidade serializavel que será persistida.</param>
        /// <returns>Retorno a entidade persistida. </returns>
        /// remarks Persistent (persistentes) - São objetos que possuem uma representação no banco de dados;
        T save(T entity);

        /// <summary>
        /// Deleta a entidade passada como parâmetro.
        /// </summary>
        /// <param name="entity">Entidade serializável que ficará transient</param>
        /// remarks Transient (transientes) - São objetos que ainda não 
        /// possuem uma representação no banco de dados ou que já foram excluídos;
        void delete(T entity);

        /// <summary>
        /// Retorna todos os objetos Persistidos da entidade.
        /// </summary>
        /// <returns>IList</returns>
        IList<T> findAll();


        /// <summary>
        /// Procura uma objeto persistent no banco de dados.
        /// </summary>
        /// <param name="id">Id do objeto persistent</param>
        /// <returns></returns>
        T findById(k id);
    }
}
