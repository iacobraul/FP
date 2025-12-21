//18. Afisati descompunerea in factori primi ai unui numar n
int n;
n = int.Parse(Console.ReadLine());

int d= 2;
while(n > 0)
{   bool factor = false;
    int p = 0;
    while(n% d == 0)
    {
        p++;
        n /= d;
        factor = true;
    }
    if(factor) Console.WriteLine($"{d}^{p}");
    d++;
}