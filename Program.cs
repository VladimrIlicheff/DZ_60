/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0) */

int[,,]  TriDMatrix(int z, int m, int n)
{
    int[,,] resultMatrix = new int[z, m, n];
    Random rnd = new Random();
        
    for (int a = 0; a < resultMatrix.GetLength(0); a++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < resultMatrix.GetLength(2); k++)
            {
                int number = rnd.Next(10, 100);
                int count = 0;
                if (resultMatrix[a, j, k] == number)
                {
                    count++;
                }
                else resultMatrix[a, j, k] = number;                                
            }
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) | ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] FillArray (int[,,] array)
{
    Random rnd = new Random();
    List<int> numbers = new List<int>();
    int num;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                do{
                    num = rnd.Next(10, 100);
                }
                while (numbers.Contains(num));
                numbers.Add(num);
                array[i, j, k] = num;
            }
        }
    }
    return array;
}

int [,,] matrix = TriDMatrix(3, 3, 3);
int [,,] newMatrix = FillArray(matrix); 
PrintMatrix(FillArray(matrix));
Console.WriteLine($"{PrintMatrix}");


