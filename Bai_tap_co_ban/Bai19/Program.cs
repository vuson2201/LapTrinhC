// See https://aka.ms/new-console-template for more information
string s1;
int solan = 0;
Console.WriteLine("Nhap vao 1 chuoi");
s1 = Console.ReadLine();
Console.WriteLine("\nKet qua");
bool check = false;
for (int i = 0; i < s1.Length; i++)
{
    if (s1[i]=='a')
    {
        solan++;
        check = true;
    }
}
if (check == false) Console.WriteLine("Ky tu a khong ton tai trong chuoi");
else Console.WriteLine("Ky tu a xuat hien " + solan + " lan");