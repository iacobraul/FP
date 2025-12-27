//15. Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector
int n;

string input= Console.ReadLine();
string[] tokens = input.Split(' ');
n = tokens.Length;

int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; )
    {
        if (v[i] == v[j])
        {
            for (int k = j; k < n - 1; k++)
            {
                v[k] = v[k + 1];
            }
            n--;
        }
        else
        {
            j++;
        }
    }
}

for (int i = 0; i < n; i++)
{
    Console.Write($"{v[i]} ");
}
