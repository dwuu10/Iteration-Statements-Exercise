namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void ThousandsToNegative()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ThreeToNines()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void IntCompare()
        {
            int a;
            int b;
            bool aParsable;
            bool bParsable;
            bool isParsable;

            do
            {
                Console.WriteLine("First Number:");
                var inputA = Console.ReadLine();
                Console.WriteLine("Second Number:");
                var inputB = Console.ReadLine();
                aParsable = int.TryParse(inputA, out var intA);
                bParsable = int.TryParse(inputB, out var intB);
                if (aParsable == true && bParsable == true)
                {
                    a = intA;
                    b = intB;

                    if (a == b)
                    {
                        Console.WriteLine($"{a} and {b} are the same");
                    }
                    else
                    {
                        Console.WriteLine($"{a} and {b} are not the same");
                    }
                    isParsable = true;

                }
                else
                {
                    isParsable = false;
                }

            } while (isParsable == false);



        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd()
        {
            int a;
            bool aParsable;
            bool isParsable;

            do
            {
                Console.WriteLine("Enter a Number:");
                var inputA = Console.ReadLine();
                aParsable = int.TryParse(inputA, out var intA);
                if (aParsable == true)
                {
                    a = intA;

                    if (a % 2 == 0)
                    {
                        Console.WriteLine($"{a} is even");
                    }
                    else
                    {
                        Console.WriteLine($"{a} is odd");
                    }
                    isParsable = true;

                }
                else
                {
                    isParsable = false;
                }

            } while (isParsable == false);
        }

        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative()
        {
            int a;
            bool aParsable;
            bool isParsable;

            do
            {
                Console.WriteLine("Enter a Number:");
                var inputA = Console.ReadLine();
                aParsable = int.TryParse(inputA, out var intA);
                if (aParsable == true)
                {
                    a = intA;

                    if (a > 0)
                    {
                        Console.WriteLine($"{a} is positive");
                    }
                    else if(a < 0)
                    {
                        Console.WriteLine($"{a} is negative");
                    }
                    else
                    {
                        Console.WriteLine($"{a} is zero");
                    }
                    isParsable = true;

                }
                else
                {
                    isParsable = false;
                }

            } while (isParsable == false);
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void votingAge()
        {
            int a;
            bool aParsable;
            bool isParsable;

            do
            {
                Console.WriteLine("Enter your age:");
                var inputA = Console.ReadLine();
                aParsable = int.TryParse(inputA, out var intA);
                if (aParsable == true)
                {
                    a = intA;

                    if (a >= 18)
                    {
                        Console.WriteLine($"You are old enough to vote");
                    }
                    
                    else
                    {
                        Console.WriteLine($"unfortunately, you are not of voting age");
                    }
                    isParsable = true;

                }
                else
                {
                    isParsable = false;
                }

            } while (isParsable == false);
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void inRange(int lower, int upper) //for purposes of exercise, set parameters to -10 and 10 accordingly when calling method
        {
            int a;
            bool aParsable;
            bool isParsable;
            do
            {
                Console.WriteLine("enter a Number");
                var inputA = Console.ReadLine();
                aParsable = int.TryParse(inputA, out var intA);
                if (aParsable == true)
                {
                    a = intA;

                    if (intA <= upper && intA >= lower)
                    {
                        Console.WriteLine($"{a} is between {lower} and {upper}");
                    }
                    else
                    {
                        Console.WriteLine($"{a} is not between {lower} and {upper}");
                    }
                    isParsable = true;

                }
                else
                {
                    isParsable = false;
                }
                
            } while(isParsable == false);
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiTable()
        {
            int a;
            bool aParsable;
            bool isParsable;
            do
            {
                Console.WriteLine("enter a Number");
                var inputA = Console.ReadLine();
                aParsable = int.TryParse(inputA, out var intA);
                if (aParsable == true)
                {
                    a = intA;

                    for (int i = 1; i <= 12; i++)
                    {
                        Console.WriteLine($"{a} times {i} equals {a * i}");
                    }
                    isParsable = true;

                }
                else
                {
                    isParsable = false;
                }

            } while (isParsable == false);
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
            {

            ThousandsToNegative();
            ThreeToNines();
            IntCompare();
            EvenOrOdd();
            PositiveOrNegative();
            votingAge();
            inRange(-10, 10);
            MultiTable();

            }
        
    }
}
