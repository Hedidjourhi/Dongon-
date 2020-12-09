using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labyrinthv2
{
    class Program
    {
        private static void DisplayStandardRoom(Dictionary<string, int> configForCurrentRoom)
        {
            bool canGoNorth = configForCurrentRoom.ContainsKey("n");
            bool canGoSouth = configForCurrentRoom.ContainsKey("s");
            bool canGoEast = configForCurrentRoom.ContainsKey("e");
            bool canGoWest = configForCurrentRoom.ContainsKey("w");
            Console.WriteLine("");
            generateRoom(canGoNorth, canGoSouth, canGoEast, canGoWest);
            Console.WriteLine("");
            Console.Write("There are " + configForCurrentRoom.Count() + " door(s) in your room: ");
            if (canGoNorth)
                Console.Write("(n)orth ");
            if (canGoSouth)
                Console.Write("(s)outh ");
            if (canGoEast)
                Console.Write("(e)ast ");
            if (canGoWest)
                Console.Write("(w)est ");
            Console.WriteLine("where do you want to go ? ");
        }
        static void generateRoom(bool canGoNorth, bool canGoSouth, bool canGoEast, bool canGoWest)
        {
            for (int y = 0; y < 7; y++)
            {
                string currentTextLine = "";
                for (int x = 0; x < 17; x++)
                {
                    bool isInside = x > 0 && x < 16 && y > 0 && y < 6;
                    bool northDoor = canGoNorth && x == 8 && y == 0;
                    bool southDoor = canGoSouth && x == 8 && y == 6;
                    bool eastDoor = canGoEast && x == 16 && y == 3;
                    bool westDoor = canGoWest && x == 0 && y == 3;
                    bool isDoor = northDoor || southDoor || eastDoor || westDoor;
                    bool isPlayer = x == 8 && y == 3;

                    if (isPlayer)
                    {
                        currentTextLine += "☻";
                    }
                    else if (isInside || isDoor)
                    {
                        currentTextLine += " ";
                    }
                    else
                    {
                        currentTextLine += "#";
                    }
                }
                Console.WriteLine(currentTextLine);
            }
        }

        static int room(int roomID, Dictionary<string, string> sentenceWhenMoving, List<Dictionary<string, int>> roomsDirections)
        {
           

           

            
            Dictionary<string, int> configForCurrentRoom = roomsDirections[roomID];
            DisplayStandardRoom(configForCurrentRoom);
            string choice = Console.ReadLine();
            if (configForCurrentRoom.ContainsKey(choice))
            {
                roomID = configForCurrentRoom[choice];
                if (sentenceWhenMoving.ContainsKey(choice))
                {
                    Console.Clear();
                    Console.WriteLine(sentenceWhenMoving[choice]);
                }
            }
            else
            {
                Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
            }
            return roomID;

        }

        
        

        


        static void Main(string[] args)
        {
            Dictionary<string, string> sentenceWhenMoving = new Dictionary<string, string>();
            sentenceWhenMoving.Add("n", "> going to north...");
            sentenceWhenMoving.Add("s", "> going to south...");
            sentenceWhenMoving.Add("e", "> going to east...");
            sentenceWhenMoving.Add("w", "> going to west...");

            List<Dictionary<string, int>> roomsDirections = new List<Dictionary<string, int>>();
            roomsDirections.Add(new Dictionary<string, int>() {
             { "n", 3 },
             { "e", 1 }
            });
            roomsDirections.Add(new Dictionary<string, int>() {
             { "n", 4 },
             { "w", 0 },
             { "e", 2 }
            });
            roomsDirections.Add(new Dictionary<string, int>() {
             { "n", 5 },
             { "w", 1 }
            });
            roomsDirections.Add(new Dictionary<string, int>() {
             { "s", 0 }
            });
            roomsDirections.Add(new Dictionary<string, int>() {
             { "s", 1 }
            });
            roomsDirections.Add(new Dictionary<string, int>() {
             { "s", 2 }
            });
            Console.OutputEncoding = Encoding.UTF8;
            Intro();

            bool gameRunning = true;
            int room_number = 1;
            while (gameRunning)
            {
               



                
                 if (room_number == 3)
                {
                    Loose();
                    gameRunning = false;
                }
                
                else if (room_number == 5)
                {
                    Win();
                    gameRunning = false;
                }
                else  
                {
                    room_number = room(room_number, sentenceWhenMoving, roomsDirections);

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







