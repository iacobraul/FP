//1.Se da o secventa de n numere. Sa se determine cate din ele sunt pare
int n, x, s=0;

string input= Console.ReadLine();
string[] tokens = input.Split(' ');

n = int.Parse(tokens[0]);
for(int i = 1; i <= n; i++)
{
    x= int.Parse(tokens[i]);
    if(x % 2 == 0)
        s++;
}

Console.WriteLine(s);
