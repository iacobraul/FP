//31. (Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara)
int n, m;

n = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] tokens = input.Split(' ');

int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

for (int i = 0; i < n; i++)
{
    int c = 0;
    for (int j = 0; j < n; j++)
    {
        if (v[i] == v[j])
        {
            c++;
        }
    }
    if (c > n / 2)
    {
        m = v[i];
        Console.WriteLine(m);
        return;
    }
}

Console.WriteLine("Nu exista");
