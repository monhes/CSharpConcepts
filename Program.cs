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
            Import(); // Constructor import Sutudent
            var student = new List<Student>(); 
            var OBJLinqSamples = new LINQSamples();



            var menu = Console.ReadLine();
            switch (menu)
            {
                case "linq":
                    OBJLinqSamples.LessThanFive();
                    Console.WriteLine("LINQ DONE");
                    break;

                case "cg": //class generic collection
                    var insStudent = new List<Student>(); // instance Student class collections
                    bool adding = true; 
                    while (adding)
                    {
                        var ObjStudent = new Student();
                        Console.WriteLine("name : ");
                        ObjStudent.Name = Console.ReadLine();
                        Console.WriteLine("grade : ");
                        ObjStudent.Grade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("phone : ");
                        ObjStudent.Phone = (Convert.ToInt32(Console.ReadLine()));

                        insStudent.Add(ObjStudent); // add to last list<>
                        Student.Count++;
                        Console.WriteLine("Student count : {0}" , Student.Count);

                        Console.WriteLine("-- add more ? -- ");
                        if (Console.ReadLine() != "y")
                        {
                            adding = false;
                        }

                    }
                    foreach (var item in insStudent)
                    {
                        Console.WriteLine(item.Name);
                        Console.WriteLine(item.Grade);
                        Console.WriteLine("***");
                    }
                    break;

                case "generic":
                    break;
                default:
                    break;
            }

            

        }

        static void Import()
        {
            var importedStudent = new Student("thu",2,81);
            Console.WriteLine(importedStudent.Name);
        }
    }
    public class Member
    {
        public string Name;
        protected int phone; //switch to protected instead private
        public int Phone //migrated from Student class
        {
            set { phone = value; }
        }
    }

    public class Student : Member
    {
        static public int Count = 0;
        //public string Name;
        public int Grade;
        //public int phone;
        public Student()
        {
        }
        public Student(string paraName, int paraGrade, int paraPhone)
        {
            Name = paraName;
            Grade = paraGrade;
            phone = paraPhone;
        }
    }

    public class Teacher : Member
    {
        //public string Name;
        public string Subject;
        //private int Phone;
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