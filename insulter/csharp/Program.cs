using System;
using System.Collections.Generic;

namespace Insulter
{
    class Program

    {
        static void Main(string[] args)
        {
            //   Making a list of strings named Insults
            List<string> Insults = new List<string>
            {

                "You look like what morning breath smells like.",
                "If you tried to give me cpr I would probably throw myself back under water",
                "I am not a fan of you",
                "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
                "I'd rather walk than be on the same plane as you",
                "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
                "Do you have to be so...like that?"

            };

            // getting random number, built in function in c#
            Random random = new Random();

            //  creates empty list
            List<int> indexes = new List<int>();

            //declares list of integers as 'indexes' and leaves it empty
            while (indexes.Count < 3)

            //   while indexes count is less than 3
            {
                // generates number based on the next  items in the insults list
                int candidate = random.Next(Insults.Count);
                if (!indexes.Contains(candidate))


                // if the  number doesnt exist in the indexes then add it to the list. 
                {
                    indexes.Add(candidate);
                }

            }
            //    for loop- looping over every item in the index list
            for (int i = 0; i < indexes.Count; i++)
            {
                int index = indexes[i];
                Console.WriteLine(Insults[index]);
            }

            // assign the value ewual to an index in the index list, and then print an insult and make a new line. 

        }
    }

}