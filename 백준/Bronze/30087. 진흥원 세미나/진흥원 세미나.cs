Dictionary<string, string> dict = new Dictionary<string, string>();
dict.Add("Algorithm", "204");
dict.Add("DataAnalysis", "207");
dict.Add("ArtificialIntelligence", "302");
dict.Add("CyberSecurity", "B101");
dict.Add("Network", "303");
dict.Add("Startup", "501");
dict.Add("TestStrategy", "105");

int n = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    Console.WriteLine(dict[Console.ReadLine()]);
}