int n = 4;
int[,] matr = new int[n,n];
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
/*for (int i = 0; i < n; i++)
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
int sum = 0;
/*for (int i = 0; i < n; i++)
{
    int tmp = 1;
    for (int j = 0; j < n; j++)
    {
        if (i == 0||j==0||j==n-1||i==n-1)
        {
            sum += matr[i, j];
        }
        

    }
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
Console.WriteLine(sum);