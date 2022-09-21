using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Candidate
    {
		public string Ma { get; set; }
        public string Ten { get; set; } 
        public string Ns { get; set; }
        public float Toan { get; set; }
        public float Van { get; set; }
        public float Anh { get; set; }
        public void Nhap()
        {
            Console.WriteLine("Nhap ma thi sinh");
            Ma = Console.ReadLine();
            Console.WriteLine("Nhap ten thi sinh");
            Ten = Console.ReadLine();
            Console.WriteLine("Nhap ngay thang nam sinh thi sinh");
            Ns = Console.ReadLine();
            Console.WriteLine("Nhap diem Toan thi sinh");
            Toan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem Van thi sinh");
            Van = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem Anh thi sinh");
            Anh = float.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            if(Tong()>10)
            Console.WriteLine(Ma + "\t" + Ten + "\t" + Ns + "\t" + Toan + "\t" + Van + "\t" + Anh);
        }
        public float Tong()
        {
            return Toan + Van + Anh;
        }
    }
}
