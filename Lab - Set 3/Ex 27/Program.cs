//27. Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat.
int n, index;

n = int.Parse(Console.ReadLine());
string input= Console.ReadLine();
string[] tokens = input.Split(' ');
index = int.Parse(Console.ReadLine());

int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

for(int i = 0; i < n - 1; i++)
{
    for(int j = i + 1; j < n; j++)
    {
        if(v[i] > v[j])
        {
            int temp = v[i];
            v[i] = v[j];
            v[j] = temp;
        }
    }
}
Console.WriteLine(v[index]);
