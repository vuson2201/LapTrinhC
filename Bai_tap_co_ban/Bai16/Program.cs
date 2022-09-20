// See https://aka.ms/new-console-template for more information
string s1;
char c;
Console.WriteLine("Nhap vao 1 chuoi");
s1=Console.ReadLine();
Console.WriteLine("Nhap vao 1 ky tu");
c =char.Parse(Console.ReadLine());
Console.WriteLine("\nKet qua");
string s2 = c.ToString();
bool check = s1.Contains(s2);
if (check) Console.WriteLine("Co");
else Console.WriteLine("Khong");