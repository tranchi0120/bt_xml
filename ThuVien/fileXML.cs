using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ThuVien
{
    class fileXML
    {
        static void  xuat(string[] args)
        {
            ThuVienLinQDataContext db = new ThuVienLinQDataContext();
            var nv = from n in db.NHANVIENs select n;
            foreach (NHANVIEN n in nv)
            {
                Console.WriteLine(n.manv);

            }

            XElement NHANVIEN = new XElement("NhanVien", from a in nv
                                                       select
                                                           new XElement("NhanVien",
                                                           new XElement("Id", a.manv),
                                                           new XElement("Name", a.tennv)));
            Console.WriteLine(NHANVIEN);
            Console.ReadKey();

        }
    }
}
