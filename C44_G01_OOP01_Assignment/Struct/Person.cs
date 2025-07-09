
namespace C44_G01_OOP01_Assignment.Struct
{
    internal struct Person
    {
        public string? Name;
        public int Age;

        public Person(string name, int age)         // Constructor for add Data
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name! ;  
        }
    }
}
