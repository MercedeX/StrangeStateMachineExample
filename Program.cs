using System;
using Domain;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Device
            Device device = new Device("Strange device");

            Console.WriteLine("A {0} in action with door is in {1} state", device.Name, device.Door.CurrentState.Name);

            var ch = new Char();
            do{
                ch = GetChoice();

                switch(char.ToLower(ch)){
                    case 'o': 
                        device.Door.Open();
                        break;
                    case 'c': 
                        device.Door.Close();
                        break;
                    case 'l': 
                        device.Door.Lock();
                        break;
                    case 'u': 
                        device.Door.Unlock();
                        break;
                }
                Console.WriteLine("Current State of Door {0}", device.Door.CurrentState.Name);
            }while(ch!='e');

        }
 
        private static char GetChoice()
        {
            Console.Write("Enter a choice (O)pen, (C)lose, (L)ock, (U)nlock, (E)xit:");
            return Console.ReadLine().ToCharArray()[0];

        }
    }

}
