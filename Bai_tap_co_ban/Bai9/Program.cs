// See https://aka.ms/new-console-template for more information
int n;
do
{
    Console.WriteLine("Nhap vao so nguyen n");
    n = int.Parse(Console.ReadLine());
} while (n < 0 || n > 20);
//int f0 = 1;
//int f1 = 1;
//int fn = 1;
//for (int i = 2; i <= n; i++)
//{
//    f0 = f1;
//    f1 = fn;
//    fn = f0 + f1;
//}
//Console.WriteLine("f(" + n + ") = " + fn);
int fibonacci(int n)
{
    if (n == 0 || n == 1)
    {
        return 1;
    }
    else
    {
        return fibonacci(n - 1) + fibonacci(n - 2);
    }
}
Console.WriteLine("f(" + n + ") = " + fibonacci(n));