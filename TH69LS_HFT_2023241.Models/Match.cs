using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;

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
        [Range(3, 5)]
        public int Outcome_winner { get; set; }
        public string Loser { get; set; }
        [Range(0, 3)]
        public int Outcome_loser { get; set; }
        [NotMapped]
        public virtual ICollection<Team> teams { get; set; }
        [NotMapped]
        [JsonIgnore]
        public virtual Team team { get; set; }


    }
}
