

namespace C44_G01_OOP01_Demo.Example3
{


    [Flags]
    internal enum Permissions:byte
    {
        Write = 1 ,              // 0b_0000_0001
        Read  = 2 ,                   // 0b_0000_0010
        Delete = 4 ,                       //  0b_0000_0100
        Execute = 8                           // 0b_0000_1000




    }
}
