using BusniessLogicLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLogicLayer.Concrete
{
   public class StudentManager : IStudentManager
    {
        StudentDal studentDal = new StudentDal();

        public void Add(ÖğrenciTablosu student)
        {
            studentDal.Add(student);
        }

        public void Delete(ÖğrenciTablosu student)
        {
            studentDal.Delete(student);
        }

        public List<ÖğrenciTablosu> ListAll()
        {
           return studentDal.ListAll();
        }

        public ÖğrenciTablosu ListByID(int id)
        {
            return studentDal.ListById(id);
        }

        public void Update(ÖğrenciTablosu student)
        {
            studentDal.Update(student);
        }
    }
}
