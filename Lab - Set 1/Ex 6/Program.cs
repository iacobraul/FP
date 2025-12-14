//6. Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi
int a, b, c;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

a = int.Parse(tokens[0]);
b = int.Parse(tokens[1]);
c = int.Parse(tokens[2]);

if((a+b > c) && (a + c > b) && (b + c > a))
{
    Console.WriteLine($"{a},{b},{c} pot fi lungimile laturilor unui triunghi");
}
else
{
    Console.WriteLine($"{a},{b},{c} nu pot fi lungimile laturilor unui triunghi");
}