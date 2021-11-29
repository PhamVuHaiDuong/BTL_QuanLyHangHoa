using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyHangHoa.Models
{
    public class Student : Person
    {
       public string School { get; set; }
       public string Address { get; set; }
    }
}