using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH69LS_HFT_2023241.Models;

namespace TH69LS_HFT_2023241.Repository.Repository
{
    public class Cat_OwnerRepository:Repository<Cat_Owner>, IRepository<Cat_Owner>  
    {
        public Cat_OwnerRepository(CatDbContext x) : base(x)
        {
        }

        public override Cat_Owner Read(int ID)
        {
            return x.Cat_Owners.FirstOrDefault(x => x.ID == ID);
        }

        public override void Update(Cat_Owner item)
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
