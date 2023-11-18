using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH69LS_HFT_2023241.Models;

namespace TH69LS_HFT_2023241.Repository.Repository
{
    public class CatRepository:Repository<Cat>, IRepository<Cat>
    {
        public CatRepository(CatDbContext x) : base(x)
        {
        }

        public override Cat Read(int ID)
        {
            return x.Cats.FirstOrDefault(x => x.ID == ID);
        }

        public override void Update(Cat item)
        {
            var old = Read(item.ID);
            foreach (var prop in old.GetType().GetProperties())
            {
                prop.SetValue(old, prop.GetValue(item));
            }
            x.SaveChanges();

        }
    }
}
