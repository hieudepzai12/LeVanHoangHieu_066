using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class ChuNhat
    {
        private double _length;
        private double _width;
        public ChuNhat()
        {

        }
        public ChuNhat(double length, double width)
        {
            this._length = length;
            this._width = width;
        }
        public double Length
        {
            set { this._length = value; }
            get { return _length; }
        }
        public double Width
        {
            set { this._width = value; }
            get { return _width; }
        }
        public double TinhChuVi()
        {
            return (_length + _width) * 2;
        }
        public double TinhDienTich()
        {
            return _length * _width;
        }
        public void Xuat()
        {
            Console.WriteLine("Thong tin hinh chu nhat:");
            Console.WriteLine("Chu vi hinh chu nhat: {0}", TinhChuVi());
            Console.WriteLine("Dien tich hinh chu nhat: {0}", TinhDienTich());
        }
    }
        class Vuong: ChuNhat
        {
            private double canh;
            public Vuong()
            {

            }
            public Vuong(double canh)
            {
                this.canh = canh;
            }
            public double Canh
            {
                set { this.canh = value; }
                get { return canh; }
            }
            public double TinhChuVi()
            {
                return canh * 4;
            }
            public double TinhDienTich()
            {
                return canh * canh;
            }
            public void Xuat()
            {
            Console.WriteLine("Thong tin hinh vuong:");
            Console.WriteLine("Chu vi hinh vuong: {0}", TinhChuVi());
            Console.WriteLine("Dien tich hinh vuong: {0}", TinhDienTich());
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            ChuNhat chunhat = new ChuNhat();
            Console.WriteLine("Nhap chieu dai: ");
            chunhat.Length = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            chunhat.Width = double.Parse(Console.ReadLine());
            chunhat.Xuat();
            //Console.WriteLine("Thong tin hinh chu nhat:");
            //Console.WriteLine("Chu vi hinh chu nhat: {0}", chunhat.TinhChuVi());
            //Console.WriteLine("Dien tich hinh chu nhat: {0}", chunhat.TinhDienTich());

            Vuong vuong = new Vuong();
            Console.WriteLine("Nhap canh: ");
            vuong.Canh = double.Parse(Console.ReadLine());
            vuong.Xuat();
            //Console.WriteLine("Thong tin hinh vuong:");
            //Console.WriteLine("Chu vi hinh vuong: {0}", vuong.TinhChuVi());
            //Console.WriteLine("Dien tich hinh vuong: {0}", vuong.TinhDienTich());

            Console.ReadKey();
        }
    }
}
