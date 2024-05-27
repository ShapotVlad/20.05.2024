//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] array = new int[,]
{
            {1, 2, 3},
            {1, 1, 0},
            {7, 8, 2},
            {9, 10, 11}
};

int[] SumRows(int[,] array)
{
    int rows = array.GetLength(0); // Количество строк
    int cols = array.GetLength(1); // Количество столбцов

    int[] SumRows = new int[rows]; // Одномерный массив для сумм строк

    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < cols; j++)
        {
            sum += array[i, j]; // Суммируем значения в текущей строке
        }
        SumRows[i] = sum; // Записываем сумму в одномерный массив
    }
    return SumRows;
}

void PrintSumRows(int[] SumRows)                   //создали  тип функции для вывода одномерного массива
{
    Console.Write("[");
    for (int i = 0; i < SumRows.Length; i++) //цикл вывода одномерного массива
    {
        if (i < SumRows.Length - 1)
            Console.Write($"{SumRows[i]}, "); //элементы массива через запятую  
            Console.Write($"{SumRows[i]}");    //после последнего элемента запятая не ставится и количество цифр после запятой
    }
    Console.Write("]");
}


int MinIndex(int[] SumRows) // создали функцию для определения индекса строки с мин суммой
{    
    int minIndex = 0;
    int minValue = SumRows[0];

    for (int i = 1; i < SumRows.Length; i++)
    {
        if (SumRows[i] < minValue)
        {
            minValue = SumRows[i];
            minIndex = i;
        }
    }
    return minIndex;
}
int[] result = SumRows(array);
PrintSumRows(result);

Console.WriteLine();

int minIndex = MinIndex(result);
Console.WriteLine(minIndex);




