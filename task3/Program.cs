/*Задача 28: Напишите программу, которая принимает на вход число N
 и выдаёт произведение чисел от 1 до N.
4->24 5->120*/

Console.WriteLine("Введите число: ");

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
double j = CountDigitInNumber(num);

Console.WriteLine(j);

double CountDigitInNumber(int N)
{
    double product = 1;
    for(int i = 1; i <= N; i++)
    {
        product = product * i;
    }
    return product;
}






/*int Factorial (int number){
    if ((number == 0) || (number == 1)){
        return 1;
    }
    return number*(Factorial (number - 1));
}

Console.WriteLine("Enter a number");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if(!isParsed)
{
    Console.WriteLine("Incorrect number");
    return;
}
else
{
    int factorial = Factorial(number);
}

Console.WriteLine($"Факториал числа {number} равен {Factorial(number)}");


void Test(){
int[] numbers = new int[] {4 , 5};
int[] sums = new int[] {24 , 120};

for (int i = 0; i < numbers.Length; i++)
{
    int sum = Factorial(numbers[i]);

    if (sum != sums[i])
    {
        Console.WriteLine($"Ожидали получить {sums[i]} а получили {sum}");
    }    
    else
    {
        Console.WriteLine("okay");
    }
}
}*/

