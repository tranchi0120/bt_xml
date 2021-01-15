using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ThuVien
{
    class docgiaBLL
    {
        docgiaDAL dalSV;
        public docgiaBLL()
        {
            dalSV = new docgiaDAL();

        }
        public DataTable getALLdocgia()
        {
            return dalSV.getALLdocgia();
        }
        public bool Insertdocgia(Docgia a)
        {
            return dalSV.Insertdocgia(a);
        }
        public bool Updatedocgia(Docgia a)
        {
            return dalSV.Updatedocgia(a);
        }
        public bool DELETEdocgia(Docgia a)
        {
            return dalSV.DELETEdocgia(a);
        }
        public DataTable Finddocgia(string a)
        {
            return dalSV.Finddocgia(a);
        }
    }
}
