using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyHangHoa.Models
{
    [Table("KhoHang")]
    public class KhoHang
    {
        [Key]
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public string DonGia { get; set; }
        public string PhanLoai { get; set; }
    }
}