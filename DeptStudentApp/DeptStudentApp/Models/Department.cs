using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DeptStudentApp.Models
{
    public class Department
    {
        public int Id { get; set; }
    
         [Required(ErrorMessage = "enter Dept code")]
         [DisplayName("Department Code")]
        public string DeptCode { get; set; }
      
         [Required(ErrorMessage = "enter Dept name")]
         [DisplayName("Department Name")]
        public string DeptName { get; set; }
        public virtual ICollection<Student> Students { get; set; }


    }
}