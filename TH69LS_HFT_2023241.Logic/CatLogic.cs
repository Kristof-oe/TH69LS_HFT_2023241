using System;
using System.Collections.Generic;
using System.Linq;
using TH69LS_HFT_2023241.Models;
using TH69LS_HFT_2023241.Repository;

namespace TH69LS_HFT_2023241.Logic
{
    public class CatLogic : ICatLogic
    {
        readonly IRepository<Cat> repo;

        public CatLogic(IRepository<Cat> repo)
        {
            this.repo = repo;
        }

        public void Create(Cat item)
        {
            if (item.Cat_Name == "")
            {
                throw new ArgumentException("You need to give a name for your cat");
            }
            this.repo.Create(item);
        }

        public void Delete(int ID)
        {
            if (this.repo.Read(ID) == null)
            {
                throw new ArgumentException($"We have not found any cat with this ID: {ID}");
            }
            this.repo.Delete(ID);
        }

        public Cat Read(int ID)
        {
            if (this.repo.Read(ID) == null)
            {
                throw new ArgumentException($"We have not found any cat with this ID: {ID}");
            }
            return this.repo.Read(ID);
        }

        public IQueryable<Cat> ReadAll()
        {
            return this.repo.ReadAll();
        }

        public void Update(Cat item)
        {
            if (this.repo.Read(item.ID) == null)
            {
                throw new ArgumentException($"We have not found any cat with this ID: {item}");
            }
            this.repo.Update(item);
        }
        public IEnumerable<Cat> Mixed()
        {
            return this.repo.ReadAll().Where(t => t.Is_Mixed == true).OrderBy(t => t.Cat_Name);
        }


        public IEnumerable<TopBreed> Top2Breed()
        {
            var q = from x in repo.ReadAll()
                    group x by x.Breed into g
                    select new TopBreed
                    {
                        Breed = g.Key,
                        Count = g.Count()
                    };
            return q.OrderByDescending(x => x.Count).Take(2).Distinct();
        }
    }

    public class TopBreed
    {
        public string Breed { get; set; }
        public int Count { get; set; }
    }
}
