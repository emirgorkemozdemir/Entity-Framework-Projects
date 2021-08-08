using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IEntityDal<T> where T: class,  IDatabaseEntity ,  new()
    {
        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        List<T> ListAll();

        T ListById(int id);
    }
}
