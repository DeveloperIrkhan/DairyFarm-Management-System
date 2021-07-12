using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    [Table("MilkProduction_Tbl")]
    public class MilkProduction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        
        [ForeignKey("EarTagNo")]
        public string EarTagno { get; set; }
        public string AM_Milk { get; set; }
        public string Noon_Milk { get; set; }
        public string PM_Milk { get; set; }
        public string Total_Milk { get; set; }
        public DateTime Date { get; set; }
        public string Attachment { get; set; }
        public virtual Cows Cows { get; set; }

    }
}
