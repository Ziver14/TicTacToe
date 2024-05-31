using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Manager:Worker
    {
        public override void Print()
        {
            Console.WriteLine("Менеджер руководит");
        }
    }
}
