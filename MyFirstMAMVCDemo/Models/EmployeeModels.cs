using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFirstMAMVCDemo.Models
{
    public class EmployeeModels
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="This field is required, Please fiil this!!")]
        [Display(Name ="User Name")]
        [MaxLength(10,ErrorMessage ="Please enter max 10 charactors")]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailId { get; set; }

        public string Password { get; set; }

        //[StringLength(30,ErrorMessage ="")]
        public string Gender { get; set; }
        public bool IsApproved { get; set; }

        [Range(100,400,ErrorMessage ="Please enter propper")]
        public int Age { get; set; }
    }
}