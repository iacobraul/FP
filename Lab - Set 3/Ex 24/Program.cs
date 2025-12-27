//24. Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar)

string inputV1 = Console.ReadLine();
string[] tokensV1 = inputV1.Split(' ');
int[] v1 = new int[tokensV1.Length];

string inputV2 = Console.ReadLine();
string[] tokensV2 = inputV2.Split(' ');
int[] v2 = new int[tokensV2.Length];

for (int i = 0; i < v1.Length; i++)
{
    v1[i] = int.Parse(tokensV1[i]);
}
for (int i = 0; i < v2.Length; i++)
{
    v2[i] = int.Parse(tokensV2[i]);
}

int[] reuniune = new int[v1.Length];
int[] intersectie = new int[v1.Length];
int[] diferentaV1V2 = new int[v1.Length];
int[] diferentaV2V1 = new int[v1.Length];

for (int i = 0;i < v1.Length;i++)
{
    if(v1[i] == 1 || v2[i] == 1)
        reuniune[i] = 1;
    else reuniune[i] = 0;

    if (v1[i] == 1 && v2[i] == 1)
        intersectie[i] = 1;
    else intersectie[i] = 0;

    if (v1[i] == 1 && v2[i] == 0)
        diferentaV1V2[i] = 1;
    else diferentaV1V2[i] = 0;

    if (v2[i] == 1 && v1[i] == 0)
        diferentaV2V1[i] = 1;
    else diferentaV2V1[i] = 0;
}

Console.Write("Reuniunea: ");
for (int i = 0; i < reuniune.Length; i++)
{
    Console.Write(reuniune[i] + " ");
}
Console.WriteLine();

Console.Write("Intersectia: ");
for (int i = 0; i < intersectie.Length; i++)
{
    Console.Write(intersectie[i] + " ");
}
Console.WriteLine();

Console.Write("Diferenta v1 - v2: ");
for (int i = 0; i < diferentaV1V2.Length; i++)
{
    Console.Write(diferentaV1V2[i] + " ");
}
Console.WriteLine();

Console.Write("Diferenta v2 - v1: ");
for (int i = 0; i < diferentaV2V1.Length; i++)
{
    Console.Write(diferentaV2V1[i] + " ");
}
