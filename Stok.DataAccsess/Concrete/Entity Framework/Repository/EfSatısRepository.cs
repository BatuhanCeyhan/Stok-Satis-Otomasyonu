using Core.DataAccess.Concrate.EntityFramework;
using Stok.DataAccsess.Abstract;
using Stok.DataAccsess.Concrete.Entity_Framework.Context;
using Stok.Model.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.DataAccsess.Concrete.Entity_Framework.Repository
{
    public class EfSatısRepository: EfRepositoryBase<Satıs, Stok_OtomasyonuDbContext>, ISatısRepository
    {
    
    }
}
