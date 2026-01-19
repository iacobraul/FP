//26. Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere.
int[] v1 = { 1, 1, 2 };
int[] v2 = { 1, 2 };

int n1 = v1.Length;
int n2 = v2.Length;

// Suma
List<int> suma = new List<int>();
int carry = 0;
int i = n1 - 1;
int j = n2 - 1;

while (i >= 0 || j >= 0 || carry > 0)
{ 
    int cifra1, cifra2;
    if (i >= 0)
    {
        cifra1 = v1[i];
        i--;
    }
    else cifra1 = 0;

    if(j >= 0)
    {
        cifra2 = v2[j];
        j--;
    }
    else cifra2 = 0;

    int sum = cifra1 + cifra2 + carry;
    suma.Add(sum % 10);
    carry = sum / 10;
}

suma.Reverse();
Console.Write("Suma: " + string.Join("", suma));
Console.WriteLine();

// Diferenta
List<int> diferenta = new List<int>();
i = n1 - 1; j = n2 - 1;
int imprumut = 0;

while (i >= 0 || j >= 0)
{
    int cifra1, cifra2;
    if (i >= 0)
    {
        cifra1 = v1[i];
        i--;
    }
    else cifra1 = 0;

    if (j >= 0)
    {
        cifra2 = v2[j];
        j--;
    }
    else cifra2 = 0;

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
if (diferenta[0] == 0)
{
    diferenta.RemoveAt(0);
}

Console.Write("Diferenta: " + string.Join("", diferenta));
Console.WriteLine();

// Produs
int[] produs = new int[n1 + n2];
for (i = n1 - 1; i >= 0; i--)
{
    int carryProd = 0;
    for (j = n2 - 1; j >= 0; j--)
    {
        int mul = v1[i] * v2[j] + produs[i + j + 1] + carryProd;
        produs[i + j + 1] = mul % 10;
        carryProd = mul / 10;
    }
    produs[i + j + 1] += carryProd;
}

List<int> rezultat = new List<int>(produs);
if(rezultat[0] == 0)
{
    rezultat.RemoveAt(0);
}

Console.Write("Produs: " + string.Join("", rezultat));