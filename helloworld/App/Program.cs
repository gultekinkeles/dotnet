using System;
using System.Threading.Tasks;
 
var counter = 0;
 
while (true)
{ 
    Console.WriteLine($"Hello: {++counter}");
    await Task.Delay(TimeSpan.FromMilliseconds(1_000));
}