//3. Determinati daca n se divide cu k, unde n si k sunt date de intrare
int n, k;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

n = int.Parse(tokens[0]);
k = int.Parse(tokens[1]);

if (n % k == 0)
{
    Console.WriteLine($"{n} se divide cu {k}");
}
else Console.WriteLine($"{n} nu se divide cu {k}");
