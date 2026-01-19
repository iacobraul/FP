//19. Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s.
//De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori.
//(Problema este dificila doar daca o rezolvati cu un algoritm liniar).
int[] s = { 1, 2, 1, 2, 1, 3, 1, 2, 1 };
int[] p = { 1, 2, 1 };

int n = s.Length;
int m = p.Length;
int cnt = 0;

for (int i = 0; i <= n - m; i++)
{
    bool found = true;
    for (int j = 0; j < m; j++)
    {
        if (s[i + j] != p[j])
        {
            found = false;
            break;
        }
    }
    if (found)
    {
        cnt++;
    }
}

Console.WriteLine(cnt);