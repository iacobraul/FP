//5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0
int n, c = 0;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

n = int.Parse(tokens[0]);

for(int i = 0; i < n; i++)
{
    int x = int.Parse(tokens[i + 1]);
    if (x == i)
        c++; ;
}

Console.WriteLine(c);