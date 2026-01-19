//15. Se dau 3 numere. Sa se afiseze in ordine crescatoare
string input = Console.ReadLine();
string[] tokens = input.Split(' ');

int[] v  = new int[3];
for(int i = 0; i < 3; i++)
{
    v[i] = int.Parse(tokens[i]);
}
Array.Sort(v);
for(int i = 0; i < 3; i++)
{
    Console.Write($"{v[i]} ");
}