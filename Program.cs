//Devolpment Restarted now that a story exists on 4/29/20
using System;
using System.Threading;

namespace millenniumText
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Game Start
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write($"Welcome to episode one of The Bonnagery, {name}! The game will start in 3...");
            Thread.Sleep(1000);
            Console.Write("2...");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Console.WriteLine("    ");



            //Expisitionarration. BING!
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Briefing Room");
            Console.WriteLine("    ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("<There is a man at the front of the room speaking.>");
            Thread.Sleep(4000);
            Console.WriteLine("Around 600 years ago, A race of powerful creatures ruled the land.");
            Thread.Sleep(3000);
            Console.WriteLine("This race was known simply as 'The Bonners' ");
            Thread.Sleep(4000);
            Console.WriteLine("We don't know what sort of power these Bonners had, but we do know that they were unrivaled.");
            Thread.Sleep(4000);
            Console.WriteLine("Your mission, should you choose to accept it, is to find out about the origin of these Bonners and their powers.");
            Thread.Sleep(4000);
            Console.WriteLine("If you accept, please step through the green door. Otherwise, enter the red door");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.Write("1. Go through the"); 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" green");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" door.");
            Console.Write("2. Go through the"); 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" red");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" door.");
            Console.Write("What would you like to do? (Please type a numbered option) ");
            string door1 = Console.ReadLine();
            //conversion to int
            int door1Result = Int32.Parse (door1);
            
            if (door1Result == 1) {
                Console.WriteLine("<You enter the ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("green");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" door.>");

            }

            if (door1Result == 2) {
                Console.Write("<You enter the ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("red");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" door, only to find yourself back in front of the doors.>");
                Thread.Sleep(1500);
                Console.WriteLine("");
                Console.Write("Perhaps you don't understand. I said, if you accept, enter the ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("green ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("door!");
                Thread.Sleep(3000);
                Console.WriteLine("Let's try again.");
                Console.WriteLine("  ");
                 Console.Write("1. Go through the"); 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" green");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" door.");
            Console.Write("2. Go through the"); 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" red");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" door.");
            Console.Write("What would you like to do? (Please type a numbered option) ");

            string Door = Console.ReadLine();
            int redDoor = Int32.Parse (Door);

            if (redDoor == 2) {
                Console.Write("Alright fine. you want to go through the ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("red ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("door? Fine. let's go.");
                Thread.Sleep(2000);
                Console.Beep();
                Environment.Exit(0);

            }





            } 

        
        
        
        
        
        
        }       






    
    }
}