using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Array
    {
        public int Sum(int[] arr)
        {
            int suum=0;
            for (int i = 0; i < arr.Length; i++)
            {
                suum += arr[i];
            }
            return suum;
        }
        public static void Main()
        {

            Console.WriteLine("Enter Size of List");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            Console.WriteLine("List \n");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Reverse List \n");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
            
            Console.WriteLine("\n");
            Array obj1 = new Array();
            Console.WriteLine("Sum of array is :" + " " + obj1.Sum(array));

            int[] array2 = new int[size];
            for (int i = 0; i < size; i++)
            {
                array2[i] = array[i];
            }
            Console.WriteLine("\n");
            Console.WriteLine("Enter the index to be deleted:");
            int index = Convert.ToInt32(Console.ReadLine());

            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Console.WriteLine("List after deleting the index:");
            Console.WriteLine("\n");
            for (int i = 0; i < size - 1; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("\n");

            int[] marks = new int[10];
            string[] name = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter name:");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter Marks");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Averrage Marsk Obtained by whole class is:{obj1.Sum(marks)/10}");
            //Console.WriteLine($"Highest Mark Obtained by a Student is:{array.Max}");
        }
    }
}