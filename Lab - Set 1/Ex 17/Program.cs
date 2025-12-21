//17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid
int x, y, cmmdc, cmmmc;

string input= Console.ReadLine();
string[] tokens= input.Split(' ');

x= int.Parse(tokens[0]);
y= int.Parse(tokens[1]);

int cx=x, cy=y, r=0;
while(cy != 0)
{
    r= cx % cy;
    cx= cy;
    cy= r;
}

cmmdc = cx;
cmmmc = (x*y)/cmmdc;

Console.WriteLine($"CMMDC= {cmmdc}, CMMMC= {cmmmc}");

