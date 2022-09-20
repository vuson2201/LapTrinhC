// See https://aka.ms/new-console-template for more information
int n;
Console.WriteLine("Nhap n");
n = int.Parse(Console.ReadLine());

int[] a = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Nhap so duong thu " + (i + 1));
    a[i] = int.Parse(Console.ReadLine());
}

int max = 0;
for (int i = 0; i < n; i++)
{
    if(a[i] > max)
    max = a[i];
}
Console.WriteLine("phan tu co gia tri lon nhat la " + max);