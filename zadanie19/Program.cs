// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Ведите число ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num <= 10000) || (num > 99999))
{
    Console.WriteLine("введите пятизначное число");
}
else
{
     int a = num/10000;
     int b = num%10;
     int h = num / 1000;
     int c = h%10;
     int d = (num%100)/10;
  if (( a == b) && ( c == d))
   {
    Console.WriteLine("да");
   }
    else
   {    
    Console.WriteLine("net");
   }
}



