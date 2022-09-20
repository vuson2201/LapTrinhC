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

int min = 0;
for (int i = 0; i < n; i++)
{
    if (a[i] < min)
        min = a[i];
}
Console.WriteLine("phan tu co gia tri nho nhat la " + min);