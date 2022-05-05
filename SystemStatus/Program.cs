using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemStatus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x, rslt;
            Console.WriteLine("*** Welcome To Light Company ***\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Do Not Close The Program \n");
            Console.ForegroundColor = ConsoleColor.Blue;

            rslt = $"[{DateTime.Now}]";

            x = String.Format("{0,20}", HardwareInfo.GetProcessorId());
            Console.WriteLine($"ProcessorId : {x}");
            rslt += $"[ ProcessorId : {x}]";

            x = String.Format("{0,30}", HardwareInfo.GetHDDSerialNo());
            Console.WriteLine($"HDDSerialNo : {x}");
            rslt += $"[ HDDSerialNo : {x}]";

            x = String.Format("{0,15}", HardwareInfo.GetMACAddress());
            Console.WriteLine($"MACAddress : {x}");
            rslt += $"[ MACAddress : {x}]";

            x = String.Format("{0,50}", HardwareInfo.GetBoardMaker());
            Console.WriteLine($"BoardMaker : {x}");
            rslt += $"[ BoardMaker : {x}]";

            x = String.Format("{0,20}", HardwareInfo.GetBoardProductId());
            Console.WriteLine($"BoardProductId : {x}");
            rslt += $"[ BoardProductId : {x}]";

            x = String.Format("{0,5}", HardwareInfo.GetCdRomDrive());
            Console.WriteLine($"CdRomDrive : {x}");
            rslt += $"[ CdRomDrive : {x}]";

            x = String.Format("{0,50}", HardwareInfo.GetBIOSmaker());
            Console.WriteLine($"BIOSmaker : {x}");
            rslt += $"[ BIOSmaker : {x}]";

            x = String.Format("{0,50}", HardwareInfo.GetBIOScaption());
            Console.WriteLine($"BIOScaption : {x}");
            rslt += $"[ BIOScaption : {x}]";

            x = String.Format("{0,40}", HardwareInfo.GetAccountName());
            Console.WriteLine($"AccountName : {x}");
            rslt += $"[ AccountName : {x}]";

            x = String.Format("{0,10}", HardwareInfo.GetPhysicalMemory());
            Console.WriteLine($"PhysicalMemory : {x}");
            rslt += $"[ PhysicalMemory : {x}]";

            x = String.Format("{0,2}", HardwareInfo.GetNoRamSlots());
            Console.WriteLine($"NoRamSlots : {x}");
            rslt += $"[ NoRamSlots : {x}]";

            x = String.Format("{0,20}", HardwareInfo.GetCPUManufacturer());
            Console.WriteLine($"CPUManufacturer : {x}");
            rslt += $"[ CPUManufacturer : {x}]";

            x = String.Format("{0,10}", HardwareInfo.GetCPUCurrentClockSpeed());
            Console.WriteLine($"CPUCurrentClockSpeed : {x}");
            rslt += $"[ CPUCurrentClockSpeed : {x}]";


            x = String.Format("{0,5}", HardwareInfo.GetCpuSpeedInGHz());
            Console.WriteLine($"CpuSpeedInGHz : {x}");
            rslt += $"[ CpuSpeedInGHz : {x}]";

            //Save to file
            rslt += Environment.NewLine;
            if (!File.Exists("Hard_Info.txt"))
            {
                File.WriteAllText("Hard_Info.txt", rslt);
            }
            else
            {
                using (StreamWriter w = File.AppendText("Hard_Info.txt"))
                {
                    w.WriteLine(rslt);
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nResult is Save to Hard_Info.txt");

            Console.ForegroundColor= ConsoleColor.White;
            Console.Write("\n\nPress Any Key to Close ...");
            Console.ReadKey();
        }
    }
}
