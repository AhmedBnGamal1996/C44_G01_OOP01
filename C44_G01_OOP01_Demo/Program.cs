using C44_G01_OOP01_Demo.Enums.Example1;
using C44_G01_OOP01_Demo.Example2;
using Common;

namespace C44_G01_OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Class Library 

            //Product product = new Product();
            //product.Id = 10;
            //product.Name = "Test";
            //product.Price = 1000;
            //product.Quantit = 1;

            #endregion


            #region Access Modifers 

            //TypeA typeA = new TypeA();
            //typeA.x = 1;    // invalid : Private
            //typeA.y = 2;    // invalid : internal
            //typeA.z = 3;    // Valid : Public :accessable its scope and same project and project take reference 



            #endregion



            #region Enum Ex 1 [ Male - Female ] 
            //Person P1 ;
            //// reference [ stack ] 4 bytes
            //P1 = new Person();
            //// 1] allocate num of bytes in heap 
            //// 2] intialize with the default values
            //// 3] call user defined ctor [ if exist [ 
            //// 4 ] assign reference to the instance in heap 

            //P1.Name = "Mariam";
            //P1.Id = 1;
            //P1.Genders = "Female"; 


            /*************--------------------------*********/

            //Person P1 = new Person()
            //{
            //    Name = "Mariam" , 
            //    Id = 1 ,
            //    Genders = Gender.Female,

            //};
            //Console.WriteLine(P1.Genders);

            /*************--------------------------*********/


            #endregion



            #region Enum Ex2 { Grades }
            //Grades g1;      // Varible - object 
            //g1 = Grades.A;
            //Console.WriteLine(g1);


            //Person p1 = new Person(); 
            //Console.WriteLine(p1.Grade);
            //Console.WriteLine(p1.Genders);

            //int num = (int)Grades.C;
            //Console.WriteLine(num);

            //Person p1 = new Person()
            //{
            //    Id = 1,
            //    Name = "Mohamed",
            //    Genders = Gender.Male,
            //    Grade = Grades.C 
            //}; 

            //if (p1.Grade == Grades.A )
            //{
            //    Console.WriteLine("Bravoooooo....");
            //}
            //else Console.WriteLine("-_-");


            #endregion



            #region Video 5 Enum  Ex3 { Grade , Gender , Branch } 
            // User user ;     // Reference 

            //user = new User()
            //{
            //    Id = 1,
            //    Name = "Mona",
            //    Gender = Gender.Male,
            //    Grade = Grades.A,
            //    Branch = Branch.Dokki
            //};
            //Console.WriteLine(user.Grade);
            //Console.WriteLine(user.Gender);
            //Console.WriteLine(user.Branch);

           // ------------------------------------------------------

            //User user = new User();

            //Console.WriteLine("Please Enter the USer Info ...");
            //int stId;
            //bool isParsed; 

            //do
            //{
            //Console.WriteLine("Please Enter the USer Id ...");
            //isParsed = int.TryParse(Console.ReadLine() , out stId); // String ? 
            //}
            //while (!isParsed);

            //Console.WriteLine("Please Enter Valid User Name ..");
            //user.Name = Console.ReadLine();

            //// Gender , Grade , Branch

            //object? gender;
            //do
            //{
            //    Console.WriteLine("Please Enter the USer Gender ...");
            //    isParsed = Enum.TryParse(typeof(Gender) , Console.ReadLine(), true , out gender);
            //}while(!isParsed);


            //Grades grade; 
            //do
            //{
            //    Console.WriteLine("Please Enter the USer Grade ...");
            //    isParsed = Enum.TryParse<Grades>(Console.ReadLine() , true , out grade);
            //} while (!isParsed);

            //Branch branch ;
            //do
            //{
            //    Console.WriteLine("Please Enter the USer Branch ...");
            //    isParsed = Enum.TryParse<Branch>(Console.ReadLine(), true , out branch);
            //} while (!isParsed);

            //user.Id = stId;
            //user.Grade = grade;
            //user.Gender = (Gender)gender;
            //user.Branch = branch; 
            
            //Console.Clear();

            //Console.WriteLine($"Hello {user.Id} , {user.Name} ");
            //Console.WriteLine($"Your gender {user.Gender} ");
            //Console.WriteLine($"Your grade {user.Grade} ");
            //Console.WriteLine($"Your Branch {user.Branch} ");

            //foreach(Branch B in Enum.GetValues(typeof(Branch)))
            //{
            //    Console.WriteLine(B);
            //}

            //foreach (String B in Enum.GetNames(typeof(Branch)))
            //{
            //    Console.WriteLine($"String : {B}");
            //}





            #endregion







        }
    }
}