/*Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> Четное

*/

Console.WriteLine("Enter  your number");
int A = int.Parse(Console.ReadLine()); //преобразование строки в целове число


if(A%2==0) {Console.WriteLine("Your number is even");}
else {Console.WriteLine("Your number is odd");}
