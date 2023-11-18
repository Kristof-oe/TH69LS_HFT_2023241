using System.Collections.Generic;
using System.Linq;
using TH69LS_HFT_2023241.Models;

namespace TH69LS_HFT_2023241.Logic
{
    public interface ICatLogic
    {
        IEnumerable<string> AllCatBreed();
        void Create(Cat item);
        void Delete(int ID);
        Cat Read(int ID);
        IQueryable<Cat> ReadAll();
        IEnumerable<TopBreed> Top3Breed();
        void Update(Cat item);
    }
}