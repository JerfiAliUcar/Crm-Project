using AspNetMvc.Framework.Entity;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvc.Framework.Repository
{
    public class BaseRepository<TEntity,TDbContext>:IRepository<TEntity>
        where TDbContext : DbContext
        where TEntity : BaseEntity
        //where komutu generic olarak gönderdiğimiz TEntity ve TContext'in türünün ne olduğunu belirtmemize yarar.
        //TEntity'in BaseEntity'den türemiş olması gerektiğini belirtiyoruz.
        //TContext'in DbContext'den türemiş olması gerektiğini belirtiyoruz. Böylece Set gibi komutları kullanabiliriz.
    {
        private readonly TDbContext _db;

        public BaseRepository(TDbContext db)
        {
            _db = db;
        }
        
        public List<TEntity> GetAll()
        {
            return _db.Set<TEntity>().ToList();
        }

        public TEntity? GetById(int id)
        {
            return _db.Set<TEntity>().FirstOrDefault(e => e.Id == id);
        }

        public bool Insert(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);
            int affected = _db.SaveChanges();

            return affected > 0;
        }

        public bool Update(TEntity entity)
        {
            _db.Set<TEntity>().Update(entity);
            int affected = _db.SaveChanges();
            return affected > 0;
        }

        public bool Delete(TEntity entity)
        {
            _db.Set<TEntity>().Remove(entity);
            int affected = _db.SaveChanges();
            return affected > 0;
        }

        public bool DeleteById(int id)
        {
            var entity = _db.Set<TEntity>().Find(id);
            _db.Set<TEntity>().Remove(entity);
            int affected = _db.SaveChanges();
            return affected > 0;

        }
    }
}
