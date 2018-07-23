using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone1_sumbat
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            while (runProgram)
            {
                Console.WriteLine("Welcome to the pig latin translater:");
                Console.WriteLine("Enter some words");
                // variable for letters
                string userInput = Console.ReadLine().ToLower();
                // variable for words
                string[] userInputArray = userInput.Split(' ');
                string modified = "";
                
                string vowels = "aeiou";
                StringBuilder sentence = new StringBuilder();

                // foreach (string word in userInputArray)
                // Method.Name



                foreach (string word in userInputArray)
                {

                    if (vowels.Contains(word[0]))
                    {
                        string word1 = (word + "way ");
                        sentence.Append(word1);
                    }
                    else
                    {
                        for (int n = 0; n <= word.Length; n++)
                        {
                            if (vowels.Contains(word[n]))
                            {
                                modified = word.Insert(n, "-");
                                string[] modifiedArray = modified.Split('-');
                                modified = word;
                                sentence.Append($"{modifiedArray[1]}{modifiedArray[0]}" + "ay ");
                                
                                break;
                            }
                        }
                    }
                }

                Console.WriteLine(sentence);
                Console.ReadKey();
                


                Console.WriteLine("Press Y to coninue:");
                string input = Console.ReadLine();
                if (input.ToLower() == "y")
                { runProgram = true; }
                else
                { runProgram = false; }
            }
           


            
        }
    }
}
