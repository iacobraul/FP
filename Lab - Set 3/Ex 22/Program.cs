// 22. Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat.

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

HashSet<int> setV1 = new HashSet<int>(v1);
HashSet<int> setV2 = new HashSet<int>(v2);

HashSet<int> intersectie = new HashSet<int>(setV1);
intersectie.IntersectWith(setV2);
Console.WriteLine("Intersectia: " + string.Join(", ", intersectie));

HashSet<int> reuniune = new HashSet<int>(setV1);
reuniune.UnionWith(setV2);
Console.WriteLine("Reuniunea: " + string.Join(", ", reuniune));

HashSet<int> diferentaV1V2 = new HashSet<int>(setV1);
diferentaV1V2.ExceptWith(setV2);
Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", diferentaV1V2));

HashSet<int> diferentaV2V1 = new HashSet<int>(setV2);
diferentaV2V1.ExceptWith(setV1);
Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", diferentaV2V1));