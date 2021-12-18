using DTO.Abstract;

using Entitites;
using Entitites.Models;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Concrete
{
    public class OgrenciRepo : BaseRepo<Ogrenci>
    {
        public OgrenciRepo(DatabaseContext context) : base(context)
        {

        }
        public IEnumerable<Ogrenci> GetListWithIslemler()
        {
            return _dbSet.Include(x => x.kutuphaneIslems).ToList();
        }
    }
}
