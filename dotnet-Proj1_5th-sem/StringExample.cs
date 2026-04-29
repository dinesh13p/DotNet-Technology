using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnettutorials
{
    internal class StringExample
    {
        public void run() {
            //example();
            findLongestWord();
        }

        private void findLongestWord()
        {
            string input = Console.ReadLine();
            var splittedWord = input.Split(' ');
            string longestWord = "";

            foreach (var word in splittedWord)
            {
                if (word.Length > longestWord.Length) longestWord = word;
                {
                    longestWord = word;
                }
                Console.WriteLine(longestWord);
            }
        }
        private void example()
        {
            string fname = "Galyang";
            string lname = "Bhattarai";

            string fullname = fname + " " + lname;
            Console.WriteLine(fullname);
            string fullNameMessage = $"Full name is {fullname}";
            Console.WriteLine(fullNameMessage);

            int stringLength = fname.Length;

            //it takes 2 parameters
            //first = where to start
            //second = number of character;
            string substring1 = fname.Substring(2, 2);
            string substring2 = lname.Substring(3, 2);

            Console.WriteLine(substring1);
            Console.WriteLine(substring2);


            string splitString = "my,name,is,galyang";
            var splittedString = splitString.Split(' ');

            foreach (string s in splittedString)
            {
                Console.WriteLine(s);
            }

        }
    }
}
