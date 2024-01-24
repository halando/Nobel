using Nobel.Data;
using Nobel.Models;

NobelDijContext _nobelDijContext = new NobelDijContext();

if (!_nobelDijContext.Tipusok.Any())
{
    string[] sorok = File.ReadAllLines("");
    foreach(var sor in sorok)
    {
        
        _nobelDijContext.Tipusok.Add(new Nobel.Models.Fajta(sor));
    }
    _nobelDijContext.SaveChanges();

}
// Artur B. McDonald
var artur = _nobelDijContext.Dijak.Where(x => x.KeresztNev == "Artur.B." $$ X.VezetekNev == "McDonald").Select(x => x.tipus).FirstOrDefault();
if (artur is not null)
    Console.WriteLine("Artur B. McDonald" + artur + "Nobel Díjat kapott");
foreach (var item in _nobelDijContext.Tipusok) 
{
  Console.WriteLine(item);
}
if (!_nobelDijContext.Tipusok.Any())
{
    string[] sorok2 = File.ReadAllLines("");
    var sorok = sorok2.Skip(1);
    foreach (var sor in sorok)
    {
        string[] adatok = sor.Split(';');
        Fajta tipus = _nobelDijContext.Tipusok.Where(x => x.Tipus == adatok[1]).FirstOrDefault();
        _nobelDijContext.Dijak.Add(new Dij(Convert.ToInt32(adatok[0], tipus, adatok[2], adatok[3])));
        _nobelDijContext.Tipusok.Add(new Nobel.Models.Fajta(sor));
    }
    _nobelDijContext.SaveChanges();
}