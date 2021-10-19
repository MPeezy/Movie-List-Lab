using System;
using System.Collections.Generic;
using System.Text;

namespace ToWatchList
{
    class MovieDatabase
    {
       
        public List<ToWatch> ToWatchList { get; set; } = new List<ToWatch>();

        //This is the constructor, it matches the class name
        public MovieDatabase()
        {
            ToWatchList.Add(new ToWatch("The Lion King", "animated"));
            ToWatchList.Add(new ToWatch("Moana", "animated"));
            ToWatchList.Add(new ToWatch("Hercules", "animated"));
            ToWatchList.Add(new ToWatch("Aladin", "animated"));

            ToWatchList.Add(new ToWatch("Forrest Gump", "drama"));
            ToWatchList.Add(new ToWatch("Titanic", "drama"));

            ToWatchList.Add(new ToWatch("Candyman", "horror"));
            ToWatchList.Add(new ToWatch("Us", "horror"));

            ToWatchList.Add(new ToWatch("Avatar", "scifi"));
            ToWatchList.Add(new ToWatch("Back To The Future", "scifi"));


        }


        public void PrintToWatchList()
        {
            Console.WriteLine("This are the available movies.");
            Console.WriteLine();
           for (int i = 0; i < ToWatchList.Count; i++)
                
            {
                ToWatch t = ToWatchList[i];
                Console.WriteLine($" {i} : {t.Name}");
               
            }

            Console.WriteLine();
            Console.WriteLine("What category would you like to watch? Please enter animated, drama, horror or scifi: ");
            Console.WriteLine();
        }

      

        public void SearchListByCategory(string searchTerm)
        {
            for (int i = 0; i < ToWatchList.Count; i++)
            {
                ToWatch t = ToWatchList[i];
                if (t.Category.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Name: " + t.Name);
                    Console.WriteLine("Category: " + t.Category);
                    Console.WriteLine();
                }
            }
        }


        public string GetUserInput(string prompt)
        {

            Console.WriteLine(prompt);
            string input = Console.ReadLine();

            return input;
        }

        ////PUT IN CONTINUE LOOP
        
        //Console.WriteLine("Would you like to return to the menu?: y/n");
        //            string returnToMenu = Console.ReadLine().ToLower();

        //            if (returnToMenu == "n")
        //            {
        //                goAgain = false;

        //                Console.WriteLine("Thanks!");
        //            }

        //            else if (returnToMenu == "y")
        //            {
        //                goAgain = true;
        //                //loop to top
        //            }

    }
}