using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Run
    {
        static void Main(string[] args)
        {
            Sinhvien sinhvien1 = new Sinhvien();
            sinhvien1.Docsach();
            sinhvien1.Nghenhac();
            sinhvien1.Luyentapthethao();
            sinhvien1.HocTap();
            sinhvien1.Uongcaphesang();
            sinhvien1.Ten = "Ngoc";
            sinhvien1.Masinhvien = "1";
            sinhvien1.Lop = "C1608L";
            sinhvien1.Email = "ngoc@gmail.com";
            sinhvien1.gioithieu();
            Sinhvien sinhvien2 = new Sinhvien("2","C1608L","thang@gmail.com");
            sinhvien2.Ten = "Thang";
            sinhvien2.gioithieu();
            Nhanvien nhanvien1 = new Nhanvien();
            nhanvien1.Manhanvien = "123A";
            nhanvien1.Choicobac();
            nhanvien1.Uongruou();
            nhanvien1.Hutthuoc();
            nhanvien1.Ten = "Minh";
            nhanvien1.Manhanvien = "123A";
            nhanvien1.Phongban = "Hanh chinh";
            nhanvien1.Mucluong = 7.0;
            nhanvien1.gioithieu();
            Nhanvien nhanvien2 = new Nhanvien("123B","Dinh gia",5.5);
            nhanvien2.Ten = "Tu";
            nhanvien2.gioithieu();
            Console.ReadKey();
        }
    }
}
