//25. (Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate
int n1, n2;

string inputV1 = Console.ReadLine();
string[] tokensV1 = inputV1.Split(' ');
string inputV2 = Console.ReadLine();
string[] tokensV2 = inputV2.Split(' ');

n1 = tokensV1.Length;
int[] v1 = new int[n1];

n2 = tokensV2.Length;
int[] v2 = new int[n2];

for (int a = 0; a < n1; a++)
{
    v1[a] = int.Parse(tokensV1[a]);
}
for (int a = 0; a < n2; a++)
{
    v2[a] = int.Parse(tokensV2[a]);
}

int[] v3 = new int[n1 + n2];
int i = 0, j = 0, k = 0;
while (i < n1 && j < n2)
{
    if (v1[i] < v2[j])
    {
        v3[k] = v1[i];
        k++;
        i++;
    }
    else
    {
        v3[k] = v2[j];
        k++; 
        j++;
    }
}
while (i < n1)
{
    v3[k] = v1[i];
    k++;
    i++;
}
while (j < n2)
{
    v3[k] = v2[j];
    k++;
    j++;
}
for (i = 0; i < n1 + n2; i++)
{
    Console.Write($"{v3[i]} ");
}