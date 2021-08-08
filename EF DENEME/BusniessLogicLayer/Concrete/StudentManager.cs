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

        public void Add(Student student)
        {
            studentDal.Add(student);
        }

        public void Delete(Student student)
        {
            studentDal.Delete(student);
        }

        public List<Student> ListAll()
        {
            return studentDal.ListAll();
        }

        public List<Student> ListByID(int id)
        {
            return studentDal.ListByID(id);
        }

        public void Update(Student student)
        {
            studentDal.Update(student);
        }
    }
}
