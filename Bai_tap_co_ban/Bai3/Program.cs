// See https://aka.ms/new-console-template for more information
float a, b, c;
Console.WriteLine("Nhap lan luot 3 so thuc");
a = float.Parse(Console.ReadLine());
b = float.Parse(Console.ReadLine());
c = float.Parse(Console.ReadLine());
if (a + b > c && a + c > b && b + c > a) Console.WriteLine("3 so tren la 3 canh cua 1 tam giac");
else Console.WriteLine("3 so tren khong phai 3 canh cua 1 tam giac");