using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DeptStudentApp.Models

{
    public class Student
    {
        public int Id { get; set; }
      
       
        [DisplayName("Student Name")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false)]
      
        [DisplayName(" Email")]
         [EmailAddress]
        public string Email{ get; set; }
        public string RegNo { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
       



    }
}