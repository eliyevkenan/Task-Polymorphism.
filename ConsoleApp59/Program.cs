using System;

namespace ConsoleApp59
{
    internal class Program
    {
        static void Main(string[] args, string groupNo)
        {
            string fullname;
            do
            {
                Console.WriteLine("Student FullName daxil edin:");
                fullname = Console.ReadLine();

            } while (!Student.CheckFullname(fullname));

            string groupNo;
            do
            {
                Console.WriteLine("Qrup Nomresini daxil edin:");
                groupNo = Console.ReadLine();
            } while (Student.CheckGroupNo(groupNo));

            Console.WriteLine("Studen Yasini daxil edin:");
            int Age=Convert.ToInt32(Console.ReadLine());

            Student student=new Student(fullname,groupNo,Age);
        }
            
       
    }
}
