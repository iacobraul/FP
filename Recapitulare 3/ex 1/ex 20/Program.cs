//20. Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2.
//Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare.
//Siragurile de margele se pot roti atunci cand le suprapunem. 
char[] s1 = { 'A', 'N', 'A', 'B', 'A', 'N', 'A' }; // A - alba, N - neagra
char[] s2 = { 'N', 'A', 'B', 'A', 'N', 'A', 'A' };

int n = s1.Length;
int m = s2.Length;
int cnt = 0;

for(int i = 0; i < n; i++)
{
    bool suprapunere = true;
    for (int j = 0; j < m; j++)
    {
        if (s1[(i+j)%n] != s2[j])
        {
            suprapunere = false;
            break;
        }
    }
    if (suprapunere)
    {
        cnt++;
    }
}

Console.WriteLine(cnt);