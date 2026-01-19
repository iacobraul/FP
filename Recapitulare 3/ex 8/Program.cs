//8. Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga.
//Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc
int[] v  = {1, 2, 3, 4, 5 };
int n = v.Length;
int aux = v[0];

for (int i = 1; i < n; i++)
{
    v[i - 1] = v[i];
}
v[n - 1] = aux;

for (int i = 0; i < n; i++)
    Console.Write($"{v[i]} ");