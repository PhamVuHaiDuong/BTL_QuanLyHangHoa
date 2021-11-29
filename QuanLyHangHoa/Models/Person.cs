using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyHangHoa.Models
{
    [Table("People")]
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        public string FullName { get; set; }
    }
}