using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TelevisionStore.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }
        [Display(Name = "Total Price")]
        public decimal TotalPrice { get; set; }
        [Display(Name = "Payment Method")]
        public String PaymentMethod { get; set; }
    }
}