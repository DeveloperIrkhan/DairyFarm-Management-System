using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    [Table("Medication_Tbl")]class Medication
    {
        [Display(Name = "Ear Tag No")]
        [Required(ErrorMessage = "{0} required!!!")]
        public int EarTagNo { get; set; }
        
        [Display(Name = "Cow Name")]
        [Required(ErrorMessage = "{0} required!!!")] 
        public string CowName { get; set; }
        
        [Display(Name = "Event")]
        [Required(ErrorMessage = "{0} required!!!")] 
        public string Event { get; set; }
        
        [Display(Name = "Today's date")]
        [Required(ErrorMessage = "{0} required!!!")] 
        public DateTime Dated { get; set; } = DateTime.Now.Date;

        [Display(Name = "Treatment")]
        [Required(ErrorMessage = "{0} required!!!")] 
        public string Treatment { get; set; }
        
        [Display(Name = "Treatment Cost")]
        [Required(ErrorMessage = "{0} required!!!")] 
        public string TreatmentCost { get; set; }

        [Display(Name = "Doctor Name")]
        [Required(ErrorMessage = "{0} required!!!")] 
        public string DoctorName { get; set; }
        
        [Display(Name = "Picture")]
        [Required(ErrorMessage = "{0} required!!!")] 
        public string Attachment { get; set; }
    }
}
