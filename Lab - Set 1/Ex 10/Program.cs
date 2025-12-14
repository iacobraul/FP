//10. Test de primalitate: determinati daca un numar n este prim
int n;

n= int.Parse(Console.ReadLine());

bool estePrim=true;
for(int i=2;i<n;i++)
{
    if(n%i==0)
    {
        estePrim=false;
        break;
    }
}

if (estePrim)
{
    Console.WriteLine($"{n} este prim");
}
else
{
    Console.WriteLine($"{n} nu este prim");
}