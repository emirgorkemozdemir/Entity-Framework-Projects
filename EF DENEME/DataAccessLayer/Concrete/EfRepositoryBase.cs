using DataAccessLayer.Abstract;
using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class EfRepositoryBase<Tentity, Tcontext> : IEntityDal<Tentity> 
        where Tentity : class, IDatabaseData, new()
        where Tcontext:DbContext, new()
    {
        public void Add(Tentity tempEntity)
        {
            using (Tcontext context = new Tcontext())
            {
                var addEntity = context.Entry(tempEntity);

                addEntity.State = EntityState.Added;

                context.SaveChanges();
            }
        }

        public void Delete(Tentity tempEntity)
        {
            using (Tcontext context = new Tcontext())
            {
                var addEntity = context.Entry(tempEntity);

                addEntity.State = EntityState.Deleted;

                context.SaveChanges();
            }
        }

        public List<Tentity> ListAll()
        {
            using (Tcontext context = new Tcontext())
            {
                return context.Set<Tentity>().ToList();
            }
        }

        public List<Tentity> ListByID(int id)
        {
            using (Tcontext context = new Tcontext())
            {
                return context.Set<Tentity>().ToList();
            }
        }

        public void Update(Tentity tempEntity)
        {
            using (Tcontext context = new Tcontext())
            {
                var addEntity = context.Entry(tempEntity);

                addEntity.State = EntityState.Modified;

                context.SaveChanges();
            }
        }
    }
}
