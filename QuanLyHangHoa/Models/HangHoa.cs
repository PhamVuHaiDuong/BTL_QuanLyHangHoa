using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyHangHoa.Models
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public string MaHH { get; set; }
        public string TenHH { get; set; }
    }
}