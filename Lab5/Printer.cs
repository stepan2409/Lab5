using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    public class Printer : Hardware
    {
        public ColorMode PrintingColorMode
        {
            get; set;
        }

        public Size MaxPaperSize
        {
            get; set;
        }

        public int MaxPaperSheetsAmount
        {
            get; set;
        }

        public Printer(string manufacturer, DateTime producementDate, string countryOfOrigin,
            ColorMode printingColorMode, Size maxPaperSize, int maxPaperSheetsAmount) 
        { 
            this.Manufacturer = manufacturer;
            this.ProducementDate = producementDate;
            this.CountryOfOrigin = countryOfOrigin;
            this.PrintingColorMode = printingColorMode;
            this.MaxPaperSize = maxPaperSize;
            this.MaxPaperSheetsAmount = maxPaperSheetsAmount;
        }

        public Printer(Hardware hardware, ColorMode printingColorMode, Size maxPaperSize, int maxPaperSheetsAmount)
        {
            this.Manufacturer = hardware.Manufacturer;
            this.CountryOfOrigin = hardware.CountryOfOrigin;
            this.ProducementDate = hardware.ProducementDate;
            this.PrintingColorMode = printingColorMode;
            this.MaxPaperSize = maxPaperSize;
            this.MaxPaperSheetsAmount= maxPaperSheetsAmount;
        }

        public override string ToString()
        {
            string colorText = (PrintingColorMode == ColorMode.COLOR) ? "Цветной" : "Чёрно-белый";
            return base.ToString() + $"\n" +
                $"Цветовой режим печати: {colorText}\n" +
                $"Максимальный размер листа (мм): {MaxPaperSize.ToString()}\n" +
                $"Максимальное количество листов: {MaxPaperSheetsAmount.ToString()}";
        }
    }
}