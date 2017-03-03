using System;
namespace Class_Working
{
    class persianDt
    {
        private int year, month, day;
        public persianDt(int y, int m, int d) { year = y; month = m; day = d; }
        public int Get_Day() { return day; }
        public object get_year_and_month()
        {
            year_and_month test = new year_and_month();
            test.y = year;
            test.m = month;
            return test;
        }

    }
    class year_and_month
    {
        public int y, m;
    }
    class tamrins
    {
        static string convert_to_binery(int a)
        {
            string binary = Convert.ToString(a, 2); // convert number to its binary representation
            return binary;
        }
        static bool prime_number(int n)
        {
            int i;
            bool isPrime = true;

            for (i = 2; i <= n / 2; ++i)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
        static void Main()
        {
            bool correct = true;
            while (correct)
            {
                Console.WriteLine("\nplease enter 1 for tamrin 1\nplease enter 2 for tamrin 2 and 3\nplease enter 3 for exit.");
                int user_number = Convert.ToInt32(Console.ReadLine());
                switch (user_number)
                {
                    case 1:
                        //method 1
                        Console.WriteLine("\nplease inter the number for convert to binery:");
                        int input = Convert.ToInt32(Console.ReadLine());
                        string response = convert_to_binery(input);
                        Console.WriteLine("number binery is:" + response);

                        //method 2
                        Console.WriteLine("\nEnter a positive integer: ");
                        int input2 = Convert.ToInt32(Console.ReadLine());
                        bool isPrime2 = prime_number(input2);
                        if (isPrime2)
                        {
                            Console.WriteLine("This is a prime number");
                        }
                        else
                        {
                            Console.WriteLine("This is not a prime number");
                        }
                        break;
                    case 2:
                        char[] delimiterChars = { ':','/' };
                        Console.WriteLine("example for time: 1395/09/15 or 1395:09:15");
                        string test = Console.ReadLine();
                        string[] output = test.Split(delimiterChars);
                        Console.WriteLine("year:{0},month:{1}, day:{2}", output[0], output[1], output[2]);
                        persianDt t2 = new persianDt(Int32.Parse(output[0]), Int32.Parse(output[1]), Int32.Parse(output[2]));
                        int day = t2.Get_Day();
                        Console.WriteLine("\nreturn from method:" + day);
                        Console.WriteLine("\nreturn two value from method");
                        Console.WriteLine(t2.get_year_and_month());
                        break;
                    case 3:
                        correct = false;
                        break;
                }

            }
        } 
    }
}