using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UMSWebbAPP.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Address { get; set; }



    }
}