

using C44_G01_OOP01_Demo.Enums.Example1;

namespace C44_G01_OOP01_Demo.Example2
{
    internal class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Gender Gender { get; set; }

        public Grades Grade { get; set; }
        public Branch Branch { get; set; }
    }
}
