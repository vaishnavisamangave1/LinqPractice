//using System;
//using System.ComponentModel;
//using System.Security.Cryptography.X509Certificates;
//using System.Xml.Linq;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace LinqPractice;


//public class LinqExamples
//{
//    public delegate int Mydel(int x, int y);

//    public static void Main(string[] args)
//    {

//        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

//        //numbers.ToList().ForEach(num => Console.WriteLine(num));

//        //foreach (var num in numbers)
//        //{
//        //    Console.WriteLine(num);
//        //}

//        //var res= numbers.Select(num =>num).ToArray();
//        // foreach (var i in res)
//        // {

//        //     Console.WriteLine(i);
//        // }

//        //int sum = numbers.Sum();
//        //Console.WriteLine(sum);

//        //var even = numbers.Where(x => x % 2 == 0).ToArray();
//        //foreach (var number in even)
//        //{
//        //    Console.WriteLine(number);
//        //}

//        //var evenSum = numbers.Where(x => x % 2 == 0).Sum();
//        //Console.WriteLine(evenSum);

//        //var oddsum = numbers.Where(x => x % 2 != 0).Sum();
//        //Console.WriteLine(oddsum);
//        //foreach(var number in evenSum)
//        //{
//        //    Console.WriteLine(number);
//        //}
//        //var oddCount = numbers.Where(x => x % 2 != 0).Count();
//        //Console.WriteLine(oddCount);

//        //var evenCount=numbers.Where(x=> x %2==0).Count();
//        //Console.WriteLine(evenCount);

//        // var sortEle = numbers.OrderByDescending(x => x);

//        // foreach(var ele in sortEle) Console.WriteLine(ele);
//        // //        Sort an array in ascending order.
//        //  var sortele1 = numbers.OrderBy(x => x).ToArray();
//        // Console.WriteLine("elements:" + sortele1);

//        // foreach( var sortele2 in sortele1) Console.WriteLine("elements:" + sortele2);


//        ////desc

//        // var sortDesc=numbers.OrderByDescending(x => x).ToArray();
//        // foreach(var sort3 in sortDesc) Console.WriteLine(sort3);
//        //Search for a given element in an array and print its index.

//        //Remove duplicate elements from an array.
//        //Find the second largest number in an array.

//        var secondLast = numbers.OrderByDescending(x => x).Skip(2).ToArray();
//        Console.WriteLine(secondLast);

//        //Merge two arrays into a single array.











//    }
//}