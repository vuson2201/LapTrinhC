// See https://aka.ms/new-console-template for more information
int n;
Console.WriteLine("Nhap vao so nguyen n");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Ket qua");
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(n+" * "+i+" = " + n*i);
}