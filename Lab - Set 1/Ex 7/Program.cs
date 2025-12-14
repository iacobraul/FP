//7. Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor
int a, b, aux;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

a = int.Parse(tokens[0]);
b = int.Parse(tokens[1]);

aux = a;
a = b;
b = aux;

Console.WriteLine($"a = {a}, b = {b}");

