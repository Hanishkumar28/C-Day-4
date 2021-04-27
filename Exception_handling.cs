class Calc
    {
        public static void Main()
        {
            int x = 1;
            int y;
            try
            {
                y = x / 0;
                Console.WriteLine(y);
            }
            catch
            {
                Console.WriteLine("Some Error have occured");
            }
        }
    }