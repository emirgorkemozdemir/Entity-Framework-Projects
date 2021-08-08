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
        List<ÖğrenciTablosu> ListAll();

        ÖğrenciTablosu ListByID(int id);

        void Add(ÖğrenciTablosu student);

        void Delete(ÖğrenciTablosu student);

        void Update(ÖğrenciTablosu student);
    }
}
