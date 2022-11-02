// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
Console.WriteLine("Введите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 9999 && num <= 100000)
{  
    int firstnum = num / 10000;
    int lastnum = num % 10;

    if (firstnum == lastnum)
    {      
        int secondnum = num / 1000 % 10;
        int penultnum = num/10 % 10;

        if (secondnum == penultnum) 
        {
            Console.WriteLine("Да, это число - полиндром");
        }
    }  
    else
    Console.WriteLine("Нет, это число не полиндром");
}
else
{
Console.WriteLine("Вы ввели не пятизначное число");
}
