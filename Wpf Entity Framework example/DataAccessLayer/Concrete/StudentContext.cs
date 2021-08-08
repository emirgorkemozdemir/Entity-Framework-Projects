using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class StudentContext:DbContext
    {
        public StudentContext() : base("name=StudentContext")
        {

        }
        public DbSet<ÖğrenciTablosu> ÖğrenciTablosu { get; set; }
    }
}
