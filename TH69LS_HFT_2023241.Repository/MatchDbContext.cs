using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TH69LS_HFT_2023241.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Formats.Asn1.AsnWriter;

namespace TH69LS_HFT_2023241.Repository
{
    internal class MatchDbContext:DbContext
    {
       public  DbSet<Cat_Owner> Cat_Owners {  get; set; } 
       public  DbSet<Cat> Cats {  get; set; }
       public  DbSet<Cat_Sitter> Cat_Sitters {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                string conn = @"Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\Cat.mdf; Integrated Security = True";
                    builder.UseLazyLoadingProxies()
                    .UseInMemoryDatabase(conn);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cat>()
                .HasOne(x => x.Cat_owner)
                .WithMany(x => x.Cats)
                .HasForeignKey(x => x.Cat_Owner_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Cat>()
                    .HasOne(x => x.Cat_sitter)
                    .WithMany(x => x.Cats)
                    .HasForeignKey(x => x.Cat_Sitter_ID)
                .OnDelete(DeleteBehavior.Cascade);

            //Cat_Owner

            var ToniKukoc = new Cat_Owner() { ID = 1, Owner_Name = "Toni Kukoc", Owner_Age = 21, Is_Married = true, Nationality = "Hungarian" };
            var LucLongley = new Cat_Owner() { ID = 2, Owner_Name = "Luc Longley", Owner_Age = 35, Is_Married = false, Nationality = "Afghan" };
            var DennisRodman = new Cat_Owner() { ID = 3, Owner_Name = "Dennis Rodman", Owner_Age = 47, Is_Married = true, Nationality = "Australian" };
            var MichaelJordan = new Cat_Owner() { ID = 4, Owner_Name = "Michael Jordan", Owner_Age = 52, Is_Married = false, Nationality = "Haitian" };
            var ScottiePippen = new Cat_Owner() { ID = 5, Owner_Name = "Scottie Pippen", Owner_Age = 98, Is_Married = true, Nationality = "Iraqi" };
            var RonHarper = new Cat_Owner() { ID = 6, Owner_Name = "Ron Harper", Owner_Age = 65, Is_Married = false, Nationality = "Irish" };
            var SteveKerr = new Cat_Owner() { ID = 7, Owner_Name = "Steve Kerr", Owner_Age = 27, Is_Married = true, Nationality = "Irish" };
            var MuggsyBogues = new Cat_Owner() { ID = 8, Owner_Name = "Muggsy Bogues", Owner_Age = 52, Is_Married = false, Nationality = "Australian" };
            var ScottBurrell = new Cat_Owner() { ID = 9, Owner_Name = "Scott Burrell", Owner_Age = 48, Is_Married = true, Nationality = "Haitian" };
            var TomChambers = new Cat_Owner() { ID = 10, Owner_Name = "Tom Chambers", Owner_Age = 36, Is_Married = false, Nationality = "Irish" };
            var DellCurry = new Cat_Owner() { ID = 11, Owner_Name = "Dell Curry", Owner_Age = 22, Is_Married = true, Nationality = "Indonesian" };

            modelBuilder.Entity<Cat_Owner>().HasData(ToniKukoc, LucLongley, DennisRodman, MichaelJordan, ScottiePippen, RonHarper, SteveKerr, MuggsyBogues, ScottBurrell, TomChambers, DellCurry);

            //Cat_sitter

            var AllanHouston = new Cat_Sitter() { ID = 1, Sitter_Name = "Allan Houston", Sitter_Age = 21, Its_salary_month = 156000, Is_professional = true };
            var ChrisJent = new Cat_Sitter() { ID = 2, Sitter_Name = "Chris Jent", Sitter_Age = 39, Its_salary_month = 210000, Is_professional = true };
            var LarryJohnson = new Cat_Sitter() { ID = 3, Sitter_Name = "Larry Johnson", Sitter_Age = 43, Its_salary_month = 300000, Is_professional = false };
            var PatrickEwing = new Cat_Sitter() { ID = 4, Sitter_Name = "Patrick Ewing", Sitter_Age = 31, Its_salary_month = 430000, Is_professional = false };
            var WalterMcCarty = new Cat_Sitter() { ID = 5, Sitter_Name = "Walter McCarty", Sitter_Age = 29, Its_salary_month = 390000, Is_professional = true };

            modelBuilder.Entity<Cat_Sitter>().HasData(AllanHouston, ChrisJent, LarryJohnson, PatrickEwing, WalterMcCarty);

        }
     }
}
