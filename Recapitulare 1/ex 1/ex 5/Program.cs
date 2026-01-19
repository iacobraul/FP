//5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga
int n, k, c;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

n = int.Parse(tokens[0]);
k = int.Parse(tokens[1]);

c = (n / (int)Math.Pow(10, k - 1)) % 10;

Console.WriteLine($"A {k}-a cifra este {c}");