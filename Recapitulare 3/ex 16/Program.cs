//16. Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului
int[] v = { 7, 49, 98 };
int n = v.Length;

int i = 0, r = 0;
while (i < n)
{
    r = cmmdc(r, v[i]);
    i++;
}
Console.WriteLine(r);

int cmmdc(int a, int b)
{
    while (b != 0)
    {
        int r = a % b;
        a = b;
        b = r;
    }
    return a;
}