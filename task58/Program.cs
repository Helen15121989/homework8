/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

//Произведением двух матриц А и В называется матрица С, элемент которой, 
//находящийся на пересечении i-й строки и j-го столбца, 
//равен сумме произведений элементов i-й строки матрицы А 
//на соответствующие (по порядку) элементы j-го столбца матрицы В.


Console.WriteLine("Введите m"); // Запрос у пользователя данные
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите m2"); // Запрос у пользователя данные
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n2");
int n2 = Convert.ToInt32(Console.ReadLine());
int[,] array = PrintRandom(m, n);
int[,] newArray = PrintRandom(m2, n2);
int[,] array3 = new int[m, n2];
PrintArray(array, newArray, array3);
GetCompositionArray(array, newArray, array3);






void PrintArray(int[,] array, int[,] newArray, int [,]array3) // метод (вывода на экран)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("| | ");


        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(newArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] PrintRandom(int m, int n) // метод заполняем массив рандомными числами

{
    int[,] array = new int[m, n];
    int[,] newArray = new int[m2, n2];

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

void GetCompositionArray(int[,] array, int[,] newArray, int[,] array3) // метод произведения двух матриц
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                sum = sum + array[i, k] * newArray[k, j];
            }
            array3[i, j] = sum;
            
        }
    
    }





}






