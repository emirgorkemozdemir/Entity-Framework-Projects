using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public class DalStudent : IEntityDal<Student>
    {
        public void Add(Student tempEntity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int tempID)
        {
            throw new NotImplementedException();
        }

        public List<Student> List()
        {
            throw new NotImplementedException();
        }

        public List<Student> ListByID(int tempID)
        {
            throw new NotImplementedException();
        }

        public void Update(Student tempEntity)
        {
            throw new NotImplementedException();
        }
    }
}
