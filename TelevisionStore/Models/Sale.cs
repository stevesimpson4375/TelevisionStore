using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelevisionStore.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int EmployeeId { get; set; }
        public decimal TotalPrice { get; set; }
        public String PaymentMethod { get; set; }
    }
}