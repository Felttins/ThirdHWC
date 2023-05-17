// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int N = Prompt(" ");

int Prompt(string message)
{
    Console.Write("Введите пятизначное число - ");
    int N= int.Parse(Console.ReadLine()!);
    return N;
}

Operation(N);

void Operation(int number)
{
    if (number >10000 && number < 100000)
    {
        int A = (number/10000);
        int B = (number/1000%10);
        int C= (number/10%10);
        int D = (number/1%10);
        if (A==D)
        {
        if (B==C)
        {
        Console.WriteLine("Это палиндром");  
        }
        }
        else
        {
           Console.WriteLine("Это не палиндром");  
        }
    }
    else
    {
        Console.WriteLine("Данное число не пятизначно!");
    }
}