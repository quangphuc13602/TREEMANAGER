using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeManagement.Entities;
using TreeManagement.Models;

namespace TreeManagement.Services
{
    public class CayxanhRepository : ICayxanhRepository
    {
        private readonly QLCayxanhContext _context;
        public CayxanhRepository(QLCayxanhContext context)
        {
            _context = context;
        }
        public void Add(CayxanhModel cayxanhModel)
        {
            throw new NotImplementedException();
        }

        public List<CayxanhModel> GetAll()
        {
            var cayxanh = _context.CayXanhs.Select(cx => new CayxanhModel
            {
                TenCay = cx.TenCay,
                Tuoi = cx.Tuoi,
                MoTaCay = cx.MoTaCay,
                ViTri = cx.ViTri,
                LoaiCay = cx.LoaiCay,
                TrangThai = cx.TrangThai
            });
            return cayxanh.ToList();
        }

        public CayxanhModel GetbyCommune(string commune)
        {
            throw new NotImplementedException();
        }

        public CayxanhModel GetbyDistrict(string district)
        {
            throw new NotImplementedException();
        }

        public CayxanhVM Getbyid(string id)
        {
            throw new NotImplementedException();
        }

        public CayxanhModel GetbyStreet(string streetName)
        {
            throw new NotImplementedException();
        }

        public List<CayxanhModel> Search(string keywork)
        {
            throw new NotImplementedException();
        }
    }
}
