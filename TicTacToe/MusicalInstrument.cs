using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class MusicalInstrument
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string History_ {  get; set; }
        public string Sound_ {  get; set; }

        public MusicalInstrument(string name, string description, string history,string sound)
        {
            Name = name;
            Description = description;
            History_ = history;
            Sound_ = sound;
        }
        public void Sound() { Console.WriteLine($"Звук инструмента:{Sound_}"); }
        public void History() { Console.WriteLine($"История: {History_}"); }
        public void Show() { Console.WriteLine($"Имя инструмента: {Name}"); }
        public void Desc() { Console.WriteLine($"Описание:{Description}"); }
    }
}
