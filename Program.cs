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
