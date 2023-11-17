using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace TH69LS_HFT_2023241.Models
{
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(50)]
        [Required]
        public int Team_Name{ get; set; }
        public int Team_born_year { get; set; }
        [NotMapped]
        public virtual ICollection<Player> players { get; set; }  
        public virtual Player player { get; set; }
        [NotMapped]
        [JsonIgnore]
        public virtual ICollection<Match> matches { get; set; }
        public virtual Match match { get; set; }

    }
}
