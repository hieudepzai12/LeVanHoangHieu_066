using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class SinhVien
    {
        private string Hoten;
        private double DiemToan;
        private double DiemVan;
        private double DiemNgoaiNgu;
        private string KhoiHoc;
        
        public SinhVien()
        {

        }
        public SinhVien(string Hoten, double DiemToan, double DiemVan, double DiemNgoaiNgu, string KhoiHoc)
        {
            this.Hoten = Hoten;
            this.DiemToan = DiemToan;
            this.DiemVan = DiemVan;
            this.DiemNgoaiNgu = DiemNgoaiNgu;
            this.KhoiHoc = KhoiHoc;
        }
        public string HoTen
        {
            set { this.Hoten = value; }
            get { return Hoten; }
        }
        public double diemToan
        {
            set { this.DiemToan = value; }
            get { return DiemToan; }
        }
        public double diemVan
        {
            set { this.DiemVan = value; }
            get { return DiemVan; }
        }
        public double diemNgoaiNgu
        {
            set { this.DiemNgoaiNgu= value; }
            get { return DiemNgoaiNgu; }
        }
        public string khoiHoc
        {
            set { this.KhoiHoc = value; }
            get { return KhoiHoc; }
        }
        public double TinhTrungBinh()
        {
            double heso = 1;
            switch (KhoiHoc)
            {
                case "A":
                    heso = 2;
                    break;
                case "D":
                    heso = 2;
                    break;
                case "C":
                    heso = 2;
                    break;
            }
            return (DiemToan * heso + DiemVan * heso + heso * DiemNgoaiNgu) / (3 * heso);
        }
        public string TinhXepLoai()
        {
            if (TinhTrungBinh() >= 5)
            {
                return "Duoc len lop";
            }
            else
            {
                return "Luu ban";
            }
        }
        public void InThongTin()
        {
            Console.WriteLine("Ho ten sinh vien: {0}", Hoten);
            Console.WriteLine("Diem trung binh: {0}", TinhTrungBinh());
            Console.WriteLine(" Xep loai: {0}", TinhXepLoai());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();

            Console.WriteLine("Nhap ho ten sinh vien: ");
            sv1.HoTen = Console.ReadLine();
            Console.WriteLine(" Nhap diem toan: ");
            sv1.diemToan = double.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap diem van: ");
            sv1.diemVan = double.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap diem ngoai ngu: ");
            sv1.diemNgoaiNgu = double.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap khoi Hoc: ");
            //sv1.khoiHoc = Console.ReadLine();
            //Console.WriteLine("Thong tin sinh vien 1: ");
            sv1.InThongTin();
            SinhVien sv2 = new SinhVien("Nguyen Van A", 7, 5, 4, "A");
            Console.WriteLine("Thong tin sinh vien 2:");
            sv2.InThongTin();
            Console.ReadLine();

        }
    }
}
