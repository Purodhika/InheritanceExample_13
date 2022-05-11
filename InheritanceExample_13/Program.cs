using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample_13
{
  public  class Person
    {    
       // private int address;
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }

        public string getName()
        {
            return FirstName + " "+ LastName;
        }

        public Person() { }
        public Person(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
           
        }
        public Person( string fName, string lName , int age)
        {
            this.FirstName = fName;
            this.LastName = lName;
            Age = age;
        }

    }

    public class Student : Person  // is-a
    {
        public Student(string fName, string lName, int age , int id) : base(fName, lName, age)
        {
            this.Id = id;
        }
        public Student(string fName, string lName, int id) : base(fName, lName)
        {
            this.Id = id;
        }
        //public Student()  { }
        public int Id { get; set; }
    }

    public class Shape
    {
        public string Name { get; set; }    
        public Shape( string name ) { Name = name; }

        public virtual double GetArea() { return 0; }


        public override string ToString()
        {
            return " Name = "+Name;
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point( int x, int y ) { X = x; Y = y; }

        public override string ToString()
        {
            return " X ="+X +", Y ="+Y;
        }
    }
    class Circle : Shape
    {
       public double Radius { get; set; }
       public Point Center { get; set; }
        public Circle(string name , double r ) : base(name)
        {
            Radius = r;
        }
        public Circle(string name, double r , Point p) : base(name)
        {
            Radius = r;
            Center = p;
        }

        override public double GetArea() { return Radius *Radius * Math.PI; }


        public override string ToString()
        {
            return base.ToString() + " Radius = "+Radius + "Center = "+Center + "area = "+GetArea();
        }
    }
    internal class Program : Object
    {

      static  int x = 10;
        static void Main(string[] args)
        {

            Student s = new Student("Tim" , "M" , 22 , 868969);

            
           // s.FirstName = "Tim";
           // s.LastName = "M";
           // s.Age = 22;
            Console.WriteLine(s.getName());

            //  Person p = new Student();

            Shape shape = new Shape("shape");
            Console.WriteLine(shape.Name);
            Console.WriteLine(shape.GetArea());
            Point point = new Point(100, 100);
            Circle circle = new Circle("circle", 10 , point);
            Console.WriteLine(circle.Name);
            Console.WriteLine(circle.ToString());

            int x  = 5;
            
            Console.WriteLine("x = "+x);

        }
    }
}
