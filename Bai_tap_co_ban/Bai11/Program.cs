﻿// See https://aka.ms/new-console-template for more information
int n;
Console.WriteLine("Nhap n");
n=int.Parse(Console.ReadLine());

int[] a = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Nhap so thu " + (i + 1));
    a[i] = int.Parse(Console.ReadLine());
}

float tong = 0;
for (int i = 0; i < n; i++)
{
    tong = tong + a[i];
}
Console.WriteLine("TBC = "+(tong/n));