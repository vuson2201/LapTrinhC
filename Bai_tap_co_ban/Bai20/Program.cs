// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string s1;
Console.WriteLine("Nhap vao 1 chuoi");
s1 = Console.ReadLine();
string pattern = @"^[A-Z][\S]{0,18}\d$";
Match result = Regex.Match(s1, pattern);
if (result.Success) Console.WriteLine("Duyet");
else Console.WriteLine("Khong duyet");