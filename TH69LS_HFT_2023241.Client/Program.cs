using NuGet.Packaging.Signing;
using System;
using System.Linq;
using TH69LS_HFT_2023241.Logic;
using TH69LS_HFT_2023241.Models;
using TH69LS_HFT_2023241.Repository;
using TH69LS_HFT_2023241.Repository.Repository;

namespace TH69LS_HFT_2023241.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IRepository<Cat_Owner> repo = new Cat_OwnerRepository(new CatDbContext());

            //var item=repo.ReadAll().ToArray();
            var ctx=new CatDbContext();
            var repo = new CatRepository(ctx);
            var logic=new CatLogic(repo);

            var item = logic.ReadAll();

            var nc = logic.Mixed().ToArray();
            var pc=logic.Top3Breed().ToArray();
            ;
        }
    }
}
