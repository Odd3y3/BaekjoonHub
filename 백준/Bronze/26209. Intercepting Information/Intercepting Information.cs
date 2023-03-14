string result = "S";
string[] arr = Console.ReadLine().Split();
for(int i = 0; i < 8; i++)
{
    if (arr[i] != "0" && arr[i] != "1")
        result = "F";
}
Console.WriteLine(result);