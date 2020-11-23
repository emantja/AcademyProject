using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Academy.Models
{
    public class Furnitor
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Required]
        [Display(Name = "Nipti")]
        public string nipt { get; set; }
        [Required]
        [Display(Name = "Website")]
        [DataType(DataType.Url)]
        public String website { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy HH:mm}",ApplyFormatInEditMode = true)]
        public DateTime dateSaved { get; set; }
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required]
        [Display(Name = "Adresa")]
        public string address { get; set; }
    }

}