// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

void CheckNum()
{
    int num1 = num / 10000 % 10;
    int num2 = num / 1000 % 10;
    int rev1 = num / 10 % 10;
    int rev2 = num % 10;
    int nul = num / 10000;

    if (nul < 1 || nul > 9)
    {
        Console.WriteLine("Введено не пятизначное число");
    }
    else if (num1 == rev2 && num2 == rev1)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}

CheckNum();