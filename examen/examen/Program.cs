//
//1. Console.WriteLine(suma(22));
//2. Console.WriteLine(diferenta(6));
//3. Console.WriteLine(sumaPrime(10));
//int[] v = { 64, 25, 12, 22, 11 };
//Selection(v);
//Console.WriteLine(string.Join(", ", v));

//string s = "programare";
//string p = "amare";
//Console.WriteLine(subsir(s, p));
using System.Text.RegularExpressions;

int suma(int n)
{
    int s = 0;
    if (n < 0) return 0;
    for( int i = 10; i <= n; i++)
    {
        if( (i / 10) % 10 == 1) s += i;
    }
    return s;
}

int diferenta(int n)
{   int x = 1, y = 1, i = 2, r = 0;
    while(i <= n -2)
    {
        r = x + y;
        x = y;
        y = r;
        i++;
    }
    return r;
}

int sumaPrime(int n)
{
    int s = 0;
    for( int i = 2; i <= n; i++)
    {
        bool estePrim = true;
        for( int d = 2; d < i; d++)
        {
            if( i % d == 0)
            {
                estePrim = false;
                break;
            }
        }
        if( estePrim) s += i;
    }
    return s;
}
void Selection(int[] v)
{
    int n = v.Length;
    for( int i = 0; i < n - 1; i++)
    {
        int pozMin = i;
        for( int j = i + 1; j < n; j++)
        {
            if( v[j] < v[pozMin]) pozMin = j;
        }
        if( pozMin != i)
        {
            int aux = v[i];
            v[i] = v[pozMin];
            v[pozMin] = aux;
        }
    }

}

int subsir(string s, string p)
{
    for(int i = 0; i < s.Length; i++)
    { 
        if (s[i] == p[0])
        {
            bool subsir = true;
            for(int j = 1; j < p.Length; j++)
            {
                if(s[i + j] != p[j])
                {
                    subsir = false;
                }
            }
            if(subsir) return i;
        }
    }
    return -1;
}

aranjamente(5, 3);
void aranjamente(int n, int k)
{
    for(int i = 1; i <= n; i++)
    {
        int c = 1;
        generare(i, c);
    }
    void generare(int a, int b)
    {
        if(b < k)
        {
            Console.Write($"{a}, ");
            while(a < n)
            {
                generare(a + 1, b + 1);
                a++;
            }
        }
        if(b == k)
        {
            Console.WriteLine(a);
        }
    }
}