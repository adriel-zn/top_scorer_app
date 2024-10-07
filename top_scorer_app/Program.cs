using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace top_scorer_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "TestData.csv";

            //Check if the file is valid and does exist.
            if (File.Exists(filePath))
            {
                //create a dictionary of scores and read all strings excluding the headers.
                var scores = File.ReadLines(filePath)
                    .Skip(1)
                    .Select(line => line.Split(','))
                    .ToDictionary(splitStr => $"{splitStr[0]} {splitStr[1]}", splitStr => int.Parse(splitStr[2]));

                if (scores.Count != 0)
                {
                    // Get max of the highest scorers.
                    int highestScore = scores.Values.Max();

                    // Get and sort fullnames of highest scorers.
                    var topScorers = scores
                        .Where(kvp => kvp.Value == highestScore)
                        .Select(kvp => kvp.Key)
                        .OrderBy(name => name)
                        .ToList();

                    // Print top scorers with the highest score.
                    Console.WriteLine(string.Join(Environment.NewLine, topScorers));
                    Console.WriteLine($"\nScore: {highestScore}");
                }
                else
                {
                    //Display message when there is no data.
                    Console.WriteLine($"{filePath} has no data to display highest scorers!");
                }
            }
            else
            {
                //Display message when file is not found or valid.
                Console.WriteLine($"File not found!");
            }
            
            Console.WriteLine($"\nPress enter to exit this dialog.");

            Console.ReadLine();
        }
    }
}
