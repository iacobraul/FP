//2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
int a, b, c;
float x;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

a = int.Parse(tokens[0]);
b = int.Parse(tokens[1]);
c = int.Parse(tokens[2]);

int delta = b*b - 4*a*c;
if(delta < 0) 
{
    Console.WriteLine("Ecuatia nu are solutii");
}
else if(delta == 0) 
{
    x = -b / (2 * a);
    Console.WriteLine($"Ecuatia are o singura solutie: x = {x}");
}
else 
{
    float x1 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
    float x2 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine($"Ecuatia are doua solutii: x1 = {x1}, x2 = {x2}");
}