using System.Transactions;

int n = 4;
int[,] matr = new int[4,4]
{
    { 1,2,3,4},
    { 0,0,0,5},
    { 0,0,0,6},
    { 7,0,0,7}
};
//задача 1 еденичная матрица
/*for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        if (i == j)
        {
            matr[i, j] = 1;
        }
        else
        {
            matr[i, j] = 0;
        }
    }
}
*/
//Задача 2 ыерхнетреугольная
/*
for (int i = 0; i < n; i++)
{
    
    for (int j = 0; j < n; j++)
    {
        if (j <= i)
        {
            matr[i, j] = j+1;
        }
        else { matr[i, j] = 0; }

    }
}
*/
//Задача 3 нижнетреугольная
/*
for (int i = 0; i < n; i++)
{
    int tmp = 1;
    for (int j = 0; j < n; j++)
    {
        if (j >= i)
        {
            matr[i, j] = tmp;
            tmp += 1;
        }
        else { matr[i, j] = 0; }

    }
}
*/
//Задача 4 сумма граней
/*int sum = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == 0||j==0||j==n-1||i==n-1)
        {
            sum += matr[i, j];
        }
    }
}
*/
//Задача 5 сумма крест 
/*int sum = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if ((i==j)||(i+j==n-1))
        { 
            sum += matr[i, j]; 
        }
    }
}
*/
// Задаса 6 ромб
/*
int sum = 0;
int start = 0;
int end = n;
int stMn = 1;
int endMn = 1;
for (int i = 0; i < n; i++)
{
    if (Math.Abs(start - end)==1)
    {
        stMn = -1;
        endMn = -1;
    }
    

    for (int j =start; j < end; j++)
    {
            sum += matr[i, j];
    }
    start += stMn;
    end -= endMn;
}
*/
//Повернуть матрицу


int length = n;
for (int i = 0; i < length / 2; i++)
{
    int first = i;
    int last = length - 1 - i;
    for (int j = i; j < last; j++)
    {
        int tmp = j - first;
        int top = matr[first,j];
        matr[first,j] = matr[last - tmp,first];
        matr[last - tmp,first] = matr[last,last - tmp];
        matr[last,last - tmp] = matr[j,last];
        matr[j,last] = top;
    }
}
    //проверка на еденичную матрицу
    /*bool res = true;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j && matr[i,j]!=1)
            {
                res = false;
            }
            else if (i != j && matr[i, j] != 0)
            {
                res = false;
            }
        }
    }
    if (res)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
    */
    //проверка на симмерричность
    /*bool res = true;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matr[i, j] != matr[n-i-1,n-j-1])
            {
                res = false;
            }
        }
    }
    if (res)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
    */
    // проверка на верзнетреугольность 
    /*bool res = true;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i > j && matr[i,j]!=0)
            {
                res = false;
            }
        }
    }
    if (res)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
    */

    for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matr[i, j],4}");
    }
    Console.WriteLine();
}



