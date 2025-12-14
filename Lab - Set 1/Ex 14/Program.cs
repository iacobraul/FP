//14. Determianti daca un numar n este palindrom
int n, inv = 0, c = 0;

n= int.Parse(Console.ReadLine());
c = n;

while (c > 0)
{
    inv= inv*10 + c%10;
    c = c/10;
}

if(n == inv)
    Console.WriteLine("Numarul este palindrom");
else
    Console.WriteLine("Numarul nu este palindrom");
