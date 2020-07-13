using System;

namespace Lab3._1_Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Dev.Build class. Which student would you like to learn more about?");
            Console.WriteLine();


            bool continueFlag = true;


            string[] names = { "Tony", "Phil", "Richard" };
            string[] candy = { "Sprees", "Gummy Bears", "Reese's Cup" };
            string[] previousTitle = { "Residential Computer Support Technician", "Desktop Technician", "US Army" };
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            while (continueFlag)
            {
                Console.Write("Would you like to see a list of all the students? Yes or No:");
                string listAll = Console.ReadLine();
                string listAllToUpper = listAll.ToUpper();
                if (listAllToUpper == "YES" || listAllToUpper == "Y")
                {
                    Console.WriteLine($"1. {names[0]}");
                    Console.WriteLine($"2. {names[1]}");
                    Console.WriteLine($"3. {names[2]}");
                }
                else if (listAllToUpper != "N" && listAllToUpper != "NO")
                {
                    Console.WriteLine("That is not a valid input.");

                }

                Console.Write("(enter a number 1-3):");
                string choice = Console.ReadLine();
                int entry = int.Parse(choice);
                bool carryOn = true;


                        if (entry == 1)
                        {
                            while (carryOn)
                            {
                                Console.WriteLine($"Student {entry} is {names[0]}. What would you like to know about {names[0]}?");
                                Console.WriteLine("");
                                Console.Write("enter \"favorite candy\" or \"previous title\":");
                                string input = Console.ReadLine();
                                string inputUpper = input.ToUpper();
                                if (inputUpper == "FAVORITE CANDY" || inputUpper == "CANDY")
                                {
                                    Console.WriteLine($"{names[0]}'s favorite candy is {candy[0]}.");
                                    Console.WriteLine("");
                                }
                                else if (inputUpper == "PREVIOUS TITLE" || inputUpper == "TITLE")
                                {
                                    Console.WriteLine($"{names[0]}'s previous title is {previousTitle[0]}.");
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.WriteLine("That data does not exist. Please try again. Hint:(\"favorite candy\" or \"previous title\" ONLY");
                                }

                                Console.WriteLine("Would you like to learn more about the current student? (enter \"yes\" or \"no\")");
                                string moreInfo = Console.ReadLine();
                                string moreInfoToUpper = moreInfo.ToUpper();

                                if (moreInfoToUpper == "NO" || moreInfoToUpper == "N")
                                {
                                    carryOn = false;
                                }
                                else if (moreInfoToUpper != "Y" && moreInfoToUpper != "YES")
                                {
                                    Console.WriteLine("That is not a valid input.");
                                    carryOn = false;
                                }
                            }

                        }
                        else if (entry == 2)
                        {
                            while (carryOn)
                            {
                                Console.WriteLine($"Student {entry} is {names[1]}. What would you like to know about {names[1]}?");
                                Console.WriteLine("");
                                Console.Write("enter \"favorite candy\" or \"previous title\":");
                                string input = Console.ReadLine();
                                string inputUpper = input.ToUpper();
                                if (inputUpper == "FAVORITE CANDY" || inputUpper == "CANDY")
                                {
                                    Console.WriteLine($"{names[1]}'s favorite candy is {candy[1]}.");
                                    Console.WriteLine("");
                                }
                                else if (inputUpper == "PREVIOUS TITLE" || inputUpper == "TITLE")
                                {
                                    Console.WriteLine($"{names[1]}'s previous title is {previousTitle[1]}.");
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.WriteLine("That data does not exist. Please try again. Hint:(\"favorite candy\" or \"previous title\" ONLY");
                                }

                                Console.WriteLine("Would you like to learn more about the current student? (enter \"yes\" or \"no\")");
                                string moreInfo = Console.ReadLine();
                                string moreInfoToUpper = moreInfo.ToUpper();

                                if (moreInfoToUpper == "NO" || moreInfoToUpper == "N")
                                {
                                    carryOn = false;
                                }
                                else if (moreInfoToUpper != "Y" && moreInfoToUpper != "YES")
                                {
                                    Console.WriteLine("That is not a valid input.");
                                    carryOn = false;
                                }
                            }
                }
                        else if (entry == 3)
                        {
                            while (carryOn)
                            {
                                Console.WriteLine($"Student {entry} is {names[2]}. What would you like to know about {names[2]}?");
                                Console.WriteLine("");
                                Console.Write("enter \"favorite candy\" or \"previous title\":");
                                string input = Console.ReadLine();
                                string inputUpper = input.ToUpper();
                                if (inputUpper == "FAVORITE CANDY" || inputUpper == "CANDY")
                                {
                                    Console.WriteLine($"{names[2]}'s favorite candy is {candy[2]}.");
                                    Console.WriteLine("");
                                }
                                else if (inputUpper == "PREVIOUS TITLE" || inputUpper == "TITLE")
                                {
                                    Console.WriteLine($"{names[2]}'s previous title is {previousTitle[2]}.");
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.WriteLine("That data does not exist. Please try again. Hint:(\"favorite candy\" or \"previous title\" ONLY");
                                }

                                Console.WriteLine("Would you like to learn more about the current student? (enter \"yes\" or \"no\")");
                                string moreInfo = Console.ReadLine();
                                string moreInfoToUpper = moreInfo.ToUpper();

                                if (moreInfoToUpper == "NO" || moreInfoToUpper == "N")
                                {
                                    carryOn = false;
                                }
                                else if (moreInfoToUpper != "Y" && moreInfoToUpper != "YES")
                                {
                                    Console.WriteLine("That is not a valid input.");
                                    carryOn = false;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("That student does not exist. Please try again. (enter a number 1-3):");
                        }
                        
                
                        Console.WriteLine("Would you like to know about another student? (enter \"yes\" or \"no\")");
                        string breakProgram = Console.ReadLine();
                        string breakToUpper = breakProgram.ToUpper();

                        if (breakToUpper == "NO" || breakToUpper == "N")
                        {
                            continueFlag = false;
                        }
                        else if (breakToUpper != "Y" && breakToUpper != "YES")
                        {
                            Console.WriteLine("That is not a valid input. Exiting the program.");
                            continueFlag = false;
                        }

            }
        }
    }
}
