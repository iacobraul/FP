//26. Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere.

string inputV1 = Console.ReadLine();
string[] tokensV1 = inputV1.Split(' ');
int[] v1 = new int[tokensV1.Length];

string inputV2 = Console.ReadLine();
string[] tokensV2 = inputV2.Split(' ');
int[] v2 = new int[tokensV2.Length];

for (int a = 0; a < v1.Length; a++)
{
    v1[a] = int.Parse(tokensV1[a]);
}
for (int a = 0; a < v2.Length; a++)
{
    v2[a] = int.Parse(tokensV2[a]);
}

List<int> suma = new List<int>();
int i = v1.Length - 1, j = v2.Length - 1, carry = 0;
while (i >= 0 || j >= 0 || carry > 0)
{
    int cifra1 = (i >= 0) ? v1[i--] : 0;
    int cifra2 = (j >= 0) ? v2[j--] : 0;
    suma.Add((cifra1 + cifra2 + carry) % 10);
    carry = (cifra1 + cifra2 + carry) / 10;
}
suma.Reverse();
Console.WriteLine(string.Join("", suma));


List<int> diferenta = new List<int>();
i = v1.Length - 1; j = v2.Length - 1; int imprumut = 0;
while (i >= 0 || j >= 0)
{
    int cifra1 = (i < v1.Length) ? v1[i--] : 0;
    int cifra2 = (j < v2.Length) ? v2[j--] : 0;
    int diff = cifra1 - cifra2 - imprumut;
    if (diff < 0)
    {
        diff += 10;
        imprumut = 1;
    }
    else
    {
        imprumut = 0;
    }
    diferenta.Add(diff);
}
diferenta.Reverse();
Console.WriteLine(string.Join("", diferenta));


int n1 = v1.Length;
int n2 = v2.Length;
int[] rezultat = new int[n1 + n2];
for (i = n1 - 1; i >= 0; i--)
{
    for (j = n2 - 1; j >= 0; j--)
    {
        int p = v1[i] * v2[j];
        int sum = p + rezultat[i + j + 1];
        rezultat[i + j + 1] = sum % 10;
        rezultat[i + j] += sum / 10;
    }
}
List<int> produs = new List<int>(rezultat);
Console.WriteLine(string.Join("", produs));
