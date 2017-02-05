using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TelevisionStore.Models
{
    public class ItemList
    {
        [Display(Name = "Item List ID")]
        public int ItemListId { get; set; }
        [Display(Name = "Sale ID")]
        public int SaleId { get; set; }
        [Display(Name = "Television ID")]
        public int TelevisionId { get; set; }
    }
}