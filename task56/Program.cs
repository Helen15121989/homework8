/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


Console.WriteLine("Введите m"); // Запрос у пользователя данные
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = PrintRandom(m, n);
PrintArray(array);
Getminsumm(array);


void PrintArray(int[,] array) // метод (вывода на экран)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] PrintRandom(int m, int n) // метод заполняем массив рандомными числами

{
    int[,] array = new int[m, n];
    Random random = new Random();


    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)


        {
            array[i, j] = random.Next(1, 10);

        }

    }
    return (array);

}

void Getminsumm(int[,] array)
{
    int index = 0;
    int minsum = 0;

    for (int i = 0; i < array.GetLength(0); i++)

    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
       Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;

        }
        if (sum < minsum)

        {
            minsum = sum;
            index = i;

        }

    }
    string minline = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minline = minline + array[index, j];
    }
    Console.WriteLine("Строка с минимальной суммой элементов равна: " + minline );
}

