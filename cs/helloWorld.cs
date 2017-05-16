using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public static class Extensions
    {
        public static int multiplication(this int var, int a, int b)
        {
            int result = var;
            for ( int i = 0; i  < b; i++)
            {
                result *= a;
            }
            return result;
        }
    }
    class Parent
    {
        private int mId;
        public Parent(int id) {
            this.mId = id;
            Console.WriteLine("Parent()");
        }
        public virtual int getId() {
            Console.WriteLine("Parent - getId");
            return mId;
        }
    }
    class Child : Parent
    {
        public Child(int id) : base(id)
        {
            Console.WriteLine("Child()");
        }
        public override int getId() {
            Console.WriteLine("Child - getId");
            return base.getId();
        }
    }
    class Car
    {
        private int maxSpeed;
        private int speed = 0;
        private string model;
        public Car(int maxSpeed, string model)
        {
            this.maxSpeed = maxSpeed;
            this.model = model;
        }
        public void showCarInformation()
        {
            Console.WriteLine(model + "의 현재 속도: " + speed + "km/h, 최대속도: " + maxSpeed);
        }
        public void speedUp(int increment)
        {
            if(speed + increment > maxSpeed)
            {
                Console.WriteLine("최대속도 " + maxSpeed + " km/h를 넘길수 없습니다.");
            } else
            {
                speed += increment;
                Console.WriteLine("Current speed is " + speed + " km/h.");
            }
        }
        public void speedDown(int decrement)
        {
            if (speed - decrement < 0)
            {
                Console.WriteLine("Speed can't be low than 0");
            }
            else
            {
                speed -= decrement;
                Console.WriteLine("Current speed is " + speed + " km/h.");
            }
        }
    }
    interface IMyInterface
    {
        void print();
    }
    interface IMyInterfaceB
    {
        void print();
    }
    class MyClass : IMyInterface, IMyInterfaceB
    {
        void IMyInterface.print()
        {
            Console.WriteLine("A-print()");
        }

        void IMyInterfaceB.print()
        {
            Console.WriteLine("B-print()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            IMyInterface ia = m;
            ia.print();
            IMyInterfaceB ib = m;
            ib.print();
            Console.WriteLine("{0}", 5.multiplication(2, 3));
            Parent p1 = new Parent(10);
            p1.getId();
            Child child = new Child(20);
            child.getId();
            Parent p2 = new Child(30);
            p2.getId();
            Car car = new ConsoleApplication2.Car(325, "Rambor");
            car.showCarInformation();
            car.speedUp(50);
            car.speedUp(40);
            car.speedUp(210);
            car.speedUp(210);
            car.speedDown(100);
            Parent p = new ConsoleApplication2.Parent(1);
            Console.WriteLine("hello {0}", p.getId());
            int a = 1;
            int b = 2;
            swap(ref a, ref b);
            Console.WriteLine("a = {0}, b={1}", a, b);
            int c;
            Add(out c);
            int sum = total(1, 2, 3, 4, 5, 6, 7, 8);
            int[] intList = { 0, 1, 2, 3, 4 };
            sum = total(intList);
            Array.ForEach<int>(intList, new Action<int>(ShowValue));
            Console.WriteLine();
            Array.ForEach<int>(intList, new Action<int>(ShowValue));
            Console.WriteLine();
            Array.Resize<int>(ref intList, 100);
            Console.WriteLine("Rank = {0}, Length = {1}", intList.Rank, intList.Length);
            Array.Clear(intList, 0, intList.Length);
            Array.ForEach<int>(intList, new Action<int>(ShowValue));
            Console.WriteLine();
            intList[80] = 100;
            Console.WriteLine("IndexOf 100 = {0}",Array.IndexOf<int>(intList, 100));
            int[,] matrix = new int[2,4]{ { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            Console.WriteLine("Rank of matrix = {0}", matrix.Rank);
            Console.WriteLine("Length of matrix = {0}", matrix.Length);
            Console.WriteLine("Length of matrix = {0}", matrix.GetLength(0));
            Console.WriteLine("Length of matrix = {0}", matrix.GetLength(1));
            for (int row =0; row < matrix.GetLength(0); row++)
            {
                for (int col=0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0, 2} ", matrix[row, col]);
                }
                    Console.WriteLine();
            }
            string line = Console.ReadLine();
            Console.WriteLine(line);
            string[] part = line.Split(' ');
            try
            {
                a = Convert.ToInt32(part[0]);
                b = Convert.ToInt32(part[1]);
            } catch (Exception e)
            {
                Console.WriteLine("text Not allowed ({0})", e.ToString());
            }
            Console.WriteLine("{0}, {1}", a, b);
        }
        static void ShowValue(int value)
        {
            Console.Write("{0} ", value);
        }
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Add(out int a)
        {
            a = 100;
        }
        static int total(params int[] list)
        {
            int sum = 0;
            for (int i=0; i < list.Length; i++) {
                sum += list[i];
            }
            return sum;
        }
    }
}
