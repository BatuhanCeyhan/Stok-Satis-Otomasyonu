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
    public class GirisBs : IGirisBs
    {
        IGirisRepository repo;
        public GirisBs(IGirisRepository _repo)
        {
                repo= _repo;
        }
        public void Delete(Giris entity)
        {
            repo.Delete(entity);
        }

        public Giris Get(Expression<Func<Giris, bool>> filter = null, params string[] includelist)
        {
           return repo.Get(filter, includelist);
        }

        public List<Giris> GetAll(Expression<Func<Giris, bool>> filter = null, params string[] includelist)
        {
           return repo.GetAll(filter, includelist);
        }

        public void Insert(Giris entity)
        {
            repo.Insert(entity);
        }

        public void Update(Giris entity)
        {
            repo.Update(entity);
        }
    }
}
