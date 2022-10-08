/*
Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
5 -> 9

индексы:
[0][1][2][3]
 1  4  7  2
[4][5][6][7]
 5  9  2  3
[8][9][10][11]
 8  4  2   4
*/
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void print2DArray(int[,] arrayToPrint)
{
    Console.Write("\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i+"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+"\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void findElementInMatrixByPosition(int[,] matrix, int position)
{
    if(position < matrix.GetLength(0) * matrix.GetLength(1))
    {
        int i = (int)Math.Ceiling(position / matrix.GetLength(1) + 0.0);
        int j = (int)Math.Ceiling(position / matrix.GetLength(0) + 0.0);
        Console.WriteLine($"-> {matrix[i - 1, j - 1]}");
    }
    else Console.WriteLine($"{position} -> такого числа в массиве нет");
}
int[,] TwoDArray = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};
print2DArray(TwoDArray);
Console.WriteLine("Введите позицию элемента: ");
int position = Convert.ToInt32(Console.ReadLine());
findElementInMatrixByPosition(TwoDArray, position);
