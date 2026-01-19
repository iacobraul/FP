//5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.
//Se considera ca primul element din secventa este pe pozitia 0
int n = int.Parse(Console.ReadLine()), c = 0;
int[] v  = new int[n];

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
for (int i = 0; i < n; i++)
{ 
    v[i] = int.Parse(tokens[i]);
    if (v[i] == i)
        c++;
}
Console.WriteLine(c);