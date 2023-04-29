using System;
using System.Collections;
using System.Dynamic;

namespace DataStructures // Note: actual namespace depends on the project name.
{
    internal class Program:Class1<T>
    {
        static void Main(string[] args)
        {
            var p0 = new DataStructures.Class1<int>(1, 2, 3, 4, 5, 6, 7, 8);
            var p1 = new int[] {8,8,9,10};
            var p2 = new List<int>() { 5,10,15,20,25};
            var p3 = new ArrayList() { 5, 10, 5, 53, 77 };

            var arr = new DataStructures.Class1<int>(p1);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }

    }

}
/*
             *     var arrObj = new List<string>();
                        arrObj.Add("a");
                        arrObj.Add("b");
                        arrObj.Add("c");

                        foreach (var item in arrObj)
                        {
                            Console.WriteLine(item);
                        }
                    }
            */

/*
var obj = Array.CreateInstance(typeof(int),5);

obj.SetValue(155, 0);
obj.SetValue(255, 1);
obj.SetValue(199, 2);
obj.SetValue(2, 3);
obj.SetValue(3, 4);

foreach (var item in obj)
{
   Console.WriteLine(item);
}


var arrInt = new List<int>();

arrInt.Add(1);
arrInt.Add(2);

arrInt.AddRange(new int[] { 1, 2, 3 });
arrInt.RemoveAt(4);

foreach (int i in arrInt)
{
    Console.WriteLine(i);
}

arrInt.Clear();
*/

/*
 *  Böyle yazma yerine yapıcının içinden çağırabiliriz
    arr.Add(11);
    arr.Add(21);
    arr.Add(15);
    arr.Add(24);
     *  foreach (var item in arr)
    {
        Console.WriteLine(item);
    }
      arr.Where(x => x%2 == 1).ToList().ForEach(x => Console.WriteLine(x));

    arr.Remove();

    Console.WriteLine($" {arr.Count} /{arr.Capacity}");
    Console.ReadLine();
 */

