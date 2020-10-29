using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTH3_4.TH4
{
    class NhanVien
    {
        private string hoten, quequan;
        private double hesoluong;
        private static int luongcoban = 1050;

        public NhanVien()
        {
            hoten = quequan = "";
            hesoluong = 1.25;
        }

        public NhanVien(string hoten, string quequan, double hesoluong)
        {
            this.hoten = hoten;
            this.quequan = quequan;
            this.hesoluong = hesoluong;
        }

        public static int Luongcoban
        {
            get
            {
                return luongcoban;
            }
            set
            {
                if (value > 1050) luongcoban = value;
            }
        }

        public double Hesoluong
        {
            get
            {
                return hesoluong;
            }
        }

        public string Hoten
        {
            get
            {
                int n = hoten.LastIndexOf(" ");
                return hoten.Substring(n + 1) + " " + hoten.Substring(0, n);
            }
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap que quan: ");
            quequan = Console.ReadLine();
            Console.Write("Nhap he so luong: ");
            hesoluong = double.Parse(Console.ReadLine());
        }

        public virtual double TinhLuong()
        {
            return hesoluong * luongcoban;
        }
        public virtual void Hien()
        {
            Console.WriteLine("Ho ten: " + hoten);
            Console.WriteLine("Que quan: " + quequan);
            Console.WriteLine("He so luong: " + hesoluong);
        }

    }

    class QLNV
    {
        private NhanVien[] ds;
        private int snv;
        public void Nhap()
        {
            Console.Write("Nhap so nhan vien: ");
            snv = int.Parse(Console.ReadLine());
            ds = new NhanVien[snv];
            for (int i = 0; i < snv; i++)
            {
                ds[i] = new NhanVien();
                ds[i].Nhap();
            }
        }

        public void Hien()
        {
            for (int i = 0; i < snv; i++)
                ds[i].Hien();
        }