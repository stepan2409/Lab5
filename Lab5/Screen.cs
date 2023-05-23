using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    public class Screen : Hardware
    {
        public Lab5.Size ScreenSize
        {
            get;
            set;
        }

        public ColorMode ScreenColorMode
        {
            get;
            set;
        }

        public int DifferentPortsAmount
        {
            get; set;
        }

        public Screen(Hardware hardware, ColorMode screenColorMode, Size ScreenSize, int differentPortsAmount)
        {
            this.Manufacturer = hardware.Manufacturer;
            this.CountryOfOrigin = hardware.CountryOfOrigin;
            this.ProducementDate = hardware.ProducementDate;
            this.ScreenColorMode = screenColorMode;
            this.ScreenSize = ScreenSize;
            this.DifferentPortsAmount = differentPortsAmount;
        }

        public override string ToString()
        {
            string colorText = (ScreenColorMode == ColorMode.COLOR) ? "Цветной" : "Чёрно-белый";
            return base.ToString() + $"\n" +
                $"Цветовой режим: {colorText}\n" +
                $"Размер (пикселей): {ScreenSize.ToString()}\n" +
                $"Количество видов портов: {DifferentPortsAmount.ToString()}";
        }
    }
}