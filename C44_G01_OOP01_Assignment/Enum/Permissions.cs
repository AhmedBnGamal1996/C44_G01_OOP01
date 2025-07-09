

namespace C44_G01_OOP01_Assignment.Enum
{

[Flags]
    internal enum Permissions
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
}
