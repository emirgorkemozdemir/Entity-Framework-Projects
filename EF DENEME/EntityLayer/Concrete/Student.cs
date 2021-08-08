using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Student:IDatabaseData
    {
     
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int StudentNumber { get; set; }
    }
}
