using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH69LS_HFT_2023241.Models;
using TH69LS_HFT_2023241.Repository;

namespace TH69LS_HFT_2023241.Logic
{
    public class Cat_SitterLogic : ICat_SitterLogic
    {
        IRepository<Cat_Sitter> repo;

        public Cat_SitterLogic(IRepository<Cat_Sitter> repo)
        {
            this.repo = repo;
        }

        public void Create(Cat_Sitter item)
        {
            if (item.Sitter_Name == "")
            {
                throw new ArgumentException("You need to give a name for your sitter");
            }
            this.repo.Create(item);
        }

        public void Delete(int ID)
        {
            if (this.repo.Read(ID) == null)
            {
                throw new ArgumentException($"We have not found any sitter with this ID: {ID}");
            }
            this.repo.Delete(ID);
        }

        public Cat_Sitter Read(int ID)
        {
            if (this.repo.Read(ID) == null)
            {
                throw new ArgumentException($"We have not found any sitter with this ID: {ID}");
            }
            return this.repo.Read(ID);
        }

        public System.Linq.IQueryable<Cat_Sitter> ReadAll()
        {
            return this.repo.ReadAll();
        }

        public void Update(Cat_Sitter item)
        {
            if (this.repo.Read(item.ID) == null)
            {
                throw new ArgumentException($"We have not found any sitter with this ID: {item.ID}");
            }
            this.repo.Update(item);
        }

        public IEnumerable<string> CatHere(int item)
        {
            if (this.repo.Read(item) == null)
            {
                throw new ArgumentException($"We have not found any sitter with this ID: {item}");
            }
            var seged = this.repo.Read(item);

            return seged.Cats.Select(x => x.Cat_Name);

        }
    }
}
