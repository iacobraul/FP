//12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]
int n, a, b, c = 0;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

n= int.Parse(tokens[0]);
a= int.Parse(tokens[1]);
b= int.Parse(tokens[2]);

for(int i = a; i <= b; i++)
{
    if (i % n == 0)
        c++;
}

Console.WriteLine(c);