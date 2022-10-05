Console.WriteLine("Введите 1 число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(a*a);
if (n == a*a)
{
    Console.WriteLine(" YES");
}    
else
{
    Console.WriteLine(" NO");
}    