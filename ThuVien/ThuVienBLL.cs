using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ThuVien
{
    class ThuVienBLL
    {
        thuvienDAL dalSV;
        public ThuVienBLL()
        {
            dalSV = new thuvienDAL();

        }
        public DataTable getALLsach()
        {
            return dalSV.getALLsach();
        }
        public bool Insertsach(Tvien s)
        {
            return dalSV.Insertsach(s);
        }
        public bool Updatesach(Tvien s)
        {
            return dalSV.Updatesach(s);
        }
        public bool DELETEsach(Tvien s)
        {
            return dalSV.DELETEsach(s);
        }
        public DataTable Findsach(string s)
        {
            return dalSV.Findsach(s);
        }
    }
}

