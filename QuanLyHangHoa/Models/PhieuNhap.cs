using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyHangHoa.Models
{
    [Table("PhieuNhap")]
    public class PhieuNhap
    {
        [Key]
        public string MaPN { get; set; }
        public string MaSP { get; set; }
        public int SoLuongNhap { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get{ return SoLuongNhap * DonGia; } }
        public string MaNCC { get; set; }
        [DataType(DataType.Date)]
        public DateTime NgayTaoPhieu { get; set; }
    }
}