using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyHangHoa.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [Required(ErrorMessage ="Username is Required")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Password is Required")]
        [DataType (DataType.Password)]
        public string Password { get; set; }
    }
}