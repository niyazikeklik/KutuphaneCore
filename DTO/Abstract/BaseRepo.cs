using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Abstract
{
    public abstract class BaseRepo<T> where T : class
    {
        protected DatabaseContext _context;
        protected DbSet<T> _dbSet;
        public BaseRepo(DatabaseContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public void AddRange(IEnumerable<T> list)
        {
            _dbSet.AddRange(list);
            _context.SaveChanges();

        }
        public T GetById(int ID)
        {
            return _dbSet.Find(ID);
        }
        public IEnumerable<T> GetList()
        {
            return _dbSet.ToList();
        }
        public IEnumerable<T> GetListWithIslems()
        {
            return _dbSet.Include("kutuphaneIslems").ToList();
        }

        public void Remove(int ID)
        {
            _dbSet.Remove(GetById(ID));
            _context.SaveChanges();
        }
        public void RemoveRange(IEnumerable<T> list)
        {
            _dbSet.RemoveRange(list);
            _context.SaveChanges();
        }

        public void Update(T obje)
        {
            _dbSet.Update(obje);
            _context.SaveChanges();
        }
    }
}
