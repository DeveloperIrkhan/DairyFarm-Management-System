using Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    [Table("Cow_Tbl")]
    public class Cows
    {
        public Cows()
        {
            MilkProductions = new HashSet<MilkProduction>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EarTagNo{ get; set; }
        
        [Display(Name = "CowName")]
        public string Name { get; set; }

        [Display(Name = "Color")] 
        public string Color { get; set; }
        [Display(Name = "Bread")] 
        public string Bread { get; set; }
        [Display(Name = "Type")] 
        public CowType Type { get; set; }
        [Display(Name = "BirthDate")] 
        public string Dob { get; set; }
        [Display(Name = "Age")] 
        public string Age { get; set; }
        [Display(Name = "Weight")] 
        public string WeightAtBirth { get; set; }
        [Display(Name = "Picture")] 
        public string Picture { get; set; }

        public ICollection<MilkProduction> MilkProductions { get; set; }
    }
}
