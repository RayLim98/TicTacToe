using System;

namespace KnotsNCrosses.Classes
{
    public class TestClass {
        public void Method() {
            Console.WriteLine( "Test class is working");
        }
        public string InputName(string name ) {
            name = "Hello"+ " " + name;
            return name;
        }
    }
}