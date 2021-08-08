using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IEntityDal<T> where T:class , IDatabaseData , new()
    {
        void Add(T tempEntity);

        void Delete(T tempEntity);

        List<T> ListAll();

        List<T> ListByID(int id);

        void Update(T tempEntity);
    }
}
