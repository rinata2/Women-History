using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WomensHistory.Repository;

namespace WomensHistory.ConsoleApp
{
    public class UserInterface
    {
       Wom _movieRepo = new MovieRepository();
        bool isRunning = true;

        public void Run()
        {
            _movieRepo.SeedMovieData();

            while (isRunning)
            {
                PrintMainMenu();

                string input = GetUserInput();

                UserInputSwitchCase(input);
            }
        }

        private void PrintMainMenu()
        {
            Console.WriteLine("\n1. Add new movie.\n" +
                    "2. View all movies.\n" +
                    "3. View one movie.\n" +
                    "4. Edit movie.\n" +
                    "5. Delete movie.\n" +
                    "6. Exit.\n"
            );

            Console.Write("Enter Selection: ");
        }  
    }
}