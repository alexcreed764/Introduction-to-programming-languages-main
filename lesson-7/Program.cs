// Задача 47. Двумерный массив размером m×n, заполненный случайными вещественными числами.
void Task47()
{
    Console.WriteLine("Введите количество строк:");
    int linesVol = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов:");
    int columnsVol = Convert.ToInt32(Console.ReadLine());
    double[,] numbers = new double[linesVol, columnsVol];
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);

    void FillArrayRandomNumbers(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            }
        }
    }

    void PrintArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}

// Задача 50. Программа, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
void Task50()
{

    Console.WriteLine("Введите номер строкиЖ:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца:");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[10, 10];
    FillArrayRandomNumbers(numbers);

    if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
    }

    PrintArray(numbers);

    void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(-100, 100) / 10;
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}

// Задача 52.Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце.
                //Например, задан массив:
                //1 4 7 2
                //5 9 2 3
                //8 4 2 4
                //Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.]
                Random random = new Random();
                int rows = random.Next(3, 4);
                int columns = random.Next(3, 4);
                int[,] array = new int[rows, columns];
                FillArray(array);
                PrintArray(array);
                void FillArray(int[,] ar, int startNumber = 0, int finishNumber = 10)
                {
                    finishNumber++;
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            array[i, j] = random.Next(startNumber, finishNumber);
                        }
                    }
                }
                void PrintArray(int[,] ar)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            Console.Write(array[i, j] + "   ");
                        }
                        Console.WriteLine();
                    }
                    for (int i = 0; i < rows; i++)
                    {
                        double Average = 0;
                        for (int j = 0; j < columns; j++)
                        {
                            Average += array[j, i];
                        }
                        Console.Write($"\nCреднее арифметическое:");
                        Average = Math.Round(Average / columns, 1);
                        Console.WriteLine($"столбца № {i + 1} {"="} {Average}");

                    }
                    