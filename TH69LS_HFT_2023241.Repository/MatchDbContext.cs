using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH69LS_HFT_2023241.Models;

namespace TH69LS_HFT_2023241.Repository
{
    internal class MatchDbContext:DbContext
    {
       public  DbSet<Match> matches {  get; set; } 
       public  DbSet<Player> player {  get; set; }
       public  DbSet<Team> team {  get; set; } 

    }
}
