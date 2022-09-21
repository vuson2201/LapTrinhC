using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai3
{
    internal class QLSV
    {
        public List<SinhVien> list = new List<SinhVien>();
        public void Nhap()
        {
            SinhVien sv = new SinhVien();
            Console.WriteLine("Nhap ID");
            sv.Id = Console.ReadLine();
            Console.WriteLine("Nhap Name");
            sv.Name = Console.ReadLine();
            Console.WriteLine("Nhap Age");
            sv.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Address");
            sv.Address = Console.ReadLine();
            Console.WriteLine("Nhap GPA");
            sv.Gpa = float.Parse(Console.ReadLine());
            list.Add(sv);
        }
        public void Xuat()
        {
            Console.WriteLine("Id\tName\tAge\tAddress\tGpa");
            foreach (SinhVien sv in list)
            {
                Console.WriteLine(sv.Id + "\t" + sv.Name + "\t" + sv.Age + "\t" + sv.Address + "\t" + sv.Gpa);
            } 
        }
        public SinhVien FindByID(string ID)
        {
            SinhVien searchResult = null;
            if (list != null && list.Count > 0)
            {
                foreach (SinhVien sv in list)
                {
                    if (sv.Id == ID)
                    {
                        searchResult = sv;
                    }
                }
            }
            return searchResult;
        }
        public void EditSV(string ID)
        {

            SinhVien sv = FindByID(ID);
            if (sv != null)
            {
                Console.WriteLine("Nhap ID");
                sv.Id = Console.ReadLine();
                Console.WriteLine("Nhap Name");
                sv.Name = Console.ReadLine();
                Console.WriteLine("Nhap Age");
                sv.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap Address");
                sv.Address = Console.ReadLine();
                Console.WriteLine("Nhap GPA");
                sv.Gpa = float.Parse(Console.ReadLine());
            }
             else Console.WriteLine("Sinh vien co ID = "+ID+" khong ton tai.");
        }
        public bool DeleteById(string ID)
        {
            bool IsDeleted = false;
            SinhVien sv = FindByID(ID);
            if (sv != null)
            {
                IsDeleted = list.Remove(sv);
            }
            return IsDeleted;
        }
        public void SortByName()
        {
            list.Sort(delegate (SinhVien sv1, SinhVien sv2) {
                return sv1.Name.CompareTo(sv2.Name);
            });
        }
        public void SortByGPA()
        {
            list.Sort(delegate (SinhVien sv1, SinhVien sv2) {
                return sv1.Gpa.CompareTo(sv2.Gpa);
            });
        }
        public int SoLuongSinhVien()
        {
            int Count = 0;
            if (list != null)
            {
                Count = list.Count;
            }
            return Count;
        }
    }
}
