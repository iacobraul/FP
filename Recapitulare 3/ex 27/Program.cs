//27.  Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat.
int[] v = { 5, 3, 8, 1, 2 };
int index = int.Parse(Console.ReadLine());

//V1
//Array.Sort(v);
//Console.WriteLine(v[index]);

for(int i = 0; i < v.Length - 1; i++)
{
    for(int j = i + 1; j < v.Length; j++)
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