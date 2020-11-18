using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labyrinthv2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.OutputEncoding = Encoding.UTF8;



                Console.WriteLine("*********************************************");
                Console.WriteLine("************ Welcome to the MAZE ************");
                Console.WriteLine("*********************************************");
                Console.WriteLine("");
                Console.WriteLine("You are lost inside a Maze, try to escape...");


                bool gameRunning = true;
                int room_number = 2;
                while (gameRunning)
                {
                    if (room_number == 1)

                    {
                        Console.WriteLine("There are 2 doors in your room: (e)ast, where do you want to go ? ");
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
                            room_number = 4;
                        }
                        else if (choice == "e")
                        {
                            Console.Clear();
                            Console.WriteLine("> going to east...");
                            room_number = 2;
                        }
                        else
                        {
                            Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
                        }
                    }
                    else if (room_number == 2)
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
                            room_number = 5;
                        }
                        else if (choice == "w")
                        {
                            Console.Clear();
                            Console.WriteLine("> going to west...");
                            room_number = 1;
                        }
                        else if (choice == "e")
                        {

                            Console.Clear();
                            Console.WriteLine("> going to east...");
                            room_number = 3;
                        }
                        else
                        {
                            Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
                        }
                    }
                    else if (room_number == 3)
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
                            room_number = 6;
                        }
                        if (choice == "w")
                        {
                            Console.Clear();
                            Console.WriteLine("> going east at the begining");
                            room_number = 2;
                        }


                    }
                    else if (room_number == 4)
                    {
                        Console.WriteLine(">>>>>>>>>>>> It's a trap... you are DEAD :/");
                        Console.WriteLine("");
                        Console.ReadKey();
                        gameRunning = false;
                    }
                    else if (room_number == 5)
                    {
                        //TODO: complete
                        Console.WriteLine("There are no other room here go back !");
                        Console.WriteLine("╔═══════════════╗");
                        Console.WriteLine("║               ║");
                        Console.WriteLine("║               ║");
                        Console.WriteLine("║       ☻       ║");
                        Console.WriteLine("║               ║");
                        Console.WriteLine("║               ║");
                        Console.WriteLine("╚═════╣ s ╠═════╝");
                        string choice = Console.ReadLine();
                        if (choice == "s")

                            Console.Clear();
                        Console.WriteLine("> going to where its all starting...");
                        room_number = 2;






                    }

                    else if (room_number == 6)
                    {
                        Console.WriteLine(">>>>>>>>>>>> You found the EXIT...Congratulations:)");
                        Console.ReadKey();
                        gameRunning = false;
                    }
                }
            }
        }
    }

}
    }
}
