using KalandparkJegykezelo;
using System.IO.Pipes;

string[] sorok = File.ReadAllLines("jegyek.txt");
List<Jegyvasarlas> jegyvasarlasok = new List<Jegyvasarlas>();

foreach (string sor in sorok)
{
    jegyvasarlasok.Add(new Jegyvasarlas(sor));
}

Console.WriteLine($"Összesen {jegyvasarlasok.Count} jegyvásárlás történt.");


foreach (Jegyvasarlas j in jegyvasarlasok)
{
    Console.WriteLine(j);
}


