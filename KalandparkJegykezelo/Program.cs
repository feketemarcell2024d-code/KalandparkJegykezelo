using KalandparkJegykezelo;

string[] sorok = File.ReadAllLines("jegyek.txt");
List<Jegyvasarlas> jegyvasarlasok = new List<Jegyvasarlas>();

foreach (string sor in sorok)
