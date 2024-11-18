using _241118;
using System.Text;

List<Class1> lista = [];

using StreamReader sr = new("berek20201.txt", Encoding.UTF8);
while (!sr.EndOfStream)
{
    lista.Add(new(sr.ReadLine()));
}

Console.WriteLine($"3. a dolgozok száma:{lista.Count}");

int ossz = 0;
for (int i = 0; i < lista.Count; i++) 
{
    ossz += lista[i].ber;
}
Console.WriteLine($"4. Bérek átlaga:{ossz/lista.Count/1000:0.0} eFt");

Console.Write($"5.feladat:Kérem a részleg nevét:");

string  reszleg= Console.ReadLine();
bool sv = false;
int ber = 0;
string nev = "";
string nem = "";
int belepes = 0;
for (int i = 0; i< lista.Count;i++) {
    if (lista[i].reszleg==reszleg)
    {
        sv = true;
        if (ber < lista[i].ber)
        {
            ber = lista[i].ber;
            nev= lista[i].nev;
            nem = lista[i].neme;
            belepes = lista[i].belepes;
        }
    }
}
if (sv)
{
    Console.WriteLine("6. feladat:");
    Console.WriteLine($"\tnev:{nev}");
    Console.WriteLine($"\tNem:{nem}");
    Console.WriteLine($"\tBelepes:{belepes}");
    Console.WriteLine($"\tBer:{ber}");
}
else Console.WriteLine("A megadott reszleg nem letezik a cegnel");

    var xx=lista.GroupBy(s => s.reszleg);
    Console.WriteLine($"7. Feladat :Statisztika");
    foreach (var g in xx) 
    {
        Console.WriteLine($"\t{(g.Key)} - {(g.Count())} fő");
    }
