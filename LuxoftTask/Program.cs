using System;
using System.Collections.Generic;

//Technical question:
//Write a method that returns the top 'x' elements from a list.
//Example: Call of YourClass.LargestX(3, new List<int> { 12, 9, 5, 4, 3, 2, 0 })  => should return new List<int> { 5, 9, 12 }
namespace LuxoftTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task\nWrite a method that returns the top 'x' elements from a list.\nExample: Call of \nYourClass.LargestX(3, new List<int> { 12, 9, 5, 4, 3, 2, 0 })  => should return new List<int> { 5, 9, 12 }");
            Console.WriteLine();
            myClass listTest = new myClass();
            List<int> list =new List<int> { 12, 9, 5, 4, 3, 2, 0 };
            Console.WriteLine("Displaying a preliminary list");
            Console.WriteLine("-----------------------------------------------------");
            foreach (var item in list)
            {
                Console.Write($"{item},");
            }
           
            try
            {
                int count = 3;
              

                //main method***************************
                list = listTest.LargestX(count, list);
                //*************************************


                Console.WriteLine("\n-----------------------------------------------------");
                Console.WriteLine("Output of the method in the specified order and quantity from the task");
                foreach (var item in list)
                {
                    Console.Write($"{item},");
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine("\n\nError\n" +ex.Message);
            }

            Console.WriteLine();
            Console.Read();
           
          
        }
    }
}
