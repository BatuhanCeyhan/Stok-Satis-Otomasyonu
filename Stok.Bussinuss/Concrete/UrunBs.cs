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
    public class UrunBs : IUrunBs
    {
        IUrunRepository repo;
        public UrunBs(IUrunRepository _repo)
        {
                repo= _repo;
        }
        public void Delete(Urun entity)
        {
            repo.Delete(entity); 
        }

        public Urun Get(Expression<Func<Urun, bool>> filter = null, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Urun> GetAll(Expression<Func<Urun, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public void Insert(Urun entity)
        {
            repo.Insert(entity);
        }

        public void Update(Urun entity)
        {
            repo.Update(entity);
        }
    }
}
