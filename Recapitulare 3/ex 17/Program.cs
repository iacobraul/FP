//17. Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b
int n = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

string cifre = "0123456789ABCDEF";
string r = "";
while(n > 0)
{
    r = cifre[n % b] + r;
    n = n / b;
}

Console.Write(r);