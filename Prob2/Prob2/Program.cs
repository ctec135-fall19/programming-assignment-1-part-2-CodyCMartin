/*
Author:  Cody Martin
Date: 10/9/19
CTEC 135: Microsoft Software Development with C#

<Module 2, Programming Assignment 1 part 2 , Problem 2 >

   <Iteration Constructs>

 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        
       
        {
            #region print 1-5 with spaces between the numbers on a single line using a for loop
            for (int i=0; i<6; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();

            #endregion

            #region print 1-5 with spaces between the numbers on a single line using a while loop
            int count = 0;
            while (count < 6)
                
            {
                Console.Write(count);
                count++;
                Console.Write(" ");
            }
            Console.WriteLine();
            #endregion

            #region print 1-5 with spaces between the numbers on a single line using a do/while loop
            int doCount = 0;
            do
            {
                Console.Write(doCount);
                doCount++;
                Console.Write(" ");


            } 
            while (doCount < 6);
            Console.WriteLine();
            #endregion

           

        }
    }
}
