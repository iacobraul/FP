//7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa
int n, max, min;

string input=Console.ReadLine();
string[] tokens=input.Split(' ');

n=int.Parse(tokens[0]);
max=int.Parse(tokens[1]);
min=int.Parse(tokens[1]);

for(int i = 2 ; i <= n; i++)
{
    int x = int.Parse(tokens[i]);
    if(x>max)
        max=x;
    if(x<min)
        min=x;
}

Console.WriteLine($"Minim: {min}, Maxim:{max}");