/*Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4*/

Console.WriteLine("Enter  your number");
int A = int.Parse(Console.ReadLine()); //преобразование строки в целове число

while (A<=1)
{
    Console.WriteLine("Your mumber can't be 1 or smaller, pls enter other number:");
    A = int.Parse(Console.ReadLine()); //преобразование строки в целове число
}

Console.WriteLine("The list of even values between 1 and your number is:");

for(int i=1;i<=A;i++)
{
    if(i%2==0) {Console.WriteLine(i);}
    
}



