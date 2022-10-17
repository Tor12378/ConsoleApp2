//слияние
/*
int[] arr1 = new int[] { 1, 3, 5 };
int[] arr2 = new int[] { 2, 4, 6, 8 };

int len1 = arr1.Length;
int len2 = arr2.Length;
int[] res = new int[len1 + len2];
int i = 0;
int j = 0;
int tmp = 0;
while (i < len1 && j < len2)
{
    if (arr1[i] < arr2[j])
    {
        res[tmp] = arr1[i];
        tmp += 1;
        i += 1;
    }
    else
    {
        res[tmp] = arr2[j];
        tmp += 1;
        j += 1;

    }
}
if (i != len1)
{
    for (int k = i; k < len1; k++)
    {
        res[tmp] = arr1[k];
        tmp += 1;
    }


}
else if (j != len2)
{
    for (int k = j; k < len1; k++)
    {
        res[tmp] = arr2[k];
        tmp += 1;
    }


}
for (int g = 0; g < res.Length; g++)
{
    Console.WriteLine(res[g]);
}

//Пересечение 
using System;

int[] arr1 = new int[] { 1, 3, 5,8,9 };
int[] arr2 = new int[] { 1, 4, 6, 8 };

int len1 = arr1.Length;
int len2 = arr2.Length;
int[] res = new int[0];

int i = 0;
int j = 0;
int tmp = 0;
while (i < len1 && j < len2)
{
    if (arr1[i] < arr2[j])
    {
        Array.Resize(ref res, res.Length + 1);
        res[tmp] = arr1[i];
        tmp += 1;
        i+= 1;
    }
    else if(arr1[i] > arr2[j])
    {
        j += 1;
    }
    else
    {
        i += 1;
    }
}
if (i != len1)
{
    for (int k = i; k < len1; k++)
    {
        Array.Resize(ref res, res.Length + 1);
        res[tmp] = arr1[k];
        tmp += 1;
    }


}

for (int g = 0; g < res.Length; g++)
{
    Console.WriteLine(res[g]);

}
//Разница
int[] arr1 = new int[] { 1, 3, 5, 8, 9 };
int[] arr2 = new int[] { 1, 4, 6, 8 };

int len1 = arr1.Length;
int len2 = arr2.Length;
int[] res = new int[0];


int i = 0;
int j = 0;
int tmp = 0;
while (i < len1 && j < len2)
{
    if (arr1[i] < arr2[j])
    {
        i += 1;
    }
    else if (arr1[i] > arr2[j])
    {
        j += 1;
    }
    else
    {
        Array.Resize(ref res, res.Length + 1);
        res[tmp] = arr1[i];
        tmp += 1;
        i += 1;
        j += 1;
    }
}

for (int g = 0; g < res.Length; g++)
{
    Console.WriteLine(res[g]);

}
*/
/*using System.Transactions;

int n = 4;
int[,] matr = new int[4,4]
{
    { 1,2,3,4},
    { 0,0,0,5},
    { 0,0,0,6},
    { 7,0,0,7}
};
*/
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


/*int length = n;
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
*/
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
/*
for (int i = 0; i < n; i++)
{
for (int j = 0; j < n; j++)
{
    Console.Write($"{matr[i, j],4}");
}
Console.WriteLine();
}

*/
/*
 static void Umn(int[,] matr)
{
    int[,] res = new int[matr.GetLength(0), matr.GetLength(1)];

    
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            res[i, j] = 0;
            for (int k = 0; k < matr.GetLength(1); k++)
                res[i, j] += matr[i, k] * matr[k, j];
        }
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            Console.Write($"{res[i, j],4}");
        }
        Console.WriteLine();
    }
}
*/
/*
static void swap(int[,] matr)
{
    
    for (int i = 0; i < matr.GetLength(0); i=i+2)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i< matr.GetLength(0) - 1) {
                var tmp = matr[i, j];
                matr[i, j] = matr[i+1 , j];
                matr[i + 1, j] = tmp;
            }

        }
    }




    for (int i = 0; i< matr.GetLength(0); i++)
    {
        for (int j = 0; j <matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],4}");
        }
        Console.WriteLine();
    }
}
*/
/*
int[,] m1 = new int[5, 2]
{
            { 1,1 },
            {1,2 },
    {1,3 },
    {1,4 },
    {1,5 }
};
int[,] m2 = new int[2, 2]
{
            { 1,1 },
            {1,1 }
};
*/