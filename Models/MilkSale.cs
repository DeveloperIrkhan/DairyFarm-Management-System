using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    
    [Table("MilkSale_Tbl")]
    public class MilkSale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]             
        public int MilkSale_Id { get; set; }
        //Customer Id
        
        [Required] 
        public int CustomerId { get; set; }
        //Customer Contact

        [Required] 
        public string CustomerPhoneNo { get; set; }
        [Required] 
        public string CustomerName { get; set; }

        //incharge Name
        [Required]
        public string WorkerId { get; set; }

        //Quantity of saled
        [Required]
        public string Quantity { get; set; }

        // Payment type paid or unpaid
        [Required] 
        public string PaymentMode  { get; set; }

        //Price (Per kg)
        [Required] 
        public string Price { get; set; }
        //Total (Monthly)
        [Required] 
        public string TotalSaled { get; set; }

        
        

    }
}
