/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int [,,] array3 = new int [2,2,2];
Random random = new Random ();
HashSet<int> numbers = new HashSet<int>();
PrintRandom (array3);
PrintArray (array3);


int GenerateNumber ()  // метод генерации неповторяющихся чисел
{
    while (true)
    {
        var number = random.Next (10,99);
        if (!numbers.Contains(number))
        {
            numbers.Add (number);
            return number;
        }
    }
}



int[,,] PrintRandom (int [,,] array) // метод заполняем массив рандомными числами

{ 
    

for (var i = 0; i < array3.GetLength(0); i++)
   {
       
       for (var j = 0; j < array3.GetLength(1); j++)
       {
           for (int k = 0; k < array3.GetLength(2); k++)

           {
                array3[i, j, k] = GenerateNumber();
           }
       }

}
   return (array3);

}

void PrintArray (int [,,] array3) // метод добавляем индекс 
{
    for (int i = 0; i < array3.GetLength(0); i++)

    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
           
            for (int k = 0; k < array3.GetLength(2); k++)
            {
                Console.Write ($"{array3 [i, j, k]}({i},{j},{k})");
                Console.WriteLine ();
            }
        }
        
    }
}


