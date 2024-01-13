using System.ComponentModel.DataAnnotations;
using Display;

namespace Basic_Concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

             //Program2.display();
           Display. Program2 P2=new Display.Program2();
            // P2.diplay();
        }
    }

}
namespace Display
{ 

    class Program2
    {
        public static void display () {
            Console.WriteLine("Hii Sanjay");
                }
    }
}
