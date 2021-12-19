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
        public bool IsExistRecord(string ID)
        {
            var result = GetById(ID) == null ? false : true;
            return result;
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public T GetById(string ID)
        {
            return _dbSet.Find(ID);
        }
        public T GetById(int ID)
        {
            return _dbSet.Find(ID);
        }
        public List<T> GetList()
        {
            return _dbSet.ToList();
        }
        public List<T> GetListWithIslems()
        {
            return _dbSet.Include("kutuphaneIslems").ToList();
        }

        public void Remove(string ID)
        {
            _dbSet.Remove(GetById(ID));
            _context.SaveChanges();
        }


        public void Update(T obje)
        {
            _dbSet.Update(obje);
            _context.SaveChanges();
        }
    }
}
