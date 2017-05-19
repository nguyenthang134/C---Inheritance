using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class ConNguoi
    {
        private string ten;
        private string ngaysinh;
        private int gioitinh;
        private string diachi;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
         public string Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public int Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public void an()
        {

        }

        public void ngu()
        {

        }

        public void chay()
        {

        }
        public void choi()
        {

        }
        public void gioithieu()
        {

        }

        public abstract void sudungmaytinh();

    }
}
