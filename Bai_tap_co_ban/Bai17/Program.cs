// See https://aka.ms/new-console-template for more information
string s1;
char c;
Console.WriteLine("Nhap vao 1 chuoi");
s1 = Console.ReadLine();
Console.WriteLine("Nhap vao 1 ky tu");
c = char.Parse(Console.ReadLine());
Console.WriteLine("\nKet qua");
bool check = false;
for (int i = 0; i < s1.Length; i++)
{
    if (c == s1[i])
    {
        Console.WriteLine("Ky tu " + c + " ton tai o vi tri " + i);
        check = true;
    }
}
if(check==false) Console.WriteLine("Ky tu " + c + " khong ton tai trong chuoi");