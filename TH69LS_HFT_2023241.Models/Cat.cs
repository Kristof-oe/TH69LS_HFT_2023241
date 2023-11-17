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
    public class Cat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(50)]
        public string Breed { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        public bool Is_Mixed { get; set; }
        public int Cat_Owner_ID { get; set; }
        public int Cat_Sitter_ID { get; set; }
        [NotMapped]
        public virtual Cat_Sitter Cat_sitter { get; set; }
        [JsonIgnore]
        [NotMapped]
        public virtual Cat_Owner Cat_owner { get; set; }



    }
}
