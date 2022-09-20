// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using System;

string MSSV;
Console.WriteLine("Nhap ma so sinh vien");
MSSV = Console.ReadLine();
string pattern = @"B\d{7}";
Match result = Regex.Match(MSSV, pattern);
if (result.Success) Console.WriteLine("Hop le");
else Console.WriteLine("Khong hop le");