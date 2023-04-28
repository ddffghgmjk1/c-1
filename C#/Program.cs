System.Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(a<b)
{
    max=b;
}
else
{
    max=a;
}
if (max<c)
{
    max=c;
}
System.Console.WriteLine(max);