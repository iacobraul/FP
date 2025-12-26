//17. Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b
int n, b, r = 0;

n = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());

string cifre = "0123456789ABCDEF";
string rez = "";

while (n > 0)
{
    rez = cifre[n % b] + rez;
    n = n / b;
}

Console.WriteLine(rez);