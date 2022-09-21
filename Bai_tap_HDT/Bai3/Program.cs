using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLSV quanLySinhVien = new QLSV();

            while (true)
            {
                Console.WriteLine("\n**                QUAN LY SINH VIEN                  **");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them sinh vien.                               **");
                Console.WriteLine("**  2. Chinh sua thong tin sinh vien boi ID.         **");
                Console.WriteLine("**  3. Xoa sinh vien boi ID.                         **");
                Console.WriteLine("**  4. Sap xep sinh vien GP).                        **");
                Console.WriteLine("**  5. Sap xep sinh vien theo ten.                   **");
                Console.WriteLine("**  6. Hien thi danh sach sinh vien.                 **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Them sinh vien.");
                        quanLySinhVien.Nhap();
                        break;
                    case 2:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            string id;
                            Console.WriteLine("\n2. Chinh sua thong tin sinh vien. ");
                            Console.Write("\nNhap ID muon sua: ");
                            id = Console.ReadLine();
                            quanLySinhVien.EditSV(id);
                            Console.WriteLine("Sua thanh cong");
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                    case 3:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            string id;
                            Console.WriteLine("\n3. Xoa sinh vien.");
                            Console.Write("\nNhap ID: ");
                            id =Console.ReadLine();
                            if (quanLySinhVien.DeleteById(id))
                            {
                                Console.WriteLine("\nSinh vien co id = "+id+" da bi xoa.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                    case 4:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n4. Sap xep sinh vien theo GPA.");
                            quanLySinhVien.SortByGPA();
                            quanLySinhVien.Xuat();
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                    case 5:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n5. Sap xep sinh vien theo ten.");
                            quanLySinhVien.SortByName();
                            quanLySinhVien.Xuat();
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                    case 6:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n6. Hien thi danh sach sinh vien.");
                            quanLySinhVien.Xuat();
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                    case 0:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                        break;
                }
            }
        }
    }
}
