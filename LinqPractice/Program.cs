namespace LinqPractice;

public class LinqExamples
{

    public static void Main(string[] args)
    {

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

        //numbers.ToList().ForEach(num => Console.WriteLine(num));

        //foreach (var num in numbers)
        //{
        //    Console.WriteLine(num);
        //}

        //var res= numbers.Select(num =>num).ToArray();
        // foreach (var i in res)
        // {

        //     Console.WriteLine(i);
        // }

        //int sum = numbers.Sum();
        //Console.WriteLine(sum);

        var even = numbers.Where(x => x % 2 == 0).ToArray();
        foreach (var number in even)
        {
            Console.WriteLine(number);
        }

        var evenSum = numbers.Where(x => x % 2 == 0).Sum();
        //foreach(var number in evenSum)
        //{
        //    Console.WriteLine(number);
        //}
       

    }
}