using C44_G01_OOP01_Assignment.Enum;
using C44_G01_OOP01_Assignment.Struct;

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








            #endregion







            #region Question6 
            /* 
             Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            Write a C# program that takes two points as input from the user and calculates the distance between them.   
            */





            #endregion








            #region Question7 
            /*Create a struct called "Person" with properties "Name" and "Age". 
            Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.   */





            #endregion






        }
    }
}