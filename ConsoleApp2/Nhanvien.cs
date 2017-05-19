using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Nhanvien : ConNguoi, HoatDongTieuCuc
    {
        private string manhanvien;
        private string phongban;
        private double mucluong;

        public string Manhanvien
        {
            get { return manhanvien; }
            set { manhanvien = value; }
        }

        public string Phongban
        {
            get { return phongban; }
            set { phongban = value; }
        }
        
        public double Mucluong
        {
            get { return mucluong; }
            set { mucluong = value; }
        }

        public void Choicobac()
        {
            Console.WriteLine("Nhan vien choi co bac");
        }

        public void Hutthuoc()
        {
            Console.WriteLine("Nhan vien hut thuoc");
        }

        public override void sudungmaytinh()
        {
            Console.WriteLine("Nhan vien su dung may tinh");
        }

        public void Uongruou()
        {
            Console.WriteLine("Nhan vien choi uong ruou");
        }

        public Nhanvien() { }

        public Nhanvien(string Manhanvien, string Phongban, double Mucluong)
        {
            manhanvien = Manhanvien;
            phongban = Phongban;
            mucluong = Mucluong;
        }

        public new void gioithieu()
        {
            Nhanvien nhanvien = new Nhanvien();
            Console.WriteLine("Toi la " + Ten + ", toi la nhan vien phong " +Phongban + " voi ma so la " + Manhanvien);
        }
    }
}
