using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    public class Hardware
    {
        public string Manufacturer
        {
            get;
            set;
        }

        public DateTime ProducementDate
        {
            get;
            set;
        }

        public string CountryOfOrigin
        {
            get; set;
        }

        public Hardware(string manufacturer, DateTime producementDate, string countryOfOrigin)
        {
            this.Manufacturer = manufacturer;
            this.ProducementDate = producementDate;
            this.CountryOfOrigin = countryOfOrigin;
        }
        public Hardware()
        {
            this.Manufacturer = "";
            this.ProducementDate = DateTime.Now;
            this.CountryOfOrigin = "";
        }

        public override string ToString()
        {
            return $"Производитель: {Manufacturer}\n" +
                "Дата производства: " + String.Format("{0}.{1}.{2}", ProducementDate.Day,
                ProducementDate.Month, ProducementDate.Year) + "\n" +
                $"Страна производства: {CountryOfOrigin}";
        }
    }
}