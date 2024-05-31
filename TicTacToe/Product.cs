using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Product:Money
    {   
        public string Type {  get; set; }
        public string Name { get; set; }

        public Product(string type, string name)
        {
            Type = type;
            Name = name;
        }   
        public double Discount(double value) { return Total()-value; }
        //public double Total() { return Whole + (double)(Fraction) / 100; }


    }
}
