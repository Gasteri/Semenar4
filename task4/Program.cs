/*Задача 30: Напишите программу, которая 
выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

Random rnd = new Random();
int num = InputInt();
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

int[] userArray = ArrayFilling(num);
PrintArr(userArray);

int[] ArrayFilling(int num)
{
    int[] arr = new int[num];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,2);
    }
    return arr;
}

void PrintArr(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i] }");
    }
    Console.WriteLine();
}

void test(int[] userArray, int num)
{
    if (userArray.Length == num)
    {
        Console.WriteLine("ok");
    }
    else
    {
        Console.WriteLine("!ok");
    }
}