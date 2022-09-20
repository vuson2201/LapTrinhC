// See https://aka.ms/new-console-template for more information
int n;
int tong = 0;
Console.WriteLine("Nhap vao so nguyen duong n");
n=int.Parse(Console.ReadLine());
for (int i = 0; i <= n; i++)
{
    if (i % 2 == 0) tong=tong+i;
}
Console.WriteLine("Tong = " + tong);