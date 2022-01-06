using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_5CarLotAPI
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Colors Color { get; set; }
        public Car(string Make, string Model, int Year, Colors Color)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Color = Color;
        }

    }
    public enum Colors
        {
            black,
            grey,
            silver,
            white,
            yellow,
            orange,
            red,
            green,
            blue,
            purple
        }
}
