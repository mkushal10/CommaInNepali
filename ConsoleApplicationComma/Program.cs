using System;

namespace ConsoleApplicationComma
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = "starts";
            while (start == "starts")
            {
                int nums;
                bool result = false;
                while (result == false)
                {
                    Console.WriteLine("Please Enter a Number: ");
                    string input = Console.ReadLine();
                    result = int.TryParse(input, out nums);
                    int len = input.Length;
                    if (result == false)
                    {
                        Console.Write("\n Please Enter Numbers Only.");
                        break;
                    }
                    else
                    {
                        if (len > 3)
                        {
                            int lens = len - 3;
                            Console.WriteLine(lens);
                            if (lens % 2 == 0)
                            {
                                for (int i =0; i<=lens; i+=2)
                                {
                                    Console.WriteLine(i);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hello 0");
                            }
                        }
                        else
                        {
                            Console.WriteLine(input);
                        }
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
//string ctrs = ",";
//Console.WriteLine(input + ctrs);