using System;
using WCFTaskOneProject.ServiceReference1;

namespace WCFTaskOneProject
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsServiceClient client = new StudentsServiceClient();
            System.Console.WriteLine("Student's full name...");
            string FullName = System.Console.ReadLine();

            var result = client.AddNewStudent(new Student() {
                FullName = FullName
            });

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
