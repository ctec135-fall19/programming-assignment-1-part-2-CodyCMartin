using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
​
namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int printerPrints = 0; printerPrints < 2; printerPrints++)
            {
                for (int redLight = 0; redLight < 2; redLight++)
                {
                    for (int printerRecognized = 0; printerRecognized < 2; printerRecognized++)
                    {
                        if (printerPrints == 0)
                        {
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Conditions:");
                            Console.WriteLine();
                            Console.WriteLine("Prints:\t\t\t False ");
                        } else
                        {
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Conditions:");
                            Console.WriteLine();
                            Console.WriteLine("Prints:\t\t\t True ");
                        }
​
                        if (redLight == 0)
                        {
                            Console.WriteLine("Flashing light:\t\t False ");                            
                        }
                        else
                        {
                            Console.WriteLine("Flashing light:\t\t True ");                            
                        }
​
                        if (printerRecognized == 0)
                        {
                            Console.WriteLine("Printer recognized:\t False ");
                            Console.WriteLine();
                            Console.WriteLine("Possible Actions:");
                        }
                        else
                        {
                            Console.WriteLine("Printer recognized:\t True ");
                            Console.WriteLine();
                            Console.WriteLine("Possible Actions:");
                        }
​
                        if (printerPrints == 0 && redLight == 1 && printerRecognized == 0)
                        {
                            PrinterCable();
                            PrinterSoftware();
                            CheckInk();
                            Console.WriteLine();
                            Console.WriteLine();                            
                        }
​
                        if (printerPrints == 0 && redLight == 1 && printerRecognized == 1)
                        {                            
                            CheckInk();
                            PaperJam();
                            Console.WriteLine();
                            Console.WriteLine();
                        }
​
                        if (printerPrints == 0 && redLight == 0 && printerRecognized == 0)
                        {
                            PowerCable();
                            PrinterCable();
                            PrinterSoftware();
                            Console.WriteLine();
                            Console.WriteLine();
                        }
​
                        if (printerPrints == 0 && redLight == 0 && printerRecognized == 1)
                        {
                            PaperJam();
                            Console.WriteLine();
                            Console.WriteLine();
                        }
​
                        if (printerPrints == 1 && redLight == 1 && printerRecognized == 0)
                        {
                            PrinterSoftware();
                            Console.WriteLine();
                            Console.WriteLine();
                        }
​
                        if (printerPrints == 1 && redLight == 1 && printerRecognized == 1)
                        {
                            CheckInk();
                            Console.WriteLine();
                            Console.WriteLine();
                        }
​
                        if (printerPrints == 1 && redLight == 0 && printerRecognized == 0)
                        {
                            PrinterSoftware();
                            Console.WriteLine();
                            Console.WriteLine();
                        }
​
                        if (printerPrints == 1 && redLight == 0 && printerRecognized == 1)
                        {
                            Console.WriteLine("N/A");
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
​
        static void PowerCable()
        {
            Console.WriteLine(" - Check the power cable");
        }
​
        static void PrinterCable()
        {
            Console.WriteLine(" - Check the printer-computer cable");
        }
​
        static void PrinterSoftware()
        {
            Console.WriteLine(" - Ensure printer software is installed");
        }
​
        static void CheckInk()
        {
            Console.WriteLine(" - Check/replace ink");
        }
​
        static void PaperJam()
        {
            Console.WriteLine(" - Check for a paper jam");
        }
    }
}