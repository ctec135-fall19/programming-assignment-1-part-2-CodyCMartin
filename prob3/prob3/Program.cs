﻿using System;
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
                for (int lightFlashing = 0; lightFlashing < 8; printerPrints++)
                {
                    for (int comp = 0; comp < 8; comp++)
                    {
                        // if states to check conditions
                        if (printerPrints == 1 && lightFlashing == 1 && comp == 1)
                        {
                            PrinterCable();
                            PrinterSoftware();
                            CheckInk();
                        }
                    }
                }
            }
            
            
        
        }
    }
}