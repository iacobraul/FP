//11. Afisati in ordine inversa cifrele unui numar n
int n;

n= int.Parse(Console.ReadLine());

while (n > 0)
{
    Console.Write(n%10);
    n = n/10;
}
