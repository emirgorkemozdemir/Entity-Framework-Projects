using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public class Student:IDatabaseEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int SchoolNum { get; set; }
    }
}
