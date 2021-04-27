using System;

class Person
    {
        public int age;
        public string Introduction;
        public void Intro(string _intro)
        {
            Introduction = _intro;
            Console.WriteLine(Introduction);
        }
        public void Hello()
        {
            Console.WriteLine("Hello!!");
        }
        public void SetAge()
        {
            Console.WriteLine("");
            Console.Write("Enter the age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
        }
    }
    class Student:Person
    {
        public void Study()
        {
            Console.WriteLine("I'm Studying");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is "+ age +" years old");
        }
    }
    class Professor:Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm Explaining");
        }
    }
    class StudentProfessorTest
    {
        static void Main()
        {
            Person per1 = new Person();
            per1.Hello();
            Student stu1 = new Student();
            stu1.SetAge();
            stu1.Hello();
            stu1.Intro("I'm a Student");
            stu1.ShowAge();
            stu1.Study();
            Professor pro1 = new Professor();
            pro1.SetAge();
            pro1.Hello();
            pro1.Intro("I'm a Professor");
            pro1.Explain();
        }
    }