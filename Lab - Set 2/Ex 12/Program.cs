//12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3
int c = 0;

string input = Console.ReadLine();
string[] cuvinte = input.Split('0', StringSplitOptions.RemoveEmptyEntries);

foreach (string cuvant in cuvinte)
{
    string[] numere = cuvant.Split(new char[] { ',',' ' }, StringSplitOptions.RemoveEmptyEntries);
    if (numere.Length > 0)
    {
        c++;
    }
}

Console.WriteLine(c);