using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    public class Computer : Hardware
    {
        public string OS
        {
            get; set;
        }

        public string CPUVendor
        {
            get; set;
        }

        public Computer(Hardware hardware, string os, string cpuVender)
        {
            this.Manufacturer = hardware.Manufacturer;
            this.CountryOfOrigin = hardware.CountryOfOrigin;
            this.ProducementDate = hardware.ProducementDate;
            this.OS = os;
            this.CPUVendor = cpuVender;
        }

        public override string ToString()
        {
            return base.ToString() + $"\n" +
                $"ОС: {OS}\n" +
                $"Производитель ЦПУ: {CPUVendor}";
        }
    }
}