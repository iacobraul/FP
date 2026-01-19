//19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.
int n = int.Parse(Console.ReadLine()), c = 0;
int[] cifre = new int[10];

while(n != 0)
{
    cifre[n%10]++;
    n = n / 10;
}
for (int i = 0; i < 10; i++)
{ 
    if(cifre[i] != 0)
    {
        c++;
    }
}
if(c == 2)
{
    Console.WriteLine($"Nr este format din 2 cifre care se repeta");
}
else
{
    Console.WriteLine($"Nr NU este format din 2 cifre care se repeta");
}
