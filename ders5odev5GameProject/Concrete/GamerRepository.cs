using ders5odev5GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders5odev5GameProject.Concrete
{
    public class GamerRepository : IRepository<Entities.Gamer>
    {
        public void Add(Gamer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Gamer entity)
        {
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gamer> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gamer> GetFiltered(Func<Gamer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Gamer entity)
        {
            throw new NotImplementedException();
        }
    }
}
