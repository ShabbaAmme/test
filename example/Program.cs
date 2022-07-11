Console.WriteLine("Enter two numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (b>a) 
{
    max = b;
    min = a;
}
else
{
    min = b;
    max = a;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);