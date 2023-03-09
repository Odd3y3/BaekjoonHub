bool[] checkStudent = new bool[31];
for(int i = 0; i < 28; i++)
    checkStudent[int.Parse(Console.ReadLine())] = true;
for (int i = 1; i <= 30; i++)
    if (!checkStudent[i]) Console.WriteLine(i);