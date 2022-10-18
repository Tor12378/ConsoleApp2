using System;
using System.Runtime.CompilerServices;
/*
static void Umn(int[,] matr, ref int[,] matrold,int kol)
{
for (int s = 1; s < kol; s++)
{
int[,] res = new int[matr.GetLength(0), matr.GetLength(1)];
for (int i = 0; i < matr.GetLength(0); i++)
for (int j = 0; j < matr.GetLength(1); j++)
{
res[i, j] = 0;
for (int k = 0; k < matr.GetLength(1); k++)
res[i, j] += matr[i, k] * matrold[k, j];
}
matrold = res;
}


}
int[,] m2 = new int[2,2]
{
{1,1},
{1,0}


};
Umn(m2,ref m2,6);
for (int i = 0; i <m2.GetLength(0); i++)
{
for (int j = 0; j < m2.GetLength(1); j++)
{
Console.Write($"{m2[i, j],4}");
}
Console.WriteLine();
}
*/
/*
List<int> list1 = new List<int>();
var kol = 5;
for(int i = 0; i < kol; i++)
{
    list1.Add(i);
}
string s = "hello";
foreach(object k in s)
{
    Console.WriteLine(k);
}
list1.Remove(0);
for (int i = 0; i < list1.Count; i++)
{
    Console.WriteLine(list1[i]);
}
Console.WriteLine("{0}",list1.Contains(0));

*/


string s1 = "потоп информатика aбв шалаш";
var t = s1.Split(" ");
List<string> pol = new List<string>();
List<string> povtor = new List<string>();
List<string> alfa = new List<string>();
List<string> len = new List<string>();
string smin = t[0];

string smax = t[0];
foreach (string word in t)
{
    if (word.Length >= smin.Length)
    {
        smin = word;
    }
    if (word.Length <= smax.Length)
    {
        smax = word;
    }
    bool alf = true;
    for (int i = 1; i < word.Length; i++)
    {

        if (word[i] < word[i - 1])
        {
            alf = false;
        }

    }
    if (alf)
    {
        alfa.Add(word);
    }
    bool polindrom = true;
    
    int count = 0;
    char first = word[0];
    for (int i=0; i <word.Length; i++)
    {
        
        if (word[i] != word[word.Length  - i-1])
        {
            polindrom = false;
            
        }
        if (word[i] == first)
        {
            count++;
        }
    }
    if (polindrom)
    {
        pol.Add(word);
    }
    if (count>1)
    {
        povtor.Add(word);
    }
}


len.Add(smax);
len.Add(smin);
foreach (object k in pol)
{
    Console.WriteLine(k);
}
Console.WriteLine();
foreach (object k in povtor)
{
    Console.WriteLine(k);
}
Console.WriteLine();
foreach (object k in alfa)
{
    Console.WriteLine(k);
}
Console.WriteLine();
foreach (object k in len)
{
    Console.WriteLine(k);
}