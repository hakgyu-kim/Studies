using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Parent
    {
        private int mId;
        public Parent(int id) {
            mId = id;
        }
        public int getId() {
            return mId;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("text Not allowed ");
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
