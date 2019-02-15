using Shopping.DL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.REP
{
    public class BaseRepository<T> : IRepository<T> where T : class, new()
    {
        NORTHWNDEntities db = DBSingleTone.GetInstance();
        public T Bul(int id)
        {
            return Set().Find(id);
        }

        public T Bul(string id)
        {
            return Set().Find(id);
        }

        public void Ekle(T entity)
        {
            db.Entry(entity).State = EntityState.Added;
        }

        public IQueryable<T> GenelListe()
        {
            return Set().AsQueryable();
        }

        public void Guncelle(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public List<T> Liste()
        {
            return Set().ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public DbSet<T> Set()
        {
            return db.Set<T>();
        }

        public void Sil(T entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
        }
    }
}
