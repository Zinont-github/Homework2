int number = ReadInt("Введите число, обозначающее день недели: ");
if(number == 6 || number == 7)
{
    Console.WriteLine("Это выходной!");
}
else if(number < 1 || number > 7)
{
    Console.WriteLine("Это не день недели!");
}
else
{
    Console.WriteLine("Это не выходной день!");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

