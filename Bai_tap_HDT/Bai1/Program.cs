using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo();
            PhanSo b = new PhanSo();
            PhanSo c = new PhanSo();

            Console.WriteLine("Nhap phan so thu 1");
            a.Nhap();
            Console.WriteLine("Nhap phan so thu 2");
            b.Nhap();

            Console.WriteLine("\nTong hai phan so ");
            c = a.Cong(b);
            c.Xuat();

            Console.WriteLine("Hieu hai phan so ");
            c = a.Tru(b);
            c.Xuat();

            Console.WriteLine("Tich hai phan so ");
            c = a.Nhan(b);
            c.Xuat();

            Console.WriteLine("Thuong hai phan so ");
            c = a.Chia(b);
            c.Xuat();
        }
    }
}
