//18. Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x
int n, x;
double r = 0;

n = int.Parse(Console.ReadLine());
string input= Console.ReadLine();
string[] tokens = input.Split(' ');
x = int.Parse(Console.ReadLine());

int[] v = new int[n+1];
for (int i = 0; i <= n; i++)
{
    v[i] = int.Parse(tokens[i]);
    r = r + (v[i] * Math.Pow(x, i));
}

Console.WriteLine(r);