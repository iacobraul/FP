//31. (Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).
//Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara). 
int[] v = { 2, 3, 1, 2, 3, 2, 4, 3, 3, 3, 3, 3 };
int n = v.Length;
int cnt = 0, m = -1;

for (int i = 0; i < n - 1; i++)
{
    cnt = 1;
    for(int j = i + 1; j < n; j++)
    {
        if (v[i] == v[j])
        {
            cnt++;
        }
        if(cnt > n / 2)
        {
            m = v[i];
            break;
        }
    }
}

if(m != -1)
{
    Console.WriteLine("Elementul majoritate este: " + m);
}
else
{
    Console.WriteLine("Nu exista");
}