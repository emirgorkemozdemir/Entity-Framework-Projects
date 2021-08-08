using DataAccess.Abstract;
using DataAccess.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLogic.Concrete
{
    public interface IBll<TEntity, TContext> : IEntityDal<TEntity> where TEntity : class, IDatabaseEntity, new()
    {
     
  

    }
}
