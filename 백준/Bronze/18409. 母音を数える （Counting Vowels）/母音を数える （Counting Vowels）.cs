Console.ReadLine();
int count = 0;
string str = Console.ReadLine();
foreach(var item in str){
    if(item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
        count++;
}
Console.WriteLine(count);