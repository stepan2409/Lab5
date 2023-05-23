using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    public class Size
    {
        public decimal X { get; set; }

        public decimal Y { get; set; }

        public override string ToString()
        {
            return $"X = {X}; Y = {Y}";
        }

        public Size(decimal x = 0, decimal y = 0)
        {
            X = x ;
            Y = y ;
        }
    }
}