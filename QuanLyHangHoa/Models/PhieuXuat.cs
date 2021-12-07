using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyHangHoa.Models
{
    [Table("PhieuXuat")]
    public class PhieuXuat
    {
        [Key]
        public string MaPX { get; set; }
        public string MaSP { get; set; }
        public string SoLuongXuat { get; set; }
        public string DonGia { get; set; }
        public string ThanhTien { get; set; }
        public string MaNCC { get; set; }
        [DataType(DataType.Date)]
        public DateTime NgayTaoPhieu { get; set; }
    }
}