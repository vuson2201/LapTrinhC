// See https://aka.ms/new-console-template for more information
int n;
Console.WriteLine("Nhap vao mot so nguyen:");
n = int.Parse(Console.ReadLine());

switch (n)
{
    case 0: Console.WriteLine("->Khong"); break;
    case 1: Console.WriteLine("->Mot"); break;
    case 2: Console.WriteLine("->Hai"); break;
    case 3: Console.WriteLine("->Ba"); break;
    case 4: Console.WriteLine("->Bon"); break;
    case 5: Console.WriteLine("->Nam"); break;
    case 6: Console.WriteLine("->Sau"); break;
    case 7: Console.WriteLine("->Bay"); break;
    case 8: Console.WriteLine("->Tam"); break;
    case 9: Console.WriteLine("->Chin"); break;
    default:
        Console.WriteLine("Nhan cac so tu 0 den 9");
        break;
}