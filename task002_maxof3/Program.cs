/*Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
*/
Console.WriteLine("Enter  number1 (A):");
int A = int.Parse(Console.ReadLine()); //преобразование строки в целове число
Console.WriteLine("Enter  number2 (B):");
int B = int.Parse(Console.ReadLine()); //преобразование строки в целове число
Console.WriteLine("Enter  number3 (C):");
int C = int.Parse(Console.ReadLine()); //преобразование строки в целове число


while((A==B&&B==C&&A==C)||A==B||A==C||B==C) 
{
    Console.WriteLine("Some of Your numbers are equal ! Input other numbers.");
    Console.WriteLine("Enter  number1 (A):");
    A = int.Parse(Console.ReadLine()); //преобразование строки в целове число
    Console.WriteLine("Enter  number2 (B):");
    B = int.Parse(Console.ReadLine()); //преобразование строки в целове число
    Console.WriteLine("Enter  number3 (C):");
    C = int.Parse(Console.ReadLine()); //преобразование строки в целове число

}
while(A==0&&B==0&&C=0) 
{
    Console.WriteLine("Your numbers are all zero! Input other numbers.");
    Console.WriteLine("Enter  number1 (A):");
    A = int.Parse(Console.ReadLine()); //преобразование строки в целове число
    Console.WriteLine("Enter  number2 (B):");
    B = int.Parse(Console.ReadLine()); //преобразование строки в целове число
}

int max;
if (A>B&&A>C)
{
    max=A;
    Console.WriteLine($"max of your numbers is {max}");
}
if (B>A&&B>C)
{
    max=B;
    Console.WriteLine($"max of your numbers is {max}");
}
if (C>A&&C>B)
{
    max=C;
    Console.WriteLine($"max of your numbers is {max}");
}
