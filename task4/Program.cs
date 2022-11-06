/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
Задача 54.1 : Задайте двумерный массив. Напишите программу, которая упорядочит элементы по убыванию (или возрастанию).*/


int a = new Random().Next(1,10);
int b = new Random().Next(1,10);
int[,]table = new int[a, b];

void SelectMatrixUp ( int [,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){

        for( int j = 0; j< matrix.GetLength(1); j++){
            
            for (int k = 0; k < matrix.GetLength(1)-j-1; k++){
                  
                  if(matrix[i,k]>matrix[i,k+1]){

                    int temporary = matrix[i,k];
                    matrix [i,k]=  matrix [i,k+1];
                    matrix [i,k+1] = temporary;   
                }  
            } 
        }
    }
}


void SelectMatrixDown ( int [,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){

        for( int j = 0; j< matrix.GetLength(1); j++){
            
            for (int k = 0; k < matrix.GetLength(1)-j-1; k++){
                  
                  if(matrix[i,k]<matrix[i,k+1]){

                    int temporary = matrix[i,k];
                    matrix [i,k]=  matrix [i,k+1];
                    matrix [i,k+1] = temporary;   
                }  
            } 
        }
    }
}



void Fillmatrix( int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i,j] = new Random().Next(0, 10);
        }
    }
}

void Printmatrix(int[,]matrix){

    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}





Fillmatrix(table);
Printmatrix(table);
System.Console.WriteLine();
SelectMatrixUp(table);
Printmatrix(table);
System.Console.WriteLine();

SelectMatrixDown(table);
Printmatrix(table);
