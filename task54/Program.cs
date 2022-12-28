/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


Console.WriteLine("Введите m"); // Запрос у пользователя данные
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = PrintRandom(m, n);
PrintArray(array);
GetOrderingElements (array);
Console.WriteLine ();
PrintArray(array);

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


void GetOrderingElements (int [,] array) // метод упорядочивания элементов 

{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int a = 0; a < array.GetLength(1) - 1 ; a++)
        {
            if (array[i, a] < array[i, a + 1])
                {
                    int temp = array[i, a + 1];
                    array[i, a + 1] = array[i, a];
                    array[i, a] = temp;
                }
        }
    }
}

}

