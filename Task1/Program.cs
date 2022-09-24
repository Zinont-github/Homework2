//Напишите программу которая принимает трехзначное число и выводит вторую цифру числа

int number = ReadInt("Введите трехзначное число: ");

Console.WriteLine(number);
Console.WriteLine(DeleteFirstThridDigit(number));


int DeleteFirstThridDigit(int secondDigit)
{
    int a = number % 100;
    int b = a / 10;
    return b;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

