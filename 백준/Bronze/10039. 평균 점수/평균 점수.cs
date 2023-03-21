int sum = 0;
for(int i= 0; i < 5; i++){
    sum += Math.Max(int.Parse(Console.ReadLine()), 40);
}
Console.WriteLine(sum/5);