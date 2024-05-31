using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Device
    { 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sound_ {  get; set; }
        public Device(string name, string description, string sound)
        {
            Name = name;
            Description = description;
            Sound_ = sound;
        }
        public void Sound() { Console.WriteLine($"Звук устройства:{Sound_}");}
        public void Show() { Console.WriteLine($"Имя устройства: {Name}");} 
        public void Desc() { Console.WriteLine($"Описание:{Description}");}
       

    }
}
