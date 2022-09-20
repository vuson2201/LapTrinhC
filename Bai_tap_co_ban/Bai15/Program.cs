// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string[] MSSV = new string[5];
string pattern = @"00[2-5]L\d{4}";
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Nhap ma so nguoi dung thu " + (i + 1));
    MSSV[i] = Console.ReadLine();
    Match result = Regex.Match(MSSV[i], pattern);
    if (result.Success) Console.WriteLine("Dung roi");
    else
    {
        Console.WriteLine("Sai roi");
        break;
    }
}
