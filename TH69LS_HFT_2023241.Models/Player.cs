using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TH69LS_HFT_2023241.Models
{
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(50)]
        [Required]
        public string Player_Name { get; set; }
        [Range(0,100)]
        public int Player_Stat { get; set; }
        [Range(180, 250)]
        public int Player_Height { get; set; }
        public int TeamID { get; set; }
        [JsonIgnore]
        [NotMapped]
        public virtual ICollection<Team> teams { get; set; }
        public virtual Team Team { get; set; }


    }
}
