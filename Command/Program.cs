using System;
using Command.Commands;
using Command.Invokers;
using Command.Receivers;

namespace Command
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var pult = new Pult();
            var tv = new TV();
            pult.SetCommand(new TVOnCommand(tv));
            pult.PressButton();
            pult.PressUndo();

            var microwave = new Microwave();
            // 5000 - время нагрева пищи
            pult.SetCommand(new MicrowaveCommand(microwave, 5000));
            pult.PressButton();

            Console.Read();
        }
    }
}