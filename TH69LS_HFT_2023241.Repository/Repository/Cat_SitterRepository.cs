
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
            throw new NotImplementedException();
        }

        public override void Update(Cat_Sitter item)
        {
            throw new NotImplementedException();
        }
    }
}
