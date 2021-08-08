using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public interface IEntityDal<T> where T: IDatabaseEntity , new()
    {
        void Add(T tempEntity);

        void Delete(int tempID);

        List<T> List();

        List<T> ListByID(int tempID);

        void Update(T tempEntity);
    }
}
