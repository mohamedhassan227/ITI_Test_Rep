using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Security.Principal;
using System.Threading.Channels;

namespace ITI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome to ITI Project");
            Console.WriteLine("Please Choose Your Role");
            Console.WriteLine("1 - Student");
            Console.WriteLine("2 - Instructor");
            Console.WriteLine("3 - Admin");


            int choice = int.Parse(Console.ReadLine()); 

            switch(choice){
                case 1:
   
                    Student s1 = new Student();
                    s1.WelcomeScreen();

                    
                break;
                case 2:


                break;
            }
            

            
        }
    }
}
