Console.WriteLine("Данная программа принимает с клавиатуры определённое количество чисел М. И считает сколько чисел больше 0 ввёл пользователь.");
Console.Write("Введите любое количество чисел через запятую: ");

int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}

int[] StringToNum(string input)
{
int count = 1;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == ',')
    {
        count++;
    }
}

int[] numbers = new int [count];
int index = 0;

for (int i = 0; i < input.Length; i++)
{
    string temp = "";

while (input [i] != ',')
{
if(i != input.Length - 1)
{
    temp += input [i].ToString();
    i++;
    }
    else
    {
        temp += input [i].ToString();
        break;
    }
}
    numbers[index] = Convert.ToInt32(temp);
    index++;
}
return numbers;
}

void PrintArray(int[] array)
{
    Console.Write("Введены следующие числа: [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("]");
}
Console.WriteLine();
Console.WriteLine($"Количество введённых чисел, значение которых больше 0: {sum}");