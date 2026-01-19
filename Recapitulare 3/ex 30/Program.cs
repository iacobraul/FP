//30. Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i].
//Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. 
int[] E = { 4, 2, 4, 3, 2 };
int[] W = { 1, 3, 2, 4, 5 };

int n = E.Length;
for(int i = 0; i <  n - 1; i++)
{
    for(int j = i + 1; j < n; j++)
    {
        if(E[i] > E[j] || (E[i] == E[j] && W[i] < W[j]))
        {
            int tempE = E[i];
            E[i] = E[j];
            E[j] = tempE;
            int tempW = W[i];
            W[i] = W[j];
            W[j] = tempW;
        }
    }
}

Console.WriteLine("Vectorul E sortat: " + string.Join(", ", E));
Console.WriteLine("Vectorul W sortat: " + string.Join(", ", W));