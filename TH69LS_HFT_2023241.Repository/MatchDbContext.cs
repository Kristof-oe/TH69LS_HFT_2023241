using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TH69LS_HFT_2023241.Models;

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

            


        }
     }
}
