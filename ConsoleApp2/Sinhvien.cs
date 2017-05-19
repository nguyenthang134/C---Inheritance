using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Sinhvien : ConNguoi, HoatDongTichCuc
    {
        public void Docsach()
        {
            Console.WriteLine("Sinh vien doc sach");
        }

        public void HocTap()
        {
            Console.WriteLine("Sinh vien hoc tap");
        }

        public void Luyentapthethao()
        {
            Console.WriteLine("Sinh vien choi the thao");
        }

        public void Nghenhac()
        {
            Console.WriteLine("Sinh vien nghe nhac");
        }

        public void Uongcaphesang()
        {
            Console.WriteLine("Sinh vien uong cafe sang");
        }

        public override void sudungmaytinh()
        {
            Console.WriteLine("Sinh vien su dung may tinh");
        }

        private string masinhvien;
        private string lop;
        private string email;

        public Sinhvien() {
        }

        public Sinhvien(string Msv, string Lop, string Email)
        {
            masinhvien = Msv;
            lop = Lop;
            email = Email;
        }

        public string Masinhvien
        {
            get { return masinhvien; }
            set { masinhvien = value; }
        }

        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public new void gioithieu()
        {
            Sinhvien sinhvien = new Sinhvien();
            Console.WriteLine("Toi la " + Ten + " voi ma so la: " + masinhvien);
        }
    }
}


