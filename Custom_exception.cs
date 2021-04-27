using System;

class MyException:ApplicationException
    {
        
        public void MyDivideException()
        {
            Console.WriteLine("An Exception Occured, divisor should not be zero");
        }
    }
    class Class
    {
        static void Main()
        {
            int x = 5,y=0,z=3;
            try
            {
               if(y==0)
                {
                    throw new MyException();
                }
            }
            catch(MyException exception)
            {
                exception.MyDivideException();
            }
        }
    }