using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeManagement.Models;

namespace TreeManagement.Services
{
    public interface ICayxanhRepository
    {
        List<CayxanhModel> GetAll();
        CayxanhVM Getbyid(string id);
        CayxanhModel GetbyStreet(string streetName);
        CayxanhModel GetbyCommune(string commune);
        CayxanhModel GetbyDistrict(string district);
        List<CayxanhModel> Search(string keywork);
        void Add(CayxanhModel cayxanhModel);
        
    }
}
