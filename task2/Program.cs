/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение
 этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

[1,7] -> такого элемента в массиве нет
*/
int a = new Random().Next(1,10);
int b = new Random().Next(1,10);
int[,]table = new int[a, b];

void FillArray( int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-10, 10);
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

 void Result (int row , int column){
    if (row <= a & column <= b)
    {
        System.Console.WriteLine(table[row-1, column-1]);
    }else{
        System.Console.WriteLine("такого элемента в массиве нет");
    }
 }





System.Console.WriteLine("Введите строку и столбец");
int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());

FillArray(table);
PrintArray(table);
 
Result(row, column);


