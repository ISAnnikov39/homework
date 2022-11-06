/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.  */

int a = new Random().Next(1,10);
int b = new Random().Next(1,10);
int[,]table = new int[a, b];

void FillArray( int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,]matrix){

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void MiddleNumber(int[,]matrix){

    for (int i = 0; i < matrix.GetLength(1); i++){

         int middle = 0;
         
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            middle += matrix[j,i];
        }
        double result = (double)middle/ (double)(matrix.GetLength(1)+1);
         System.Console.Write($"{result} ");
    }
}



FillArray(table);
PrintArray(table);
MiddleNumber(table);