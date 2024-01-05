using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ITI
{
    internal class User 
    {
        public int Id {get;set;}
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        
        public string UserName{get; set;}
        public string Password{get;set;}

        public string Rule{get;set;}
        public string Path{get;set;}
        public bool Logged{get;set;}

         Account ac1 = new Account();
         
        public User()
        {
           Logged = false;

        }


        public void login(object type){
            //flag 
            User ResivedData = null;



            // loop
            while(ResivedData == null)
            {
                GetLoginDataFromUser();
                //email , password
                ResivedData = ac1.login(Email , Password );
            }

            // ResivedData == UserObject{name , paswword , email , addrress}


            // save logged userdata
            SaveLoggedData(ResivedData);
            //printData();
        }

        public void GetLoginDataFromUser(){
            Console.WriteLine("Enter email");
            Email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            Password = Console.ReadLine();
        }
        private void SaveLoggedData(User ResivedData)
        {
            Id = ResivedData.Id;
            Name = ResivedData.Name;
            Email = ResivedData.Email;
            Phone = ResivedData.Phone;
            Address = ResivedData.Address;
            Age = ResivedData.Age;
            UserName = ResivedData.UserName;
            Password = ResivedData.Password;
            Rule = ResivedData.Rule;
            Path =ResivedData.Path;
            Logged = true;

        }

         public void register(object type){
            //get Data From User
            GetDataFromUser();
            // Run Register Function 
            ac1.register(type , Rule , Path);
            // Save Data to path
            
           
         }

        public void GetDataFromUser(){
            Console.WriteLine("Enter id");
            Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name");
            Name = Console.ReadLine();

            Console.WriteLine("Enter phone");
            Phone = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Age");
            Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter email");
            Email = Console.ReadLine();

            Console.WriteLine("Enter Address");
            Address = Console.ReadLine();

            Console.WriteLine("Enter username");
            UserName = Console.ReadLine();

            Console.WriteLine("Enter password");
            Password = Console.ReadLine();
        }
        
        
        public void printData(){
            Console.WriteLine("-------------------------------");
            Console.Write("ID = " + Id + " \t ");
            Console.Write("Name = " + Name + " \t" );
            Console.Write("Email  = " + Email  + " \t");
            Console.Write("Phone = " + Phone + " \n");
            Console.Write("Address = " + Address + " \t");
            Console.Write("Age = " + Age + "Years \t");
            Console.Write("Username = " + UserName + " \t");
            Console.Write("Password = " + Password + " \n");
            Console.Write("Role = " + Rule + " \t");
            // Console.Write(Path);
            Console.Write("Login =" + Logged + " \n");

        }


        // public  virtual void register(string Rule ){
        //     Console.WriteLine("Enter id");
        //     Id = int.Parse(Console.ReadLine());

        //     Console.WriteLine("Enter name");
        //     Name = Console.ReadLine();

        //     Console.WriteLine("Enter phone");
        //     Phone = int.Parse(Console.ReadLine());

        //     Console.WriteLine("Enter Age");
        //     Age = int.Parse(Console.ReadLine());

        //     Console.WriteLine("Enter email");
        //     Email = Console.ReadLine();

        //     Console.WriteLine("Enter Address");
        //     Address = Console.ReadLine();

        //     Console.WriteLine("Enter username");
        //     UserName = Console.ReadLine();

        //     Console.WriteLine("Enter password");
        //     Password = Console.ReadLine();
           

        // }
    }
}
