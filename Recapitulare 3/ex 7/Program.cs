//7. Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector.
//Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc
int n = int.Parse(Console.ReadLine());

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
int[] v = new int[n];


for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}
for (int i = 0; i < n/2; i++)
{
    (v[i], v[n- 1 - i]) = (v[n - 1 - i], v[i]);    
}

for (int i = 0; i < n; i++)
{
    Console.Write($"{v[i]} ");
}