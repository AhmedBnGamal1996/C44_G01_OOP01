using C44_G01_OOP01_Assignment.Enum;
using C44_G01_OOP01_Assignment.Struct;
using System.Xml.Linq;

namespace C44_G01_OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1 
            /*
            Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            Then, write a C# program that prints out all the days of the week using this enum.       
             */

            //foreach (WeekDays weekDay in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine($"The day is : {weekDay}");
            //}


            #endregion




            #region Question2 
            /*   
             Define a struct "Person" with properties "Name" and "Age". 
            Create an array of three "Person" objects and populate it with data.
            Then,write a C# program to display the details of all the persons in the array.   
    
             */


            //Person[] person = new Person[3];
            //person[0] = new Person { Name = "Ahmed", Age = 29 };
            //person[1] = new Person { Name = "Maryem", Age = 3 };
            //person[2] = new Person { Name = "Ali", Age = 29 };

            //foreach (Person P in person)
            //{
            //    Console.WriteLine($"the name is {P.Name} and the Age is : {P.Age}");
            //}







            #endregion




            #region Question3
            /* Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) as its members.
            Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)  */



            //Season season = new Season();
            //bool isSeason;

            //do
            //{
            //    Console.WriteLine("Please enter a season (Spring, Summer, Autumn, Winter) ...");
            //    isSeason = Enum.TryParse<Season>(Console.ReadLine(), true, out season)&& Enum.IsDefined(typeof(Season) , season);     

            //    // هنستعمل isDefined عشان نتأكد هل موجود القيمة اللي دخلها و لا لا 


            //} while (!isSeason);

            //switch (season)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("spring march to may");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("summer june to august");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("autumn September to November");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("winter December to February");
            //        break;
            //}


            #endregion








            #region Question4 

            /*   
             Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            Create Variable from previous Enum to Add and Remove Permission from variable,
            check if specific Permission is existed inside variable  
             */




            #endregion









            #region Question5 
            /* 
             Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. 
            Write a C# program that takes a color name as input from the user and displays a message indicating
            whether the input color is a primary color or not.
             */

            //Colors color = new Colors();
            //bool isColor;

            //do
            //{
            //    Console.Write("Please enter a basic Color (Red, Green, Blue) ...  ");
            //    isColor = Enum.TryParse<Colors>(Console.ReadLine(), true, out color) && Enum.IsDefined(typeof(Colors), color);
            //    if (isColor == true)
            //    {
            //        Console.WriteLine("the input color is a primary color");

            //    }
            //    else
            //    {
            //        Console.WriteLine("the input color is not a primary color");
            //    }

            //} while (!isColor); 









            #endregion







            #region Question6 
            /* 
             Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            Write a C# program that takes two points as input from the user and calculates the distance between them.   
            */

            //Console.WriteLine("Please Enter 2 Point where the one Point have X and y coordinate..");

            //Console.Write("please enter x1 : ");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("please enter y1 : ");
            //double y1 = Convert.ToDouble(Console.ReadLine()); 
            //Console.Write("please enter x2 : ");
            //double x2 = Convert.ToDouble(Console.ReadLine()); 
            //Console.Write("please enter y2 : ");
            //double y2 = Convert.ToDouble(Console.ReadLine());
             

            //Point P1 = new Point(x1,y1);
            //Point P2 = new Point(x2,x2);

            //double Distance = Math.Sqrt(Math.Pow((P2.X - P1.X), 2) + Math.Pow((P2.Y - P1.Y), 2));

            //Console.Clear();
            //Console.WriteLine($"The distance between the two points is : {Distance}");


            #endregion








            #region Question7 
            /*Create a struct called "Person" with properties "Name" and "Age". 
            Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.   */


            //Person[] persons = new Person[3];
            //for (int i = 0; i < persons.Length; i++)
            //{
            //   string nameUser;
            //   int ageUser; 
            //   bool isAge;
            //    do
            //    {

            //        Console.WriteLine($"Please enter the details of person {i + 1}:");
            //        Console.Write("Name: ");
            //         nameUser = Console.ReadLine();
            //        Console.Write("Age: ");
            //        isAge = int.TryParse(Console.ReadLine(), out  ageUser);
            //    }
            //    while (!isAge);
                
            //        persons[i] = new Person(nameUser, ageUser);

                
            //}

            //Person oldestPerson = persons[0];
            //foreach (Person person in persons)
            //{
            //    if (person.Age > oldestPerson.Age)
            //    {
            //        oldestPerson = person;
            //    }
            //}

            //Console.Clear();

            //Console.WriteLine($"the oldest is : {oldestPerson}");








            #endregion






        }
    }
}