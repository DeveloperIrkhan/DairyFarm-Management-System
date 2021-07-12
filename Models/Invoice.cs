using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Invoice
    {
        public int Invoice_Id  { get; set; }
        public DateTime Invoice_date { get; set; } = DateTime.Now;
        public int CostumerId { get; set; }
        public string CostumerName { get; set; }
        public string Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int Total { get; set; }
    }
}
