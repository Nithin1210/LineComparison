using System;
namespace LineComparison
{
    class program
    {
        static void Main(string[] args)
        {
            Operation o1 = new Operation(1, 2, 3, 4);
            double line1 = o1.CalculateLength();
            Console.WriteLine(line1);

            Operation o2 = new Operation(2, 3, 4, 8);
            double line2 = o2.CalculateLength();
            Console.WriteLine(line2);


            if (line1.Equals(line2))
                Console.WriteLine("line1 is equal to line2 ");
            else Console.WriteLine("line1 is not equal to line2");

        }
    }


}

