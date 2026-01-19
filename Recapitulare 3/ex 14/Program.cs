//14. Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit.
//(nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului)
int[] v = {1, 0, 23, 78, 0, 38, 0, 21, 2828, 0, 282};
int n = v.Length;

int ultimNenul = n - 1;
for (int i = 0; i < ultimNenul; i++)
{
    if (v[i] == 0)
    {
        while (v[ultimNenul] == 0)
        {
            ultimNenul--;
        }
        int aux = v[i];
        v[i] = v[ultimNenul];
        v[ultimNenul] = aux;
    }   
}

for (int i = 0; i < n; i++)
    Console.Write($"{v[i]} ");