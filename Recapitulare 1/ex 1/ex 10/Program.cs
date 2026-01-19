//10. Test de primalitate: determinati daca un numar n este prim
int n = int.Parse(Console.ReadLine());
bool nrPrim = true;

for (int i = 2; i*i<n; i++)
{
    if(n % i == 0)
    {
        nrPrim = false;
        break;
    }
}
if(nrPrim) Console.WriteLine($"{n} este numar prim");
else 
    Console.WriteLine($"{n} nu este numar prim");