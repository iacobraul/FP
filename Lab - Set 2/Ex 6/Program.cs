//6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare
int n, x, y;
bool crescator = true;

string input=Console.ReadLine();
string[] tokens=input.Split(' ');

n=int.Parse(tokens[0]);
x=int.Parse(tokens[1]);
for(int i = 2 ; i <= n; i++)
{
    y = int.Parse(tokens[i]);
    if(x>y)
    {
        crescator=false;
        break;
    }
    x=y;
}

if(crescator)
    Console.WriteLine("Numerele sunt in ordine crescatoare");
else
    Console.WriteLine("Numerele nu sunt in ordine crescatoare");