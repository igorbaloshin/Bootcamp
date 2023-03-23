using System.Diagnostics;

Console.Clear();

int[] array = 1_000_000.Create()
                .Fill(1, 10);
// array.ConvertToStringAndPrintToTerminal();



int m = 100;   // Количесто чисел последовательности
Stopwatch sw = new Stopwatch();
sw.Start();

int max = array.BadGetSum(m);
sw.Stop();

Console.WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds}");

sw.Reset();
sw.Start();
max = array.GoodGetSum(m);
sw.Stop();
Console.WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");

// Console.WriteLine(array.ConvertToString());
