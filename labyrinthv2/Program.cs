using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labyrinthv2
{
    class Program
    {



        static int room1(int roomID)
        {
            Console.WriteLine("There are 2 doors in your room: (e)ast and (n)orth, where do you want to go ? ");
            Console.WriteLine("╔═════╣ n ╠═════╗");
            Console.WriteLine("║               ║");
            Console.WriteLine("║       ▲       ╩");
            Console.WriteLine("║       ☻ ►     e");
            Console.WriteLine("║               ╦");
            Console.WriteLine("║               ║");
            Console.WriteLine("╚═══════════════╝");

            string choice = Console.ReadLine();
            if (choice == "n")
            {
                Console.Clear();
                Console.WriteLine("> going to north...");
                roomID = 4;
            }
            else if (choice == "e")
            {
                Console.Clear();
                Console.WriteLine("> going to east...");
                roomID = 2;
            }
            else
            {
                Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
            }
            return roomID;
        }

        static int room2(int roomID)
        {

            Console.WriteLine("There are 3 doors in your room: (n)orth,(w)est, (e)ast, where do you want to go ? ");
            Console.WriteLine("╔═════╣ n ╠═════╗");
            Console.WriteLine("║               ║");
            Console.WriteLine("╩       ▲       ╩");
            Console.WriteLine("w     ◄ ☻ ►     e");
            Console.WriteLine("╦               ╦");
            Console.WriteLine("║               ║");
            Console.WriteLine("╚═══════════════╝");
            string choice = Console.ReadLine();
            if (choice == "n")
            {
                Console.Clear();
                Console.WriteLine("> going to north...");
                roomID = 5;
            }
            else if (choice == "w")
            {
                Console.Clear();
                Console.WriteLine("> going to west...");
                roomID = 1;
            }
            else if (choice == "e")
            {

                Console.Clear();
                Console.WriteLine("> going to east...");
                roomID = 3;
            }
            else
            {
                Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
            }
            return roomID;
        }
        static int room3(int roomID)
        {
            //TODO: complete
            Console.WriteLine("There are 2 doors in this room where do you want to go ? ");
            Console.WriteLine("╔═════╣ n ╠═════╗");
            Console.WriteLine("║               ║");
            Console.WriteLine("╩       ▲       ║");
            Console.WriteLine("w     ◄ ☻       ║");
            Console.WriteLine("╦               ║");
            Console.WriteLine("║               ║");
            Console.WriteLine("╚═══════════════╝");
            string choice = Console.ReadLine();
            if (choice == "n")
            {
                Console.Clear();
                Console.WriteLine("> going to north...");
                roomID = 6;
            }
            if (choice == "w")
            {
                Console.Clear();
                Console.WriteLine("> going east at the begining");
                roomID = 2;
            }
            return roomID;
        }

        static int room5(int roomID)
        {
            Console.WriteLine("There are 1 door in your room: (s)outh, where do you want to go ? ");
            Console.WriteLine("╔═══════════════╗");
            Console.WriteLine("║               ║");
            Console.WriteLine("║       ▲       ║");
            Console.WriteLine("║       ☻ ►     ║");
            Console.WriteLine("║               ║");
            Console.WriteLine("║               ║");
            Console.WriteLine("╚══════╣ s ╠════╝");

            string choice = Console.ReadLine();
            if (choice == "s")
            {
                Console.Clear();
                Console.WriteLine("> going to south...");
                roomID = 2;
            }
            
            else
            {
                Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
            }
            return roomID;
        }



        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Intro();

            bool gameRunning = true;
            int room_number = 2;
            while (gameRunning)
            {
                if (room_number == 1)
                {
                    room_number = room1(room_number);
                }
                else if (room_number == 2)
                {
                    room_number = room2(room_number);
                }
                else if (room_number == 3)
                {

                    room_number = room3(room_number);



                }
                else if (room_number == 4)
                {
                    Loose();
                    gameRunning = false;
                }
                else if (room_number == 5)
                {
                    room_number = room5(room_number);

                }

                else if (room_number == 6)
                {
                    Win();
                    gameRunning = false;
                }
            }
        }

        private static void Loose()
        {
            Console.WriteLine(">>>>>>>>>>>> It's a trap... you are DEAD :/");
            Console.WriteLine("");
            Console.ReadKey();
        }

        private static void Win()
        {
            Console.WriteLine(">>>>>>>>>>>> You found the EXIT...Congratulations:)");
            Console.ReadKey();
        }

        private static void Intro()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("************ Welcome to the MAZE ************");
            Console.WriteLine("*********************************************");
            Console.WriteLine("");
            Console.WriteLine("You are lost inside a Maze, try to escape...");
        }
    }
}







