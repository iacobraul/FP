//17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.
int a, b, cmmdc, cmmmc;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

a = int.Parse(tokens[0]);
b = int.Parse(tokens[1]);

int x = a, y = b;
while(y != 0)
{
    int r = x % y;
    x = y;
    y = r;
}

cmmdc = x;
cmmmc = (a * b) / cmmdc;

Console.WriteLine($"CMMDC: {cmmdc}, CMMMC: {cmmmc}");