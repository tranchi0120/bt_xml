using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ThuVien
{
    class nhanvienBLL
    {
        nhanvienDAL dalSV;
        public nhanvienBLL()
        {
            dalSV = new nhanvienDAL();

        }
        public DataTable getALLnhanvien()
        {
            return dalSV.getALLnhanvien();
        }
        public bool Insertnhanvien(Nhanvien s)
        {
            return dalSV.Insertnhanvien(s);
        }
        public bool Updatenhanvien(Nhanvien s)
        {
            return dalSV.Updatenhanvien(s);
        }
        public bool DELETEnhanvien(Nhanvien s)
        {
            return dalSV.DELETEnhanvien(s);
        }
        public DataTable Findnhanvien(string s)
        {
            return dalSV.Findnhanvien(s);
        }
    }
}
