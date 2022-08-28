using Data.Context;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public string Create(T entity)
        {
            using (FipeContext fipeContext = new FipeContext())
            {
                fipeContext.Add(entity);
                fipeContext.SaveChanges();
            }
            return "Created";
        }

        public string Delete(int id)
        {
           using (FipeContext fipeContext= new FipeContext())
            {
                fipeContext.Remove(id);
                fipeContext.SaveChanges();
            }
            return $"Deleted id: {id}";
        }

        public List<T> GetAll()
        {
            List<T> list = new List<T>();
            using(FipeContext fipeContext= new FipeContext())
            {
                list = fipeContext.Set<T>().ToList();
            }
            return list;
        }

        public T GetById(int id)
        {
           T entity = null;
            return entity;
        }

        public string Update(T entity)
        {
            return "Updated";
        }
    }
}
