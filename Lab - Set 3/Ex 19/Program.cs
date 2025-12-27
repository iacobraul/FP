//19. Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori.

string inputS = Console.ReadLine();
string[] tokensS = inputS.Split(' ');
int[] s = new int[tokensS.Length];

string inputP = Console.ReadLine();
string[] tokensP = inputP.Split(' ');
int[] p = new int[tokensP.Length];

for (int i = 0; i < tokensS.Length; i++)
{
    s[i] = int.Parse(tokensS[i]);
}
for (int i = 0; i < tokensP.Length; i++)
{
    p[i] = int.Parse(tokensP[i]);
}

int n = s.Length;
int m = p.Length;
int c = 0;
for (int i = 0; i <= n - m; i++)
{
    bool gasit = true;
    for (int j = 0; j < m; j++)
    {
        if (s[i + j] != p[j])
        {
            gasit = false;
            break;
        }
    }
    if (gasit)
    {
        c++;
    }
}

Console.WriteLine(c);