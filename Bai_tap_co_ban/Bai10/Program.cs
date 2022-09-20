// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using System;

string[] MSSV = new string[5];
for(int i=0;i<5;i++)
{
    Console.WriteLine("Nhap ma so sinh vien thu "+(i+1));
    MSSV[i] = Console.ReadLine();
}
string pattern = @"B170\d{4}";
for(int i = 0; i < 5; i++)
{
    Match result = Regex.Match(MSSV[i], pattern);
    if (result.Success) Console.WriteLine("MSSV thu "+(i+1)+" hop le");
    else Console.WriteLine("MSSV thu "+(i+1)+" khong hop le");
}