using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFirstMAMVCDemo.Models
{
    public class UserModels
    {
        
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public bool isActive { get; set; }

        [Required]
        public string Gender { get; set; }
    }

    public class EmpModels
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
    }
}