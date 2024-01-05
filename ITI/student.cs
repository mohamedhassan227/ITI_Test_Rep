using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI
{
    internal class Student : User 
    {

        // public string[] Cources { get; set; }
        public Student(){
          
            base.Rule = "student";
            base.Path = "Student.json";

            // base.CreateNewAccount();
            // base.printData();
            
        }

       public void WelcomeScreen(){
        
            Console.WriteLine("Welcome To Student Area");
            Console.WriteLine("1 - Login");
            Console.WriteLine("2 - Register");
            int action = int.Parse(Console.ReadLine());
            if(action == 1 ){
                login(this);
                //Logged 
                StudentDashboard();
            }else if (action == 2){
                register(this);
            }
       }
    
        public void StudentDashboard(){
            Console.WriteLine("Welcome Mr " + UserName);
            Console.WriteLine("---------------------------");
            Console.WriteLine("1 - View Your Profile");
            Console.WriteLine("2 - View Your Courses");
            int action = int.Parse(Console.ReadLine());
            switch(action){
                case 1 :
                    printData();
                break;

            }
           
        }


    }
}
