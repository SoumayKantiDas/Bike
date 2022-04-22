using System;

namespace Bike
{
    public abstract class Bike
    {
        private string model { get; set; }
        public abstract void Display();
        
}
    public class Honda:Bike
    {
        public int speed { get; set; } = 160;
        private string model { get; set; } = "Honda";
        public override void Display() 
        {
            Console.WriteLine(model);
        }
    }
    public class Honda4 : Honda
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Bike bike = new Bike();
            Honda bike1 = new Honda();
            bike1.Display();
            Console.WriteLine(bike1.speed);
        }
    }
}
