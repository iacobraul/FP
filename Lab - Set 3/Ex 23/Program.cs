//23.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare

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

Console.WriteLine("Reuniunea: " + string.Join(", ", Reuniune(v1, v2)));
Console.WriteLine("Intersectia: " + string.Join(", ", Intersectie(v1, v2)));
Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", DiferentaV1V2(v1, v2)));
Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", DiferentaV2V1(v1, v2)));

List<int> Reuniune(int[] v1, int[] v2)
{
    List<int> rez = new List<int>();
    int i = 0, j = 0;

    while (i < v1.Length && j < v2.Length)
    {
        if (v1[i] < v2[j])
        {
            rez.Add(v1[i]);
            i++;
        }
        else if (v2[j] < v1[i])
        {
            rez.Add(v2[j]);
            j++;
        }
        else
        {
            rez.Add(v1[i]);
            i++;
            j++;
        }
    }

    while (i < v1.Length) rez.Add(v1[i++]);
    while (j < v2.Length) rez.Add(v2[j++]);

    return rez;
}

List<int> Intersectie(int[] v1, int[] v2)
{
    List<int> rez = new List<int>();
    int i = 0, j = 0;

    while (i < v1.Length && j < v2.Length)
    {
        if (v1[i] < v2[j]) i++;
        else if (v2[j] < v1[i]) j++;
        else
        {
            rez.Add(v1[i++]);
            j++;
        }
    }
    return rez;
}

List<int> DiferentaV1V2(int[] v1, int[] v2)
{
    List<int> rez = new List<int>();
    int i = 0, j = 0;

    while (i < v1.Length && j < v2.Length)
    {
        if (v1[i] < v2[j])
        {
            rez.Add(v1[i]);
            i++;
        }
        else if (v1[i] > v2[j]) j++;
        else
        {
            i++;
            j++;
        }
    }

    while (i < v1.Length)
    {
        rez.Add(v1[i]);
        i++;
    }
    return rez;
}

List<int> DiferentaV2V1(int[] v1, int[] v2)
{
    List<int> rez = new List<int>();
    int i = 0, j = 0;

    while (j < v1.Length && i < v2.Length)
    {
        if (v2[i] < v1[j])
        {
            rez.Add(v2[i]);
            i++;
        }
        else if (v2[i] > v1[j]) j++;
        else
        {
            i++;
            j++;
        }
    }

    while (i < v2.Length)
    {
        rez.Add(v2[i]);
        i++;
    }
    return rez;
}

