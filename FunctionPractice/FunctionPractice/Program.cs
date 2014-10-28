using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            int myAgeDoubled = DoubleIt(27);
            Console.WriteLine(DoubleIt(myAgeDoubled));

            //LoopTests();
            VowelCounter3000Tests();
            Console.ReadKey();
        }
        /// <summary>
        /// Writes "Hello world" to the console
        /// </summary>
        static void HelloWorld()
        {

            Console.WriteLine("Hello, World!");
        }
        static int DoubleIt(int someNumber)
        {
            return someNumber * 2;
        }
        /// <summary>
        /// Pringts numbers to the console from the start to the end
        /// </summary>
        /// <param name="startNumber">number the loops</param>
        /// <param name="endNumber">inclusive end point</param>
        static void LoopSomeNumbers(int startNumber, int endNumber)
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    
        /// <summary>
        /// Runs a series of tests on our LoopSomeNumbers function
        /// </summary>
     static void LoopTests() {
         LoopSomeNumbers(5,10);
         LoopSomeNumbers(5248,2947);
         LoopSomeNumbers(27, DoubleIt(27));
     }
        /// <summary>
        /// Returns the number of vowels in a string
        /// </summary> A string you want to count vowels in
        /// <param name="inputString"></param>
        /// <returns>The number of vowels found
     static int VowelCounter3000(string inputString)
     {
         // declare the counters for the vowels
         int numberOfVowelsFound = 0;

         //loop over each letter of the string
         for (int i = 0; i < inputString.Length; i++)
         {
             //take letter from string to make it lowercase
             string letter = inputString[i].ToString().ToLower();

             if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
             {
                 //found a vowel
                 numberOfVowelsFound = numberOfVowelsFound + 1;
             }

             //alternative way of checking to see if it's a vowel
             if ("aeiou".Contains(letter))
             {
                 

             }
             //time to write the output
             
         }
         Console.WriteLine(inputString + " has " + numberOfVowelsFound + " vowels in it");
        return numberOfVowelsFound;
     }



     static void VowelCounter3000Tests()
     {
         //count number of vowels counted
         int totalNumberofVowelsCounted = 0;
         totalNumberofVowelsCounted += VowelCounter3000("Jackie seems like a guy who'd like Nickleback");
         totalNumberofVowelsCounted += VowelCounter3000("I love instant mashed potatoes");
         Console.WriteLine("Total Vowels Counted" + totalNumberofVowelsCounted);
     }
         
         
         
     }
    
}


