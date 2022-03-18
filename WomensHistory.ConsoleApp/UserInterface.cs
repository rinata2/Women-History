using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WomensHistory.Repository;

namespace WomensHistory.ConsoleApp
{
    public class UserInterface
    {
    WomanRepository _womanRepo = new WomanRepository();
    bool isRunning = true;

        public void Run()
        {
            _womanRepo.SeedWomanData();

            while (isRunning)
            {
                PrintMainMenu();

                string input = GetUserInput();

                UserInputSwitchCase(input);
            }
        }

        private void PrintMainMenu()
        {
            Console.WriteLine("\n1. Add new woman.\n" +
                    "2. View all women.\n" +
                    "3. View one woman.\n" +
                    "4. Edit woman.\n" +
                    "5. Delete woman.\n" +
                    "6. Exit.\n"
            );

            Console.Write("Enter Selection: ");
        }  
        

        private string GetUserInput()
        {
            return Console.ReadLine();
        }

        private void UserInputSwitchCase(string input)
        {
            switch (input)
            {
                case "1":
                    CreateNewWoman();
                    break;
                case "2":
                    ViewAllWomen();
                    break;
                case "3":
                    ViewWoman();
                    break;
                case "4":
                    EditWoman();
                    break;
                case "5":
                    DeleteWoman();
                    break;
                case "6":
                    isRunning = false;
                    ExitApplication();
                    break;
                default:
                    break;
            }
        }
//Create a NEW WOMAN
        private void CreateNewMovie()
        {
            Console.WriteLine("Create a NEW WOMAN:");

            Console.Write("\nName: ");
            string name = GetUserInput();

            Console.Write("\nAge: ");
            string gererationName = GetUserInput();

            Console.WriteLine("\n Woman Genres:\n" +
                    "1. Alpha\n" +
                    "2. Baby_Boomer_I\n" +
                    "3. Baby_Boomer_II\n" +
                    "4. Greatest\n" +
                    "5. Lost\n" +
                    "6. Millenal\n" +
                    "7. Silent\n" +
                    "8. X\n" +
                    "8. Z\n"

            );
//Select Generation
            Console.Write("\nSelect Generation: ");
            string generationSelection = GetUserInput();

            Generation generation = Generation.Alpha;

            switch (generationSelection)
            {
                case "1":
                    generation = Generation.Baby_Boomer_I;
                    break;
                case "2":
                    generation = Generation.Baby_Boomer_I;
                    break;
                case "3":
                    generation = Generation.Baby_Boomer_II;
                    break;
                case "4":
                    generation = Generation.Greatest;
                    break;
                case "5":
                    generation = Generation.Lost;
                    break;
                case "6":
                    generation = Generation.Millenal;
                    break;
                case "7":
                    generation = Generation.Silent;
                    break;
                case "8":
                    generation = Generation.X;
                    break;
                    case "9":
                    generation = Generation.Z;
                    break;
                default:
                    break;
            }
        
            // //Console.WriteLine("\nMovie Rating:\n" +
            //         "1. G\n" +
            //         "2. PG\n" +
            //         "3. PG-13\n" +
            //         "4. R\n" +
            //         "5. MA\n"
            // );

            // Console.Write("\nSelect Movie Rating: ");
            // string ratingSelection = GetUserInput();

            // Rating rating = Rating.G;

            // switch (ratingSelection)
            // {
            //     case "1":
            //         rating = Rating.G;
            //         break;
            //     case "2":
            //         rating = Rating.PG;
            //         break;
            //     case "3":
            //         rating = Rating.PG_13;
            //         break;
            //     case "4":
            //         rating = Rating.R;
            //         break;
            //     case "5":
            //         rating = Rating.MA;
            //         break;
            //     default:
            //         break;
            // }

bool iLoveGloss = true ? "I love gloss" : "I do  not like gloss"; 

        //    / Console.Write("\nNumber of STARS: ");
        //     int stars = Convert.ToInt32(GetUserInput());
        //     //int stars = (int)Console.ReadLine();
//Add Movie To List
        Woman newWoman = new Woman(name, age, generation, gloss);

        _womanRepo.AddWomanToList(newWoman);
        // }
        }
        private void PrintWoman(Woman woman)
        {
            Console.WriteLine($"\n {woman.Name}\n" +
                    $"And her age is: {woman.Age}\n" +
                    $"Generation: {woman.Generation}\n" +
                    $"Does she wear gloss: {woman.Gloss}\n" 
            );
        }
//View All Women
        private void ViewAllWomen()
        {
            List<Women> allWomen = _womenRepo.GetAllWomenFromList();
            foreach (Women women in allWomen)
            {
                PrintWoman(tomato);
            }

            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
        
//View Movie
        private void ViewWoman()
        {
            Console.Write("Please enter a woman name: ");
            string name = GetUserInput();

            Woman woman = _womanRepo.GetNameFromListByWomen(woman);

            if (woman != null)
            {
                PrintMovie(movie);
                Console.WriteLine("\nPress any key to continue....");
            }
            else
            {
                Console.WriteLine("We couldn't find that woman. Press any key to continue....");
            }

            Console.ReadKey();
        }
//Edit  Movie
        private void EditWoman()
        {
            Console.Write("\nPlease enter the name of the woman you'd like to edit: ");
            string name = Console.ReadLine();

            Gereration gereration = _gererationRepo.GetMovieFromListByName(name);

            if (woman != null)
            {
                PrintWoman(woman);          

            Console.Write("\n Name: ");
            string newname = GetUserInput();

            Console.Write("\nAge: ");
            string gererationName = GetUserInput();

            Console.WriteLine("\n Woman Gereration:\n" +
                    "1. Alpha\n" +
                    "2. Baby_Boomer_I\n" +
                    "3. Baby_Boomer_II\n" +
                    "4. Greatest\n" +
                    "5. Lost\n" +
                    "6. Millenal\n" +
                    "7. Silent\n" +
                    "8. X\n" +
                    "8. Z\n"

            );
//Select Generation
            Console.Write("\nSelect Generation: ");
            string generationSelection = GetUserInput();

            Generation generation = Generation.Alpha;

            switch (generationSelection)
            {
                case "1":
                    generation = Generation.Baby_Boomer_I;
                    break;
                case "2":
                    generation = Generation.Baby_Boomer_I;
                    break;
                case "3":
                    generation = Generation.Baby_Boomer_II;
                    break;
                case "4":
                    generation = Generation.Greatest;
                    break;
                case "5":
                    generation = Generation.Lost;
                    break;
                case "6":
                    generation = Generation.Millenal;
                    break;
                case "7":
                    generation = Generation.Silent;
                    break;
                case "8":
                    generation = Generation.X;
                    break;
                    case "9":
                    generation = Generation.Z;
                    break;
                default:
                    break;
            }

                // Console.WriteLine("\nMovie Rating:\n" +
                //     "1. G\n" +
                //     "2. PG\n" +
                //     "3. PG-13\n" +
                //     "4. R\n" +
                //     "5. MA\n");

                // Console.Write("\nSelect NEW Movie Rating: ");
                // string newRatingSelection = GetUserInput();

                // Rating newRating = movie.MovieRating;

                // switch (newRatingSelection)
                // {
                //     case "1":
                //         newRating = Rating.G;
                //         break;
                //     case "2":
                //         newRating = Rating.PG;
                //         break;
                //     case "3":
                //         newRating = Rating.PG_13;
                //         break;
                //     case "4":
                //         newRating = Rating.R;
                //         break;
                //     case "5":
                //         newRating = Rating.MA;
                //         break;
                //     default:
                //         break;
                // }

                // bool newIsKidFriendly = movie.IsKidFriendly;

                // if (newRating == Rating.G || newRating == Rating.PG)
                // {
                //     newIsKidFriendly = true;
                // }

                // Console.Write("\nNEW STARS: ");
                // int newStars = Convert.ToInt32(GetUserInput());
                //int stars = (int)Console.ReadLine();
//updated Woman
                Movie updatedWoman = new Movie(newName, newAge, newGeneration, newGloss);

                if (updatedWoman.Name.ToUpper() == woman.Name.ToUpper())
                {
                    bool isSuccess = _womnRepo.UpdateWoman(updatedWoman);
                    Console.WriteLine($"Successfully updated {updatedWoman.Name}. Press any key to continue....");
                }
                else
                {
                    bool isSuccess = _womanRepo.UpdateWoman (updatedWoman, woman.Name);
                    Console.WriteLine($"Successfully updated {updatedwoman.Name}. Press any key to continue....");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.WriteLine("We couldn't find that woman. Press any key to continue....");
                Console.ReadKey();
            }
        }
//Delete Woman
        private void DeleteWoman()
        {
            Console.Write("\nEnter title of woamn to delete: ");
            string input = GetUserInput();

            bool isSuccess = _womanRepo.DeleteWomanByName(input);

            if (isSuccess)
            {
                Console.WriteLine("Woman was successfully deleted. Press any key to continue....");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("We couldn't find that your woman. Press any key to continue....");
                Console.ReadKey();
            }

        }
//Exit Application
        public void ExitApplication()
        {
            Console.WriteLine("We hate to see you go. Press any key to EXIT....");
            Console.ReadKey();
        }
        //next method
        }
    }
