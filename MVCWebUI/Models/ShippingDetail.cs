using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebUI.Models
{
    public class ShippingDetail
    {
        //[Required(ErrorMessage ="İsim alanı zorunludur.")]
        public string FirstName { get; set; }
        //[Required(ErrorMessage = "Soyisim alanı zorunludur.")]
        public string LastName { get; set; }
        //[Required]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
       // [Required]
        public string City { get; set; }
        //[Required]
        //[MinLength(10,ErrorMessage ="Minimum 10 karakter uzunlugunda olmalı")]
        public string Address { get; set; }
        //[Required]
        //[Range(18,65)]
        public int Age { get; set; }
    }
}
