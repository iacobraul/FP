//18.Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector.
//Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x.
int[] v = { 3, 0, 2 }; // reprezinta polinomul 2x^2 + 0x + 3
int n = v.Length;

int x = int.Parse(Console.ReadLine());
int rez = 0;
for(int i = 0; i < n; i++)
{
    rez = rez + v[i] * (int)Math.Pow(x, i);
}

Console.WriteLine(rez);
