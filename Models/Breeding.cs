using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    [Table("Breeding_Tbl")]
    public class Breeding
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Breeding_Id { get; set; }
        
        [Required]
        public DateTime HeatingDate { get; set; }
        
        [Required] 
        public DateTime BreedingDate { get; set; }

        [Required] 
        public int EarTagNo { get; set; }

        [Required] 
        public string CowName { get; set; }

        [Required] 
        public string PregnancyDate { get; set; }

        [Required] 
        public string ExpireDateOfCalve { get; set; }

        [Required] 
        public string DateOfCalved { get; set; }
        
        [Required] 
        public string Remarks { get; set; }
    }
}
