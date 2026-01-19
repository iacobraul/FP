//15. Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector
int[] v = { 1, 0, 23, 78, 0, 38, 0, 21, 2828, 0, 282, 21, 23, 197 };
int n = v.Length;

for (int i = 0; i < n; i++)
{
    for(int j = i + 1; j < n; j++)
    {
        if (v[i] == v[j])
        {
            for( int k = j + 1 ; k < n ; k++)
            {
                v[k - 1] = v[k];
            }
            n--;
        }
    }
}

for(int i = 0;i < n; i++)
    Console.Write($"{v[i]} ");