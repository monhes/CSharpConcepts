using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpConcepts
{
    public enum SomeRootVegetable
    {
        HorseRadish,
        Radish,
        Turnip
    }

    [Flags]
    public enum Seasons
    {
        None = 0,
        Summer = 1,
        Autumn = 2,
        Winter = 4,
        Spring = 8,
        All = Summer | Autumn | Winter | Spring
    }

    class Program
    {
        static void Main(string[] args)
        {
            var inputstring = Console.ReadLine();
            LINQSamples OBJLinqSamples = new LINQSamples();
            if(inputstring == "linq"){
                OBJLinqSamples.LessThanFive();
                Console.WriteLine("LINQ DONE");
            }
            else if(inputstring == "generic"){

            }
        }
    }

    public class Location : COORD
    {
        private string locationName; //Location class field

        public Location(string name) => Name = name; //constructor with expression

        public string Name
        {
            get => locationName;
            set => locationName = value;
        }
    }

    public class COORD
    {
        public int X;
        public int Y;
        public int ShowCord()
        {
            int sum = X + Y;
            return sum;
        }
    }
}
