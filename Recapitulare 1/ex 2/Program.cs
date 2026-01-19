//2.Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile
int a, b, c, delta;
double x1, x2;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

a = int.Parse(tokens[0]);
b = int.Parse(tokens[1]);
c = int.Parse(tokens[2]);
delta = b * b - 4 * a * c;

if (delta > 0)
{
    x1 = ((-1) * b + Math.Sqrt(delta)) / 2 * a;
    x2 = ((-1) * b - Math.Sqrt(delta)) / 2 * a;
    Console.WriteLine($"Solutiile sunt: x1 = {x1}, x2 = {x2}");
}
else if (delta == 0)
{
    x1 = ((-1) * b) / 2 * a;
    Console.WriteLine($"Solutiile sunt: x1 = x2 = {x1}");
}
else Console.WriteLine($"Ecuatia nu are solutii");