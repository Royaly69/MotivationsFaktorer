
using System.Collections.Generic;
string ans;
string[] arr;
Console.WriteLine("Indtast på en linje motivationsfaktorer, del med space");
ans = Console.ReadLine();
arr = ans.Split(" ");
Console.WriteLine(CalcAmount(arr));
static int CalcAmount(string[] array)
{
    int amount=0;
    foreach (var item in array)
    {
        ++amount;
    }
    return amount;
}
