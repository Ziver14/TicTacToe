using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Money
    {
        public int Whole {  get; set; }
        public int Fraction {  get; set; }
        public double Total (){ return Whole + (double)(Fraction)/100; }
        public void Print()
        {
            Console.WriteLine("\n У вас денег:" + Total());
        }
    }
}
