int sum = Console.ReadLine().Split().Select(int.Parse).Sum();
int chicken = int.Parse(Console.ReadLine()) * 2;
if(sum >= chicken)
    Console.WriteLine(sum - chicken);
else
    Console.WriteLine(sum);