using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class TestCandidate
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap n");
            n = int.Parse(Console.ReadLine());
            Candidate[] DS = new Candidate[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("\nNhap sinh vien thu " + (i + 1));
                DS[i] = new Candidate();
                DS[i].Nhap();
            }
            Console.WriteLine("\nDanh sach sinh vien co tong diem lon hon 10");
            Console.WriteLine("Ma\tTen\tNS\tToan\tVan\tAnh");
            for (int i = 0; i < n; i++)
            {
                DS[i].Xuat();
            }
        }
    }
}
