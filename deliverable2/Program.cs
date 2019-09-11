using System;
using System.Collections.Generic;

namespace deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while (done == false)
            {

                // Initial greeting for user
                Console.WriteLine("What's up!? What are you in the mood for today?");
                Console.WriteLine("Here are your options, select the corresponding number and press enter:");
                Console.WriteLine("1. Action");
                Console.WriteLine("2. Chilling");
                Console.WriteLine("3. Danger");
                Console.WriteLine("4. Good Food");

                // Initial data collection, test to make sure it is a number
                string splace = Console.ReadLine();
                bool IsNumber(string test)
                {
                    int i;
                    return int.TryParse(test, out i);
                }

                if (IsNumber(splace) == true)
                {
                    int place = Convert.ToInt32(splace);

                    // Convert string to integer to trigger remaining questions          
                    if (place >= 0 && place < 5)
                    {
                        Console.WriteLine("Please enter the number of people coming with you:");
                        string speople = Console.ReadLine();
                        int people = Convert.ToInt32(speople);
                        if (people >= 0)
                        {
                            Console.WriteLine("Awesome. If you are in the mood for " + whatToDo(place) + ", then you should go " + toDo(place) + " and travel in " + howToDo(people));
                            Console.WriteLine("See ya later!");
                            done = true;
                        }
                        else
                        {
                            Console.WriteLine("I'm not sure what you should do, press enter and try again.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("I'm not sure what you should do, press enter and try again.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else
                {
                 Console.WriteLine("I'm not sure what you should do, press enter and try again.");
                 Console.ReadLine();
                 Console.Clear();   
                }
            }
        }

        // Methods used to decipher inputs and return information for user
        static string whatToDo(int bigMood)
        {
            var moodList = new List<string> { "nothing", "action", "chilling", "danger", "good food" };
            if (bigMood >= 1 && bigMood <= 4)
            {
                return moodList[bigMood];
            }
            else
            {
                string error = ("Error!");
                return error;
            }
        }

        static string toDo(int placeToBe)
        {
            var placesToGo = new List<string> { "nowhere", "stock car racing", "hiking", "skydiving", "to Taco Bell" };
            if (placeToBe >= 1 && placeToBe <= 4)
            {
                return placesToGo[placeToBe];
            }
            else
            {
                string error = ("Error!");
                return error;
            }      
        }

        static string howToDo(int placeToBe)
        {
            int peopleHere = placeToBe;
            if (peopleHere == 0)
            {
                string howToDo = ("sneakers.");
                return howToDo;
            }
            else if (peopleHere >= 1 && peopleHere <= 5)
            {
                string howToDo = ("a sedan.");
                return howToDo;
            }
            else if (peopleHere >= 6 && peopleHere <= 10)
            {
                string howToDo = ("a Volkswagen bus.");
                return howToDo;
            }
            else if (peopleHere > 10)
            {
                string howToDo = ("an airplane.");
                return howToDo;
            }
            else
            {
                string howToDo = ("Error.");
                return howToDo;
            }
        }
    }
}
