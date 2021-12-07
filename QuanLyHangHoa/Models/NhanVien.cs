using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyHangHoa.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {  
        [Key]
        public string MaNV { get; set; }
        public string Username { get; set; }
        public string HoTen { get; set; }
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }
        [allowhtml]
        public string DiaChi { get; set; }
        public string CCCD { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "SĐT")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
              ErrorMessage = "Entered phone format is not valid.")]
        public string SĐT { get; set; }
        public string ChucVu { get; set; }
    }
}