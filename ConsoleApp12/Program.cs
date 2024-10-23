using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length the arr[] ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)//loop to insert random numbers into array
            {
                arr[i] = rand.Next(25, 75);
                Console.Write(arr[i]+"_");
            }
            Console.WriteLine();

            Console.WriteLine("===============*================");
            //continue to find out how many times the elements are repeated using the iterative method
            loop_count_B(arr);
            Console.WriteLine("===============*================");
            loop_count_A(0,arr,0);
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        static void loop_count_B(int[] ints)//iterative method
        {
            int index = 0;//To know the location of the item we are examining
            int count ;//
            while (index <ints.Length)
            {
                int n=ints[index];
                count = 0;
                for (int i = 0; i < ints.Length; i++)
                    if (ints[i] == n)
                        count++;
                Console.WriteLine(ints[index++]+" repeat of "+count);
            }
        }
        static void loop_count_A( int index, int[] ints, int count)//recursive method
        {
            if (index == ints.Length) return;
            for (int i = 0; i < ints.Length; i++)
                if (ints[i] == ints[index])
                    count++;
            Console.WriteLine(ints[index] + " repeat of " + count);
            loop_count_A(index + 1, ints, 0);
        }
        //class node
        //{
        //    int data;
        //    node next;
        //    public int Data { get; set; }
        //    public node Next { get; set; }
        //    public node() { }
        //    public node(int data)
        //    {
        //        this.data = data;
        //    }


        //}
        //class list {

        //    node first;
        //    node last;
        //    public list()
        //    {
                
        //    }
        //    public list(int data)
        //    {
        //        node t=new node(data);
        //    }
           
        //    public void add(node node) { }


        }
    }
}
