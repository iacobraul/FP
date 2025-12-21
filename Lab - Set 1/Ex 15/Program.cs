//15. Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
int a, b, c;

string input= Console.ReadLine();
string[] tokens= input.Split(' ');

a= int.Parse(tokens[0]);
b= int.Parse(tokens[1]);
c= int.Parse(tokens[2]);

int[] v= new int[3]{a,b,c};
Array.Sort(v);

Console.WriteLine($"{v[0]},{v[1]},{v[2]}");