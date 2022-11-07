/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int RandomNumber(int[, ,] matrix){ // задaет число и прогоняет по массиву, усли его нет - выдает его

    int res = 0;
    int number = new Random().Next(10,100);

    for (int i = 0; i < matrix.GetLength(0); i++){

        for (int j = 0; j < matrix.GetLength(1); j++){

                for (int k = 0; k < matrix.GetLength(2); k++){

                    if (matrix[i,j,k] == number){

                    return RandomNumber(matrix);

                    }else{
                    res = number;
                    }   
                }    
            }
        }  return number;  
    }

void Fillmatrix( int[, , ] matrix){ // заполняет массив

    for (int i = 0; i < matrix.GetLength(0); i++){

        for (int j = 0; j < matrix.GetLength(1); j++){

            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = RandomNumber(matrix);
            }
 
        }
    }
}

void Printmatrix(int[, ,]matrix){

    for (int i = 0; i < matrix.GetLength(0); i++){

        for (int j = 0; j < matrix.GetLength(1); j++){

            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($"{matrix[i,j,k]}({i} {j} {k}) ");
            }

        }
        System.Console.WriteLine();
    }
}


int a = new Random().Next(1,5);
int b = new Random().Next(1,5);
int c = new Random().Next(1,5);

int[, ,]table1 = new int[a,b,c];



Fillmatrix(table1);
Printmatrix(table1);
System.Console.WriteLine();
