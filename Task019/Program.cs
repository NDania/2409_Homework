// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, являтся ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int []a = new int[5];
double m = n / 10000;

if (m >= 1 && m < 10)
{    
    for(int i = 4; i >= 0; i--)
    {
        a[i] = n % 10;
        n = n/10;
    }
    if (a[0] == a[4] && a[1] == a[3])
        Console.WriteLine("Число является палиндромом.");
    else    
        Console.WriteLine("Число палиндромом не является.");   
}
else
    Console.WriteLine("Введенное число не пятизначное.");

