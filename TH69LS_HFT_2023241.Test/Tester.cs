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

            List<Cat_Owner> cowners = new List<Cat_Owner>()
            {
                new Cat_Owner()
                 {
                ID = 1,
                Owner_Name = "Eva",
                Owner_Age = 70,
                Is_Married = true,
                Nationality="Urugvay"

                 },
                new Cat_Owner()
                {
                 ID = 2,
                Owner_Name = "Johhny",
                Owner_Age = 54,
                Is_Married = false,
                Nationality="Hungary"
                },
                new Cat_Owner()
                {
                ID = 3,
                Owner_Name = "Adam",
                Owner_Age = 23,
                Is_Married = true,
                Nationality="German"
                }
            };


            List<Cat_Sitter> catsitter = new List<Cat_Sitter>()
            {
                new Cat_Sitter()
                {
                ID = 1,
                Sitter_Name = "Károly",
                Sitter_Age =35,
                Its_salary_month = 190000,
                Is_professional=true,
                },
                new Cat_Sitter()
                {
                 ID = 2,
                Sitter_Name = "Áron",
                Sitter_Age =20,
                Its_salary_month = 310000,
                Is_professional=false,
                }
            };

            List<Cat> dogs = new List<Cat>()
            {
                new Cat()
                {
                 ID=1,
                 Cat_Owner_ID=1,
                 Cat_Sitter_ID=1,
                 Cat_Name="Cirmos",
                 Breed="Siamese"
                },
                new Cat()
                {
                 ID=2,
                 Cat_Owner_ID=2,
                 Cat_Sitter_ID=1,
                 Cat_Name="Kázmér",
                 Breed="Burmese"
                },
                new Cat()
                {
                  ID=3,
                 Cat_Owner_ID=2,
                 Cat_Sitter_ID=2,
                 Cat_Name="Pötyi",
                 Breed="Sphynx"
                },
                new Cat()
                {
                ID=4,
                 Cat_Owner_ID=2,
                 Cat_Sitter_ID=2,
                 Cat_Name="Álmos",
                 Breed="Persian"
                }
            };

        }

    }
}
