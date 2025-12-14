//1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare
int a, b;
float x;

string input=Console.ReadLine();
string[] tokens=input.Split(' ');

a=int.Parse(tokens[0]);
b=int.Parse(tokens[1]);
x = -1f * b / a;

Console.WriteLine(x);
