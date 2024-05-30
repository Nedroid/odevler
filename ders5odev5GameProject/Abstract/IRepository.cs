using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ders5odev5GameProject.Abstract
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetFiltered(Func<T,bool> predicate);
    }
}
