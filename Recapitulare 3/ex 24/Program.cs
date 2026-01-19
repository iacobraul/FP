//24.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).
int[] v1 = { 0, 1, 1, 0, 1, 0, 0, 1 }; // reprezinta multimea {1,2,4,7}
int[] v2 = { 1, 0, 1, 1, 0, 0, 1, 0 }; // reprezinta multimea {0,2,3,6}
int n1 = v1.Length;
int n2 = v2.Length;

int[] reuniune = new int[n1];
int[] intersectie = new int[n1];
int[] diferentaV1V2 = new int[n1];
int[] diferentaV2V1 = new int[n1];

for ( int i = 0; i < n1; i++)
{
    if (v1[i] == 1 || v2[i] == 1)
    {
        reuniune[i] = 1;
    }
    if (v1[i] == 1 && v2[i] == 1)
    {
        intersectie[i] = 1;
    }
    if (v1[i] == 1 && v2[i] == 0)
    {
        diferentaV1V2[i] = 1;
    }
    if (v2[i] == 1 && v1[i] == 0)
    {
        diferentaV2V1[i] = 1;
    }
}

Console.WriteLine("Reuniune: " + string.Join(", ", reuniune));
Console.WriteLine("Intersectie: " + string.Join(", ", intersectie));
Console.WriteLine("V1 - V2: " + string.Join(", ", diferentaV1V2));
Console.WriteLine("V2 - V1: " + string.Join(", ", diferentaV2V1));
