using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class PhanSo
    {
        public int tu;
        public int mau;
        public PhanSo() { }
        public PhanSo(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public PhanSo Cong(PhanSo a)
        {
            int ts = tu * a.mau + mau * a.tu;
            int ms = a.mau * mau;
            PhanSo p = new PhanSo(ts,ms);
            return p;
        }
        public PhanSo Tru(PhanSo a)
        {
            int ts = tu * a.mau - mau * a.tu;
            int ms = a.mau * mau;
            PhanSo p = new PhanSo(ts, ms);
            return p;
        }
        public PhanSo Nhan(PhanSo a)
        {
            int ts = tu * a.tu;
            int ms = a.mau * mau;
            PhanSo p = new PhanSo(ts, ms);
            return p;
        }
        public PhanSo Chia(PhanSo a)
        {
            int ts = tu * a.mau;
            int ms = mau* a.tu;
            PhanSo p = new PhanSo(ts, ms);
            return p;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap tu so");
            tu = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so");
            mau = int.Parse(Console.ReadLine());
        }
        public void Xuat()

        {
            int ts = tu;
            int ms = mau;
            while (tu != mau)
            {
                if (tu > mau) tu = tu - mau;
                else mau = mau - tu;
            }
            ts = ts / tu;
            ms = ms / tu;
            Console.WriteLine(ts + "/" + ms);
        }
    }
}
