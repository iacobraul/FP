//Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?"
int a = 1, b = 1024;
while(a < b)
{
    int m = (a + b + 1) / 2;
    Console.WriteLine($"Numarul este mai mare sau egal decat {m}? (da/nu)");
    string raspuns = Console.ReadLine().ToLower();
    if(raspuns == "da")
    {
        a = m;
    }
    else
    {
        b = m - 1;
    }
}
Console.WriteLine($"Numarul ghicit este {a}");