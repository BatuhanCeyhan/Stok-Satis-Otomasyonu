using Stok.Bussinuss.Abstract;
using Stok.DataAccsess.Abstract;
using Stok.Model.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Bussinuss.Concrete
{
    public class SatısBs : ISatısBs
    {
        ISatısRepository repo;
        public SatısBs(ISatısRepository _repo)
        {
            repo = _repo;
        }
        public void Delete(Satıs entity)
        {
            repo.Delete(entity);
        }

        public Satıs Get(Expression<Func<Satıs, bool>> filter = null, params string[] includelist)
        {
           return repo.Get(filter, includelist);
        }

        public List<Satıs> GetAll(Expression<Func<Satıs, bool>> filter = null, params string[] includelist)
        {
           return repo.GetAll(filter, includelist);
        }

        public void Insert(Satıs entity)
        {
            repo.Insert(entity);
        }

        public void Update(Satıs entity)
        {
           repo.Update(entity);
        }
    }
}
