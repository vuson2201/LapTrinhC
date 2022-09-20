// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string s1;
Console.WriteLine("Nhap vao 1 chuoi");
s1 = Console.ReadLine();
string s2 = @".*\d.*";
Console.WriteLine("\nKet qua");
Match result = Regex.Match(s1, s2);
if (result.Success) Console.WriteLine("Co");
else Console.WriteLine("Khong");