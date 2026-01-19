//22. Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi).
//Elementele care se repeta vor fi scrise o singura data in rezultat
using System.Net.Http.Headers;

int[] v1 = { 1, 2, 3, 4, 5, 5, 6 };
int[] v2 = { 4, 5, 6, 7, 8, 8, 9 };

HashSet<int> set1 = new HashSet<int>(v1);
HashSet<int> set2 = new HashSet<int>(v2);

HashSet<int> intersectie = new HashSet<int>(set1);
intersectie.IntersectWith(set2);
Console.WriteLine("Intersectia: " + string.Join(", ", intersectie));

HashSet<int> reuniune = new HashSet<int>(set1);
reuniune.UnionWith(set2);
Console.WriteLine("Reuniune: " + string.Join(", ", reuniune));

HashSet<int> diferentaV1V2 = new HashSet<int>(set1);
diferentaV1V2.ExceptWith(set2);
Console.WriteLine("V1 - V2: " + string.Join(", ", diferentaV1V2));

HashSet<int> diferentaV2V1 = new HashSet<int>(set2);
diferentaV2V1.ExceptWith(set1);
Console.WriteLine("V2 - V1: " + string.Join(", ", diferentaV2V1));
