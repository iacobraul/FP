//20. Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem

string inputS1 = Console.ReadLine();
string[] tokensS1 = inputS1.Split(' ');
string[] s1 = new string[tokensS1.Length];

string inputS2 = Console.ReadLine();
string[] tokensS2 = inputS2.Split(' ');
string[] s2 = new string[tokensS2.Length];

for(int i = 0; i < s1.Length; i++)
{
    s1[i] = tokensS1[i];
}
for(int i = 0; i < s2.Length; i++)
{
    s2[i] = tokensS2[i];
}

int n1 = s1.Length;
int n2 = s2.Length;
int c = 0;
for(int i = 0;i < n1; i++)
{
    bool suprapunere = true;
    for (int j = 0; j < n2; j++)
    {
        if(s1[(i + j) % n1] != s2[j])
        {
            suprapunere = false;
        }
    }
    if (suprapunere) c++;
}

Console.WriteLine(c);
