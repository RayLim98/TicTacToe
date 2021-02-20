using System;

namespace KnotsNCrosses.Classes
{
    public class HelloWorld {

        public string Name;
        public void SayHello () {
        Console.WriteLine( "Hello");
        }
        
        public void Introduce ( string name ) {
        Console.WriteLine( "hello my name is {0}",name);
        }
        public void Introduce () {
        Console.WriteLine( "hello my name is {0}",Name);
        }
    }
}