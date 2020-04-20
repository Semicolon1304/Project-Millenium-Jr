//Local Backup at /Desktop/Backups/C#/Bonnagery_Episode_1.cs Zack's Mac Pro
using System;
using System.Threading;

namespace textAdventure
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Beginning Shenanigans (Wow, I are can speel)
            Console.WriteLine(); 
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome to the game, " + name + "!");
            Console.Write("Starting in 3...");
            Thread.Sleep(3000);
            Console.Write("2...");
            Thread.Sleep(3000);
            Console.Write("1...");
            Thread.Sleep(3000);
            // Narration. *Bing!* 
            Console.WriteLine("Many years ago, the ancient race known as Zoomers walked this earth.");
            Thread.Sleep(4000);
            Console.WriteLine("Among the Zoomers were an elite group known as 'Creative Writers'.");
            Thread.Sleep(4000);
            Console.WriteLine("And in this elite group was a scribe known as Michael.");
            Thread.Sleep(4000);
            Console.WriteLine("Michael was credited with the creation of the little documentation we have on the Bonners, one of the most powerful races ever known.");
            Thread.Sleep(4000);
            Console.WriteLine("Some of these Bonners were peaceful, such as 1, 2, 4, and 16.");
            Thread.Sleep(4000);
            Console.WriteLine("Others, however, were not so peaceful like 3,5,6, and 10. ");
            Thread.Sleep(4000);
            Console.WriteLine("Due to these being noticeably more chaotic, the mad ramblings of Michael don't have much information on them.");
            Thread.Sleep(4000);
            Console.WriteLine("Your mission, if you choose to accept it, is to find out more about the Bonners.");
            Thread.Sleep(4000);
            Console.WriteLine("The Bonners are all immortal, so they are still around, but their location is a closely guarded secret.");
            Thread.Sleep(4000);
            Console.WriteLine("The one Bonner who's location is still known to the world is Bonner Alpha. He lives in the lower right corner of the United States");
            Thread.Sleep(4000);
            Console.WriteLine("Your scanner will pick up traces of his power. good luck");
            Console.WriteLine("       ");
            Console.WriteLine("       ");
            Console.WriteLine("       ");
            //Holy crap that was a lot. end of 9/8/19

            

            //Start of actual game
            Console.WriteLine("1. Find Bonner Alpha.");
            Console.WriteLine("2.Pester the Unnamed Narrator some more.");
            Console.Write("What do you want to do? (Please type the number of the option you want) ");
            string input1 = Console.ReadLine();


            //conversion to int
            int seeAlpha = Int32.Parse(input1);

            if (seeAlpha == 1)
            {
                
                Console.WriteLine("You use your scanner to trace the power signature of Bonner Alpha.");
                Thread.Sleep(4000);
                Console.WriteLine("Your scanner indicates that Bonner Alpha is living in North Carolina");
                Thread.Sleep(4000);
                Console.WriteLine("       ");
                Console.WriteLine("1. Talk to Bonner Alpha.");
                Console.WriteLine("2. Ask the Unnamed Narrator a Question.");
                Console.WriteLine("8. Hunt.");
            }
            else 
            {
                Console.WriteLine("Ha Ha. Moving on.");
                Thread.Sleep(4000);
                Console.WriteLine("You use your scanner to trace the power signature of Bonner Alpha.");
                Console.WriteLine("Your scanner indicates that Bonner Alpha is living in North Carolina");
                Console.WriteLine("       ");
                Console.WriteLine("1. Talk to Bonner Alpha.");
                Console.WriteLine("2. Ask the Unnamed Narrator a Question.");
                Console.WriteLine("8. Hunt.");
            }
        Console.Write("What would you like to do? ");
        string input2 = Console.ReadLine();

        //conversion once again

        int alphaTalk = Int32.Parse(input2);

        if (alphaTalk == 1)
        {
            Console.WriteLine("You ask Bonner Alpha where the other Bonners are located. He tells you that they are located at the ruins of [name]");
            Thread.Sleep(4000);
            Console.WriteLine("He also tells you that it's dangerous to go alone, and to take a grey plastic gun with faded orange writing.");

            Console.WriteLine("1. Go to the ruins of [name]");
            Console.WriteLine("2. Ask about the gun ");
            Console.WriteLine("3. Point the gun at your head.");
            Console.WriteLine("           ");
            

        }
        
        if (alphaTalk == 8)
        {
            Console.WriteLine("I see you are cultured. Good.");
            Console.WriteLine("You ask Bonner Alpha where the other Bonners are located. He tells you that they are located at the ruins of [name]");
            Thread.Sleep(4000);
            Console.WriteLine("He also tells you that it's dangerous to go alone, and to take a grey plastic gun with faded orange writing.");

            Console.WriteLine("1. Go to the ruins of [name]");
            Console.WriteLine("2. Ask about the gun ");
            Console.WriteLine("3. Point the gun at your head.");
            Console.WriteLine("           ");
            

        }

        if (alphaTalk == 2)
        {
        Console.WriteLine("You realize I will just ignore you, right? I don't have enough time to program this much shenannagins into the game.");
        Console.WriteLine("       ");
        Console.WriteLine("You ask Bonner Alpha where the other Bonners are located. He tells you that they are located at the ruins of [name]");
        Thread.Sleep(4000);
        Console.WriteLine("He also tells you that it's dangerous to go alone, and to take a grey plastic gun with faded orange writing.");

        Console.WriteLine("1. Go to the ruins of [name]" );
        Console.WriteLine("2. Ask about the gun ");
        Console.WriteLine("3. Point the gun at your head. ");
        Console.WriteLine("4. Shoot Bonner Alpha ");
        Console.WriteLine("           ");
        

        } 

        Console.Write("What would you like to do?");
        
        string input3 = Console.ReadLine();

        int findBonner = Int32.Parse(input3); 
        //development was officially resumed and I was able to debug and run the code. end of 10/8/19

        if (findBonner == 1)
        {
            Console.WriteLine("You search for the ruins of name. after many hours of false trails, you find an ancient web page called 'Google Maps.'");
            Thread.Sleep(3000);
            Console.WriteLine("after an extensive search through the incredibly outdated UI of Google Maps, you find the location.");
            Thread.Sleep(3000);
            Console.WriteLine("Unfortunately, you follow the route and it takes you to a pine tree on a mountain.");
            Console.WriteLine("You try the other map option and find the ruins of [name]");

        }
        

        if (findBonner == 2)
        {
            Console.WriteLine("Bonner alpha tells you the gun is an 'NES Zapper' from ye olden days. He also tells you to stop asking pointless questions.");
            Console.WriteLine("You search for the ruins of name. after many hours of false trails, you find an ancient web page called 'Google Maps.'");
            Thread.Sleep(3000);
            Console.WriteLine("after an extensive search through the incredibly outdated UI of Google Maps, you find the location.");
            Thread.Sleep(3000);
            Console.WriteLine("Unfortunately, you follow the route and it takes you to a pine tree on a mountain.");
            Console.WriteLine("You try the other map option and find the ruins of [name]");

        }
        if (findBonner == 3) 
        {
        Console.WriteLine("'The gun is a light gun. it won't do anything to a mortal like yourself.");
        Console.WriteLine("You search for the ruins of name. after many hours of false trails, you find an ancient web page called 'Google Maps.'");
            Thread.Sleep(3000);
            Console.WriteLine("after an extensive search through the incredibly outdated UI of Google Maps, you find the location.");
            Thread.Sleep(3000);
            Console.WriteLine("Unfortunately, you follow the route and it takes you to a pine tree on a mountain.");
            Console.WriteLine("You try the other map option and find the ruins of [name]");
        }     
        if (findBonner == 4) 
        {
             
            Console.WriteLine("You Win!");
            Environment.Exit(0);



        }





        }
    }
    
}