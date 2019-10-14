/*
Author:  Cody Martin
Date: 10/9/19
CTEC 135: Microsoft Software Development with C#

<Module 2, Programming Assignment 1 part 2 , Problem 3 >

   <Printer problem>

*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3redo
{
    class Program
    {
        static void Main(string[] args)
        { // for loops for conditions
            for (int printerPrints = 0; printerPrints < 8; printerPrints++)
            {
                for (int lightFlashing = 0; lightFlashing < 8; lightFlashing++)
                {
                    for (int comp = 0; comp < 8; comp++)
                    {
                        // if states to check conditions and print troubleshooting 
                        if (printerPrints == 0 && lightFlashing == 0 && comp == 0)
                        {
                            Console.WriteLine("When 1.The printer isnt printing 2.Red light is flashing 3.Printer isnt recognized by computer");
                            PrinterCable();
                            PrinterSoftware();
                            CheckInk();
                            Console.WriteLine();
                            
                            
                            
                        }
                        if (printerPrints == 1 && lightFlashing == 1 && comp == 1)
                        {
                            Console.WriteLine("When 1.The printer isnt printing 2.Red light is flashing 3.Printer i recognized by computer");
                            
                            PrinterJam();
                            CheckInk();
                            Console.WriteLine();
                        }
                        if (printerPrints == 2 && lightFlashing == 2 && comp == 2)
                        {
                            Console.WriteLine("When 1.The printer isnt printing 2.Red light is flashing 3.Printer isnt recognized by computer");
                            PrinterCable();
                            CheckInk();
                            Console.WriteLine();
                         
                                                   
                        }
                        if (printerPrints == 3 && lightFlashing == 3 && comp == 3)
                        {
                            Console.WriteLine("When 1.The printer isnt printing 2.Red light is not flashing 3.Printer isnt recognized by computer");
                            PrinterCable();
                            PrinterSoftware();
                            PrinterPower();
                            Console.WriteLine();
                        }
                        if (printerPrints == 4 && lightFlashing == 4 && comp == 4)
                        {
                            Console.WriteLine("When 1.The printer isnt printing 2.Red light is not flashing 3.Printer is recognized by computer");
                            PrinterJam();
                            Console.WriteLine();
                            
                            
                            
                        }
                        if (printerPrints == 5 && lightFlashing == 5 && comp == 5)
                        {
                            Console.WriteLine("When 1.The printer is printing 2.Red light is not flashing 3.Printer isnt recognized by computer");
                            
                            PrinterSoftware();
                            
                            Console.WriteLine();
                        }
                        if (printerPrints == 6 && lightFlashing == 6 && comp == 6)
                        {
                            Console.WriteLine("When 1.The printer is printing 2.Red light is flashing 3.Printer is recognized by computer");
                            
                            CheckInk();
                            Console.WriteLine();
                            
                            
                            
                        }
                        if (printerPrints == 7 && lightFlashing == 7 && comp == 7)
                        {
                            Console.WriteLine("When 1.The printer is printing 2.Red light is not flashing 3.Printer isnt recognized by computer");
                            
                            PrinterSoftware();
                            
                            Console.WriteLine();
                        }
                    }
                }
            }
            
            
        
        }

        // action methods
        static void PrinterCable()
        {
            Console.WriteLine("Check Printer To Computer Cable");
        }
        static void PrinterSoftware()
        {
            Console.WriteLine("Check Software");
        }
        static void CheckInk()
        {
            Console.WriteLine("Check Ink");
        }
        static void PrinterPower()
        {
            Console.WriteLine("Check Power Cable");
        }
        static void PrinterJam()
        {
            Console.WriteLine("Check for Jam");
        }

    }
}
