//25. (Interclasare) Se dau doi vector sortati crescator v1 si v2.
//Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate.
int[] v1 = { 1, 3, 5, 7, 9 };
int[] v2 = { 2, 4, 6, 8, 10 };

int n1 = v1.Length;
int n2 = v2.Length;
int[] v3 = new int[n1 + n2];

int i = 0, j = 0, k = 0;
while(i < n1 && j< n2)
{
    if (v1[i] < v2[j])
    {
        v3[k] = v1[i];
        i++;
        k++;
    }
    else
    {
        v3[k] = v2[j];
        j++;
        k++;
    }
}
while(i < n1)
{
    v3[k] = v1[i];
    i++;
    k++;
}
while(j < n2)
{
    v3[k] = v2[j];
    j++;
    k++;
}

Console.WriteLine("Vectorul interclasat: " + string.Join(", ", v3));