using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console is a reference to a system static class
            //static classes are used by typing the class name
            //static classes do not store variable data
            //static classes are used by everyone
            //methods of a static class will be placed after
            //      the object dot operator
            Console.WriteLine("Hello World");

            //Create an instance of a non static class
            //If you create a declarative using JUST the
            //   class name then this is ONLY a pointer
            //   that can hold an instance of the class
            //   specified;
            //Current value of aVariable is null
            FencePanel aVariable = null;

            //if you use the new command with the class
            //   the new command will physically create
            //   an instance of the class

            //when this statement is executed, the Default
            //   constructor of the FencePanel class will
            //   be called on your behave.
            FencePanel anInstance = new FencePanel();
            anInstance.Height = 5.8;
            anInstance.Width = 8.0;
            anInstance.Style = "Neighbour Friendly";
            
            Console.WriteLine ( "height is: " + anInstance.Height.ToString());
            Console.WriteLine("width is: " + anInstance.Width.ToString());
            Console.WriteLine("style is: " + anInstance.Style);
            Console.WriteLine("price is: " + anInstance.Price.ToString() + "\n");

            //when this statement is executed, the Greedy
            //   constructor of the FencePanel class will
            //   be called on your behave.
            FencePanel anGInstance = new FencePanel(4.0, 6.8, "private", 32.89);
            Console.WriteLine("height is: " + anGInstance.Height.ToString());
            Console.WriteLine("width is: " + anGInstance.Width.ToString());
            Console.WriteLine("style is: " + anGInstance.Style);
            Console.WriteLine("price is: " + anGInstance.Price.ToString() + "\n");

            Console.ReadLine();

        }//eom
    }//eoc

}//eon
