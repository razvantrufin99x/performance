using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace performance
{

      

    public  class PerformanceManager
    {
        static PerformanceCounter cpuCounter;
        static PerformanceCounter ramCounter;

        static PerformanceManager()
        {
            cpuCounter = new PerformanceCounter();

            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        }

        public  string getCurrentCpuUsage()
        {
            return cpuCounter.NextValue() + "%";
        }

        public  string getAvailableRAM()
        {
            return ramCounter.NextValue() + "MB";
        }
    }
}