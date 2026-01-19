//18. Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2
int n = int.Parse(Console.ReadLine());
int d = 2;

while(n > 1)
{
    int p = 0;
    while(n % d == 0)
    {
        p++;
        n = n / d;
    }
    if(p > 0)
    {
        if(n>1) Console.Write($"{d}^{p} x ");
        else Console.Write($"{d}^{p}");
    }
    d++;
}
