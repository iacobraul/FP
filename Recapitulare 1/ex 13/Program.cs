//13. Determianti cati ani bisecti sunt intre anii y1 si y2
int y1, y2, c = 0;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

y1 = int.Parse(tokens[0]);
y2 = int.Parse(tokens[1]);

for(int i = y1; i <= y2; i++)
{
       if((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
    {
        c++;
    }
}
Console.WriteLine(c);