//30. Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima
int n;

n = int.Parse(Console.ReadLine());
string input= Console.ReadLine();
string[] tokensE = input.Split(' ');
input= Console.ReadLine();
string[] tokensW = input.Split(' ');

int[] E = new int[n];
for (int i = 0; i < n; i++)
{
       E[i] = int.Parse(tokensE[i]);
}
int[] W = new int[n];
for (int i = 0; i < n; i++)
{
       W[i] = int.Parse(tokensW[i]);
}

for(int i = 0; i < n - 1; i++)
{
    for(int j = i + 1; j < n; j++)
    {
        if(E[i] > E[j] || (E[i] == E[j] && W[i] < W[j]))
        {
            (E[i], E[j]) = (E[j], E[i]);
            (W[i], W[j]) = (W[j], W[i]);
        }
    }
}

for (int i = 0; i < n; i++)
{
    Console.Write($"{E[i]}:{W[i]} ");
}
