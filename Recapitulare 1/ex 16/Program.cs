//16. Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
int a, b, c, d, e;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
a = int.Parse(tokens[0]);
b = int.Parse(tokens[1]);
c = int.Parse(tokens[2]);
d = int.Parse(tokens[3]);
e = int.Parse(tokens[4]);

if (a > b) (a, b) = (b, a);
if (a > c) (a, c) = (c, a);
if (a > d) (a, d) = (d, a);
if (a > e) (a, e) = (e, a);

if (b > c) (b, c) = (c, b);
if (b > d) (b, d) = (d, b);
if (b > e) (b, e) = (e, b);

if (c > d) (c, d) = (d, c);
if (c > e) (c, e) = (e, c);

if (d > e) (d, e) = (e, d);

Console.WriteLine($"{a} {b} {c} {d} {e}");