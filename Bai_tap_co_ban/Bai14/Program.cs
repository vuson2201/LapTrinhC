// See https://aka.ms/new-console-template for more information
int n;
Console.WriteLine("Nhap n");
n = int.Parse(Console.ReadLine());

int[] a = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Nhap so thu " + (i + 1));
    a[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Mang ban dau");
for (int i = 0; i < n; i++)
{
    Console.Write(a[i]+" ");
}

Console.WriteLine("\nMang sau khi dao nguoc");
for (int i = n-1; i >= 0; i--)
{
    Console.Write(a[i] + " ");
}
