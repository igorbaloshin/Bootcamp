using static Sorting;
using static System.Console;

Clear();
int size = 10;
//var arr = size.CreateArray(min:1, max:10)
size.CreateArray(min:1, max:10)
            .Show()
            .SortQuick(0, size - 1)
            .Show()
            ;
