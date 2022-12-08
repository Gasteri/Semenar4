/*Напишите программу, 
которая принимает на вход число 
и выдаёт количество цифр в числе.
456 -> 3 78 -> 2 89126 -> 5*/
Console.WriteLine("Введите число: ");

int number = InputInt();

Console.WriteLine($"Количество цифр: {CountNumbers(number)}");

int InputInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if(!isParsed || number < 0)
        {
            Console.WriteLine("Incorrect number");
            return -1;
        }
    else
        {
            return number;
        }
}

int CountNumbers(int number)
{
    int count = 0;
    for(count = 0; number != 0; count ++)
    {
        number = number / 10;
    }
    return count;
}





