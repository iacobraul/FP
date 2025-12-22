//4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1
int n, a, x;
bool found = false;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

n = int.Parse(tokens[0]);
a = int.Parse(tokens[1]);
for (int i = 0; i < n; i++)
{
    x = int.Parse(tokens[i+2]);
    if (x == a)
    {
        Console.WriteLine(i);
        found = true;
        break;
    }
}

if (!found) Console.WriteLine("-1");