
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH69LS_HFT_2023241.Models;

namespace TH69LS_HFT_2023241.Repository.Repository
{
    internal class Cat_SitterRepository : Repository<Cat_Sitter>, IRepository<Cat_Sitter>
    {
        public Cat_SitterRepository(CatDbContext x) : base(x)
        {
        }

        public override Cat_Sitter Read(int ID)
        {
            return x.Cat_Sitters.FirstOrDefault(x => x.ID == ID);
        }

        public override void Update(Cat_Sitter item)
        {
            var old = Read(item.ID);
            foreach (var prop in old.GetType().GetProperties())
            {
                prop.SetValue(old,prop.GetValue(item));
            }
            x.SaveChanges();

        }
    }
}
