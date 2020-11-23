using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Academy.Models
{
    public class Produkt
    {
        [Key]
        public int productId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        
        [Display(Name = " Furnitori")]
        public virtual Furnitor furnitors { get; set; }
        [Display(Name = " Furnitori")]
        public int FurnitorId { get; set; }
        [Required]
        [Display(Name = "Sasia")]
        public int QuantityPerUnit { get; set; }
        [Required]
        [Display(Name = "Cmimi")]
        public int UnitPrice { get; set; }


    }
}