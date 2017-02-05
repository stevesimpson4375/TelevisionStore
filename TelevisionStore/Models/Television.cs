using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TelevisionStore.Models
{
    public class Television
    {
        [Display(Name = "Television ID")]
        public int TelevisionId { get; set; }
        public String Manufacturer { get; set; }
        public int Size { get; set; }
        public decimal Price { get; set; }
    }
}