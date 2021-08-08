using DataAccessLayer.Abstract;
using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class EfRepositoryBase<Tentity, Tcontext> : IEntityDal<Tentity> where Tentity : class, IDatabaseEntity, new()
        where Tcontext:DbContext,new()
    {
        public void Add(Tentity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var addEntity = context.Entry(entity);

                addEntity.State = EntityState.Added;

                context.SaveChanges();
            }
        }

        public void Delete(Tentity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var deletingEntity = context.Entry(entity);

                deletingEntity.State = EntityState.Deleted;

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

        public Tentity ListById(int id)
        {
            using (Tcontext context = new Tcontext())
            {
                return context.Set<Tentity>().Find(id);
            }
        }

        public void Update(Tentity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var deletingEntity = context.Entry(entity);

                deletingEntity.State = EntityState.Modified;

                context.SaveChanges();
            }
        }
    }
}
