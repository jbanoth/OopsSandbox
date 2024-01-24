using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSandbox
{
    public class Test
    {
        protected int test12 { get; set; }
    }

    public class DerivedTest : Test
    {

        public int derivedtest1 { get; set; }
        public void Disp()
        {
            test1 = 10;
        }
    }
    public abstract class Shape
    {
        public int MyId { get; set; }
        //abstract method
        public abstract double CalculateArea();//payroll
        protected int myNum { get; set; }
        public virtual int GetMyAge()
        {
            return default(int);
        }
        //concrete method 
        public void Display() //facilities ==>laptop/chair/internet /coffee
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("the time we are invoking display method" + dateTime.ToString());
        }

        public void DisplayTime() //facilities ==>laptop/chair/internet /coffee
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("the time we are invoking display method" + dateTime.ToString());
        }
        public Shape()
        {
            myNum = 29;
        }
    }
    //Interface
    interface IPerimeter
    {
        double CalculatePerimeter();

        void DisplayMyName();
    }

    public class Circle : Shape, IPerimeter
    {
        public double CalculatePerimeter()
        {
            return default(double);
        }

        public override int GetMyAge()
        {
            return 29;
        }
        public void DisplayMyName()
        {
            Console.WriteLine("Jairam Chakravarthi");
        }
        public override double CalculateArea()
        {
            return 122.22;
        }
    }

    public class Addition
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }


    public class BaseClass
    {
        public string CompanyName { get; set; }
        public BaseClass()
        {
            Console.WriteLine("This is Base class");
            this.CompanyName = "Object Source";
        }
    }

    //Inheritance ===> Child will posses whatever availble from the Parent 

    public class ChildClass : BaseClass
    {
        public ChildClass()
        {
            Console.WriteLine("this is Child class");
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shape shape = null;
                Console.WriteLine(  shape.MyId);
                int n = 100;
                Console.WriteLine(n / 10);
                //positve scenario/code does not throw errors ==> control doesnt goes into catch block
                //finally ==> executed always (write only execution safe code in exception)
                //Successfully uploaded the photo.
            }
            catch(NullReferenceException nx)
            {
                Console.WriteLine(  nx.ToString());
            }
            catch (FileNotFoundException fx)
            {
                Console.WriteLine(fx.ToString());
            }
            catch (DivideByZeroException ds)
            {
                Console.WriteLine($"{ds.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //Say a meaningful message to enduser, photo upload failed, try again!!!
            ChildClass child = new ChildClass();
            Console.WriteLine(child.CompanyName);

            Circle circle = new Circle();
            circle.DisplayTime();
            circle.Display();
            Console.WriteLine(circle.CalculateArea());
            circle.DisplayMyName();
            Addition addition = new Addition();
            addition.Add(12, 23);
            addition.Add(12, 23, 34);
            addition.Add(1.23, 34.45);

            DerivedTest derivedTest = new DerivedTest();
            Test test = new Test();


            //Polymorphism 

            //Compiletime Polymorphism ==> runtime polymorphism

            //Method Overloading




            //Method Overriding

            //Abstraction ==> Implementation hiding
            //Encapsulation ==> Data hiding 
            //access modifiers



        }
    }
}
