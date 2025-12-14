//5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar
int n, k;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

n = int.Parse(tokens[0]);
k = int.Parse(tokens[1]);

int cifra = (n / (int)Math.Pow(10, k - 1)) % 10;
Console.WriteLine(cifra);