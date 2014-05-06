using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;

namespace Barros.FinanceControl.Models.Repository.Daos {
    
    public abstract class AbstractGenericDao<T, Pk> where T : class {
        private ISession session;        

        public AbstractGenericDao(ISession session){            
            this.session = session;            
        }

        public ISession Session { get { return this.session; } }
        
        public virtual void insert(T t){    
            using(ITransaction transaction = session.BeginTransaction()){                
                try {
                    this.session.Save(t);
                    transaction.Commit();
                }catch (Exception e) {  
                    if (transaction.WasCommitted)
                        transaction.Rollback();
                    throw e;
                }                
            }                        
        }

        public virtual void update(T t) {
            using (ITransaction transaction = session.BeginTransaction()) {
                try {
                    this.session.Update(t);
                    transaction.Commit();
                } catch (Exception e) {
                    if (transaction.WasCommitted)
                        transaction.Rollback();
                    throw e;
                }                
            }
            
        }

        public virtual void delete(T t) {
            using (ITransaction transaction = session.BeginTransaction()) {
                try{
                    this.session.Delete(t);
                    transaction.Commit();
                }catch (Exception e)
                {
                    if (transaction.WasCommitted)
                        transaction.Rollback();
                    throw e;
                }
            }
        }

        public T findById(Pk id) {
            return this.session.Get<T>(id);
        }

        public IList<T> findAll() {
            return this.session.CreateCriteria<T>().List<T>();
        }              

        private IQuery createQuery(String hql, params Object[] parans) {
            IQuery query = this.session.CreateQuery(hql);
            int i = 0;
            foreach (Object obj in parans)
                query.SetParameter(i++, obj);

            return query;
        }

        private IQuery createQueryWithNamedParameter(String hql, Dictionary<String, Object> parans) {
            IQuery query = this.session.CreateQuery(hql);
            string[] keys = parans.Keys.As<string[]>();
            foreach (string key in keys)
                query.SetParameter(key, parans[key]);
            return query;
        }
        

        public IList<T> findByHql(String hql, params Object[] parans){ 
            return this.createQuery(hql, parans).List<T>();
        }

        public IList<T> findByHql(String hql, Dictionary<String, Object> parans) {
            return this.createQueryWithNamedParameter(hql, parans).List<T>();
        }

        public Object findUniqueResultByHql(String hql, params Object[] parans) {
            try{
                return this.createQuery(hql, parans).UniqueResult<T>();
            } catch (NonUniqueObjectException e) {
                return null;
            }
        } 

        public Object findUniqueResultByHql(String hql, Dictionary<String, Object> parans) {
            try {
                return this.createQueryWithNamedParameter(hql, parans).UniqueResult<T>();
            } catch (NonUniqueObjectException e) {
                return null;
            }
        }

        public int count(T persistentAssembly) {
            String hql = "Select count(*) from " + persistentAssembly.GetType().Name;
            return int.Parse(this.createQuery(hql).UniqueResult().ToString());
        }
    } 
}
