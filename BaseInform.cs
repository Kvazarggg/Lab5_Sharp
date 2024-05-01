using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    public class BaseInform
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public BaseInform(string name, int year, string color, double price, string description)
        {
            Name = name;
            Year = year;
            Color = color;
            Price = price;
            Description = description;
        }

        public override string ToString()
        {
             return $"Name: {Name}, Year: {Year}, Color: {Color}, Price: {Price}, Description: {Description}";
        }
    }
}
