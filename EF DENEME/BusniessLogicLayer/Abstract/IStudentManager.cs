using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLogicLayer.Abstract
{
   public interface IStudentManager
    {
        List<Student> ListAll();

        List<Student> ListByID(int id);

        void Add(Student student);

        void Delete(Student student);

        void Update(Student student);
    }
}
