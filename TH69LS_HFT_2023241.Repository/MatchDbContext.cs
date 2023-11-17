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
       public  DbSet<Match> Matches {  get; set; } 
       public  DbSet<Player> Players {  get; set; }
       public  DbSet<Team> Teams {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                string conn = @"Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\Match.mdf; Integrated Security = True";
                    builder.UseLazyLoadingProxies()
                    .UseInMemoryDatabase(conn);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasOne(x => x.Team)
                .WithMany(x => x.players)
                .HasForeignKey(x => x.TeamID)
                .OnDelete(DeleteBehavior.Cascade);


            
            


        }
     }
}
