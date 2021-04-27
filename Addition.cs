using System;

class Class
    {
        public int a;
        public int b;

        public void InputDetails()
        {
            Console.WriteLine("Enter a number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum = " + (a + b));
        }
        public static void Main()
        {
            Class obj = new Class();
            int exitkey = 1;
            while (exitkey > 0)
            {
                Console.WriteLine("You want to exit ? Y/N");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "n")
                {
                    obj.InputDetails();
                    choice = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }