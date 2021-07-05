using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{

    [Table("Worker_Tbl")]
    class Worker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int WorkerId { get; set; }

        [Display(Name = "Worker Name")]
        [Required(ErrorMessage = "{0} required!!!")]
        public string WorkerName { get; set; }
        
        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "{0} required!!!")]
        public string Dob { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "{0} required!!!")] 
        public string Phone { get; set; }
        
        [Display(Name = "Upload Selfie")] 
        public string Picture { get; set; }
    }
}
