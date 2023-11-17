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
    public class Cat_Sitter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(50)]
        [Required]
        public string Sitter_Name { get; set; }
        [Range(20,45)]
        public int Sitter_Age { get; set;}
        [Range(150000,450000)]
        public int Its_salary_month { get; set; }
        public bool Is_professional { get; set; }
        [JsonIgnore]
        [NotMapped]
        public virtual ICollection<Cat> Cats { get; set; }

    }
}
