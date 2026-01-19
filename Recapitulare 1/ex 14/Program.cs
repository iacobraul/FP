//14. Determianti daca un numar n este palindrom.
int n = int.Parse(Console.ReadLine());
int c = n, inv = 0;
while(c != 0)
{
    inv = inv * 10 + c % 10;
    c = c / 10;
}
if(n == inv)
{
    Console.WriteLine("Nr este palindrom");
}
else
{
    Console.WriteLine("Nr NU este palindrom");
}
