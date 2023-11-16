using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TH69LS_HFT_2023241.Models
{
    public class Match
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(50)]
        [Required]
        public string Match_Name { get; set; } 
        public DateTime Match_night { get; set; }
        public string Winner {  get; set; }
        public string Loser { get; set; }
        public int Outcome { get; set;}
        [NotMapped]
        public virtual ICollection<Team> teams { get; set; }
        public virtual Team team { get; set; }


    }
}
