
using System.Diagnostics.CodeAnalysis;
Random random = new Random();
int len = random.Next(10);
int[] b = new int[len] ;
for(int i = 0; i < len; i++)
{
    b[i] = random.Next(50);
}
int max = b[0];
int min = b[0];
int maxpos = 0;
int minpos = 0;
for(int i = 0; i < b.Length; i++)
{
    if (b[i] > max)
    {
        max = b[i];
        maxpos = i;
    }
    if (b[i] < min)
    {
        min = b[i];
        minpos = i;
    }
}
int sum = 0;
if (maxpos > minpos)
{
    for (int i = minpos+1; i < maxpos; i++)
    {
        sum += b[i];
    }
}
else
{
    for (int i = maxpos + 1; i < minpos; i++)
    {
        sum += b[i];
    }
}
for (int i = 0; i < len; i++)
{
    Console.WriteLine(b[i]);
}
Console.WriteLine("res {0}",sum);

