using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WingHerryTask.Models
{
    public class User
    {
            [Key]
            public int Id { get; set; }  

            [Required(ErrorMessage = "Name is required.")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Email is required.")]
            [EmailAddress(ErrorMessage = "Invalid Email Address.")]
            [RegularExpression(@"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,6}$", ErrorMessage = "Invalid Email Address.")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Mobile No is required.")]
            [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile No should be number and 10 digits only.")]
            [MinLength(10, ErrorMessage = "Mobile No should be number and 10 digits only.")]
            [MaxLength(10, ErrorMessage = "Mobile No should be number and 10 digits only.")]
            public string MobileNo { get; set; }

            [Required(ErrorMessage = "Address is required.")]
            public string Address { get; set; }

            [Required(ErrorMessage = "Gender is required.")]
            public string Gender { get; set; }  // Will hold values like "Male" or "Female"
        

    }
}