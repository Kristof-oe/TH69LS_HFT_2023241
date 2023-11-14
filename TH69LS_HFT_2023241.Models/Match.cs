using System;

namespace TH69LS_HFT_2023241.Models
{
    public class Match
    {
        int Match_ID {  get; set; }
        public DateTime Match_night { get; set; }

        public string Winner {  get; set; } 
        public string Loser { get; set; }

        public int Outcome { get; set;}

        public int Best_player_stat { get; set; }


    }
}
