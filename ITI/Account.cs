using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Security.Principal;
using System.Threading.Channels;


namespace ITI
{
    internal class Account
    {
        public Account()
        {
        }
    
        // public virtual void register(int Id  , string Name , int Phone , int Age , string Email , string Address , string UserName , string Password , string Rule ){
        //     // name , id , email , password ,,,,,,
            
        //     // Save Json()
        //     // Save All Inputed Data to the Json File

        // }


        public User login(string email , string password ){
            string json = File.ReadAllText(@"Student.json");
            List<Student> AllStudentData = JsonConvert.DeserializeObject<List<Student>>(json);
            //
            //flag
                for(int i = 0 ; i < AllStudentData.Count ; i++){
                if(AllStudentData[i].Email == email){
                    if(AllStudentData[i].Password == password){
                       return AllStudentData[i];
                    }
                }
            }
            Console.WriteLine("Wrong Email Or Password. Please Try Again");
            return null;

            
        }





        public void register(object type , string rule , string path){
            // Console.WriteLine(path);
            // Console.WriteLine(rule);

            if(rule == "student"){
                // Save To Json
                string json = File.ReadAllText(@path);
                List<Student> AllStudentData = JsonConvert.DeserializeObject<List<Student>>(json);

                
                Student studentData = (Student)type;
                AllStudentData.Add(studentData);
                var StoreStudentData = JsonConvert.SerializeObject(AllStudentData, Formatting.Indented);
                File.WriteAllText(@path, 
                    StoreStudentData);
                // Console.ReadKey();

            }else if(rule == "instructor"){
                // Save To Json
                string json = File.ReadAllText(@path);
                List<Instructor> AllStudentData = JsonConvert.DeserializeObject<List<Instructor>>(json);


                Instructor instuctorData = (Instructor)type;
                AllStudentData.Add(instuctorData);
                var StoreInstructorData = JsonConvert.SerializeObject(AllStudentData, Formatting.Indented);
                File.WriteAllText(@path, 
                    StoreInstructorData);
                // Console.ReadKey();
            }else if(rule == "admin"){
                // Save To Json
                string json = File.ReadAllText(@path);
                List<Admin> AllStudentData = JsonConvert.DeserializeObject<List<Admin>>(json);


                Admin adminData = (Admin)type;
                AllStudentData.Add(adminData);
                var StoreAdminData = JsonConvert.SerializeObject(AllStudentData, Formatting.Indented);
                File.WriteAllText(@path, 
                    StoreAdminData);
                // Console.ReadKey();
            }

        }
        
        // public void login(){
        //     // email , password
        //     // Check if user Data Is Right or wrong
        // }
    }
}
