/*Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7, min = 5
*/

Console.WriteLine("Enter  number1 (A):");
int A = int.Parse(Console.ReadLine()); //преобразование строки в целове число
Console.WriteLine("Enter  number2 (B):");
int B = int.Parse(Console.ReadLine()); //преобразование строки в целове число


while(A==B) 
{
    Console.WriteLine("Your numbers are equal (A=B)! Input other numbers.");
    Console.WriteLine("Enter  number1 (A):");
    A = int.Parse(Console.ReadLine()); //преобразование строки в целове число
    Console.WriteLine("Enter  number2 (B):");
    B = int.Parse(Console.ReadLine()); //преобразование строки в целове число
}

if(A>B) {Console.WriteLine($"You max number is A={A} and your min number is B={B}");}
else {Console.WriteLine($"You max number is B={B} and your min number is A={A}");}


