using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TH69LS_HFT_2023241.Logic;
using TH69LS_HFT_2023241.Models;
using TH69LS_HFT_2023241.Repository;

namespace TH69LS_HFT_2023241.Test
{
    [TestFixture]
    public class Tester
    {
        CatLogic catLogic;
        Cat_SitterLogic cat_SitterLogic;
        Cat_OwnerLogic cat_OwnerLogic;

        public Tester()
        {
            var MockCatRepo = new Mock<IRepository<Cat>>();
            catLogic = new CatLogic(MockCatRepo.Object);
            var MockSitterlRepo = new Mock<IRepository<Cat_Sitter>>();
            cat_SitterLogic = new Cat_SitterLogic(MockSitterlRepo.Object);
            var MockCat_OwnerRepo = new Mock<IRepository<Cat_Owner>>();
            cat_OwnerLogic = new Cat_OwnerLogic(MockCat_OwnerRepo.Object);

            
        }

    }
}
