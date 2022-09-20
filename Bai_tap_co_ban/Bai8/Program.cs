// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

int n, check;
do
{
    Console.WriteLine("Nhap vao so nguyen n");
    n = int.Parse(Console.ReadLine());
} while (n<0||n>999);
Console.WriteLine("Cac so nguyen to tu 0 den "+n+" la");
for (int i = 2; i <= n; i++)
{
    check = 0;
    for(int j=2;j<i;j++)
    {
        if(i%j==0) check = 1;
        break;
    }
    if (check == 0) Console.Write(" " + i);
}