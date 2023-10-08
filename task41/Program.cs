// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] UserCreateArray (int [] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите число ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int NumberMoreZero (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum++;
    }
    return sum;
}


Console.WriteLine("Сколько чисел вы хотите ввести?");
int arraySize = Convert.ToInt32(Console.ReadLine());

int [] array = new int[arraySize];

UserCreateArray(array);

PrintArray(array);
int numberMoreZero = NumberMoreZero(array);
Console.Write($" -> {numberMoreZero}");
