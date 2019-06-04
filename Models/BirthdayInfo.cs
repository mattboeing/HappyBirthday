using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HappyBirthday.Models
{
    public class BirthdayInfo
    {
        [Required(ErrorMessage="Please enter your name")]
        public string FromName { get; set; }
        [Required(ErrorMessage="Please enter recipient's name")]
        public string ToName { get; set; }
        [Required(ErrorMessage="Please enter a message")]
        public string Message { get; set; }
    }
}