
using System;
using System.Collections.Generic;
using System.Text;

namespace ToWatchList
{
    class ToWatch
    {
        
        public string Name { get; set; }
        public string Category { get; set; }

      


        public ToWatch(string Name, string Genre)
        {
            this.Name = Name;
            this.Category= Category;
        }

    //        bool goAgain = true;
    //        while (goAgain == true)
    //        {
    //         Console.WriteLine("This are the available movies.");
    //        Console.WriteLine();
    //       for (int i = 0; i<ToWatchList.Count; i++)
                
    //        {
    //            ToWatch t = ToWatchList[i];
    //    Console.WriteLine($" {i} : {t.Name}");
               
    //        }

    //Console.WriteLine();
    //        Console.WriteLine("What category would you like to watch? Please enter animated, drama, horror or scifi: ");
    //        Console.WriteLine();
    //        }
    }
}