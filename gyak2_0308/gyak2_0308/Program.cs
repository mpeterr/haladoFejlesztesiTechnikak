// See https://aka.ms/new-console-template for more information
using gyak2_0308;
using System.Xml.Linq;

XDocument doc = XDocument.Load("02_war_of_westeros.xml");

//Q0. Elokeszuletek
var names = doc.Descendants("name").Select(x => x.Value).ToList();
names.ToConsole("Q0. Elokeszuletek");


//Q1. Hány ház vett részt a csatákban?
Console.WriteLine("Q1. Hány ház vett részt a csatákban ?\n" + doc
    .Descendants("house")
    .Select(x => x.Value)
    .Distinct()
    .Count() + " ház vett részt a csatákban\n");
    //.ToConsole("Q1. Hány ház vett részt a csatákban ?");

//Q2. Listázzuk az „ambush” típusú csatákat!
var ambushBattles = doc
    .Descendants("battle")
    .Where(battle => battle.Element("type")?.Value == "ambush")
    .Descendants("name").Select(n => n.Value);
ambushBattles.ToConsole("Q2. Listázzuk az \"ambush\" típusú csatákat!");

var ambushBattles2 = from battleNode in doc.Descendants("battle")
                     where battleNode.Element("type")?.Value == "ambush"
                     select battleNode.Element("name")?.Value;
ambushBattles2.ToConsole("Q2. Listázzuk az \"ambush\" típusú csatákat! MÁSHOGY");

//Q3. Hány olyan csata volt, ahol a védekező sereg győzött, és volt híres fogoly?
Console.WriteLine("Q3. Hány olyan csata volt, ahol a védekező sereg győzött, és volt híres fogoly?\n" + doc
    .Descendants("battle")
    .Where(battle => battle.Element("outcome")?.Value == "defender" && battle.Element("majorcapture")?.Value != "0")
    .Select(x => x.Value)
    .Count() + " ilyen csata volt\n");








