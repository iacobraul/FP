//19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta
long n;
n = long.Parse(Console.ReadLine());

int[] cifre = new int[10];
int c = 0;

for(int i = 0; i <= 9; i++)
    cifre[i] = 0;

while(n > 0)
{ 
    cifre[n % 10]++;
    n /= 10;
}

for (int i = 0; i <= 9; i++)
    if (cifre[i] != 0)
        c++;

if(c == 2)
    Console.WriteLine("Numarul este format din 2 cifre care se pot repeta");
else
    Console.WriteLine("Numarul NU este format din 2 cifre care se pot repeta");