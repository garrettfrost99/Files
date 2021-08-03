using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    public class FileExercises
    {
        public void exerciseOne()
        {
            var path = @"C:\Users\Garrett\source\repos\Files\Files\test.txt";
            string[] words;
            var increment = 0;

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Something");
                sw.WriteLine("Something");
                sw.WriteLine("Something");
                sw.WriteLine("Something");
                sw.WriteLine("Something");
                sw.WriteLine("Something");
                sw.WriteLine("Something");
                sw.WriteLine("Something");
            }

            words = File.ReadAllLines(path);
            foreach (var word in words)
            {
                increment++;
            }

            Console.WriteLine(increment);
        }
        public void exerciseTwo()
        {
            var path = @"C:\Users\Garrett\source\repos\Files\Files\test.txt";
            string[] words;
            string longestWord = "";
            var counter = 0;
            var longestWordLength = 0;

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Something");
                sw.WriteLine("Nothing");
                sw.WriteLine("But");
                sw.WriteLine("Text");
                sw.WriteLine("Encyclopedia");
                sw.WriteLine("Bullet");
            }

            words = File.ReadAllLines(path);
            foreach (var word in words)
            {
                if (word.Length > longestWordLength)
                {
                    longestWord = word;
                    longestWordLength = word.Length;
                }

                counter++;
            }

            Console.WriteLine(longestWord);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var exercise1 = new FileExercises();
            //exercise1.exerciseOne();

            var exercise2 = new FileExercises();
            exercise2.exerciseTwo();
        }
    }
}
