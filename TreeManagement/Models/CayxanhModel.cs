using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreeManagement.Models
{
    public class CayxanhModel
    {
        public string TenCay { get; set; }
        public int? Tuoi { get; set; }
        public string MoTaCay { get; set; }
        public string ViTri { get; set; }
        public string LoaiCay { get; set; }
        public string TrangThai { get; set; }
    }
    public class CayxanhVM : CayxanhModel 
    {
        public string MaCay { get; set; }
    }
}
