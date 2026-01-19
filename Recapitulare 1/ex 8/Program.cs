//8.  Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare
int a, b;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

a = int.Parse(tokens[0]);
b = int.Parse(tokens[1]);

(a, b) = (b, a);
Console.WriteLine($"a={a}, b={b}");
