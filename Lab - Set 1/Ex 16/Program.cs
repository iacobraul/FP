//16. Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
int x1,x2, x3, x4, x5;

string input= Console.ReadLine();
string[] tokens= input.Split(' ');

x1= int.Parse(tokens[0]);
x2= int.Parse(tokens[1]);
x3= int.Parse(tokens[2]);
x4= int.Parse(tokens[3]);
x5= int.Parse(tokens[4]);

SortNumbers(ref x1, ref x2);
SortNumbers(ref x1, ref x3);
SortNumbers(ref x1, ref x4);
SortNumbers(ref x1, ref x5);

SortNumbers(ref x2, ref x3);
SortNumbers(ref x2, ref x4);
SortNumbers(ref x2, ref x5);

SortNumbers(ref x3, ref x4);
SortNumbers(ref x3, ref x5);

SortNumbers(ref x4, ref x5);

Console.WriteLine($"{x1},{x2},{x3},{x4},{x5}");

void SortNumbers(ref int x1,ref int x2)
{
    if(x1 > x2)
    { 
        int temp = x1;
        x1 = x2;
        x2 = temp;
    }
}