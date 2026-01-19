//17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.
//Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor.
//De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta
string input = Console.ReadLine();
string[] tokens = input.Split(' ');
int n = tokens.Length;
int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

int nivelIncuibare = 0, c = 0;
for(int i = 0; i < n; i++)
{
    if (v[i] == 0)
    { 
        c++;
        if(c > nivelIncuibare)
            nivelIncuibare = c;
    }
    if (v[i] == 1)
    {
        c--;
        if (c < 0)
        {
            Console.WriteLine("Secventa de paranteze este incorecta");
            return;
        }
    }
}
if(c != 0)
{
    Console.WriteLine("Secventa de paranteze este incorecta");
}
else
{
    Console.WriteLine("Secventa de paranteze este corecta");
    Console.WriteLine($"Nivelul maxim de incuibare este: {nivelIncuibare}");
}