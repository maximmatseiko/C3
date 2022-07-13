// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число :");
int Num1=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число :");
int Num2=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите тетье число");
int Num3=Convert.ToInt32(Console.ReadLine());
if (Num1>Num2)
{
    System.Console.WriteLine("Наибольшее число :"+Num1);
}
else if (Num2>Num3)
{
    System.Console.WriteLine("Наибольшее число :"+Num2);
}
else
{
    System.Console.WriteLine("Наибольшее число :"+Num3);
}
Console.ReadKey();