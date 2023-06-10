// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Sum(int a, int b, int summa)

{
 
if (b < a)
{

Console.WriteLine($"Сумма натуральных элементов в промежутке от a до b: {summa}");
return; 
}
summa = summa + (a++);
Sum(a,b, summa);
}
System.Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Sum(a,b,0);
