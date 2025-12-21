//21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?"
int  l = 1, r = 1024;
int x = (l + r) / 2;

while (l < r)
{
    Console.WriteLine($"Numarul este mai mare sau egal decat {x}?");
    string raspuns = Console.ReadLine();
    if (raspuns.ToLower() == "da")
        l = x;
    else
        r= x - 1;
    x = (l + r ) / 2;
}

Console.WriteLine($"Numarul ghicit este {x}");