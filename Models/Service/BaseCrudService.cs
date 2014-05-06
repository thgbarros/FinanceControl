using Barros.FinanceControl.Models.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Barros.FinanceControl.Models.Service {

    public abstract class BaseCrudService<T, Pk> {
        private Type attributeType = null;
        protected string field;

        public void save(T entity) {
            this.getDao().save(entity);
        }

        public void update(T entity) {
            this.getDao().save(entity);
        }

        public IList<T> getAll() {
            return this.getDao().findAll();
        }

        public T getById(Pk id) {
            return this.getDao().findById(id);
        }

        public void delete(T entity) {
            this.getDao().delete(entity);
        }

        public IList<string> getAllProperties() {
            return getAllPropertiesWithoutType(null);
        }

        public IList<string> getAllPropertiesWitoutPropertyName(params string[] name) {
            IList<string> properties = new List<string>();
            Type t = (attributeType == null ? typeof(T) : attributeType);
            foreach (PropertyInfo fi in typeof(T).GetProperties()) {
                foreach (string tParam in name)
                    if (string.IsNullOrEmpty(tParam) || !fi.Name.Equals(tParam))
                        properties.Add(fi.Name);
            }
            return properties;
        }

        public IList<string> getAllPropertiesWithoutType(params Type[] type) {
            IList<string> properties = new List<string>();
            Type t = (attributeType == null ? typeof(T) : attributeType);
            foreach (PropertyInfo fi in t.GetProperties()) {
                Type propertyType = fi.PropertyType;
                if (type == null)  {
                    properties.Add(fi.Name);
                    continue;
                }

                foreach (Type tParam in type) {
                    if (!propertyType.Equals(tParam)) {
                        properties.Add(fi.Name);
                        break;
                    }
                }

            }
            return properties;
        }

        public IList<T> getAllListOrderBy(string field) {
            return getAllListOrderBy(field, null);
        }

        public IList<T> getAllListOrderByAsc(string field) {
            return getAllListOrderBy(field, "ASC");
        }

        public IList<T> getAllListOrderByDesc(string field) {
            return getAllListOrderBy(field, "DESC");
        }

        protected bool propertyIsValid(string name)  {
            return getAllProperties().Contains(name);
        }

        public BaseCrudService<T, Pk> searchByField(string field) {
            if (!propertyIsValid(field))
                throw new ArgumentException("Propriedade não encontrada!");

            this.field = field;
            return this;
        }

        public abstract IList<T> thisValue(string value);

        protected abstract IBaseCrudDAO<T, Pk> getDao();

        protected abstract IList<T> getAllListOrderBy(string field, string orderBy);

    }
}
