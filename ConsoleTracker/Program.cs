// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        // Set a variable to the Documents path to read previous challenges data
        string docPath =
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        // Create string lists with the challenge options & the printed data
        List<string> challengeOptions = new List<string>();
        List<string> lines = new List<string>();

        bool isDone = false;

        while (isDone == false)
        {
            int four = Program.Menu();
        }





        // Write the string array to a new file named "Challenges.csv".
        using (StreamWriter outStream = new(Path.Combine(docPath, "Challenges.csv")))
        {
            outStream.WriteLine("Apex Challenge Tracker");
            foreach (string line in lines)
                outStream.WriteLine(line);
        }
    }
    static int Menu()
    {
        Console.Write("Welcome to the Apex Legends Challenge Tracker\n" +
                      "Options:\n" +
                      "1. Add challenges\n" +
                      "2. Remove challenges\n" +
                      "3. View challenges\n" +
                      "4. Exit & Export\n"+
                      "\nEnter your choice (1, 2, 3, 4): ");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
            Console.Write("\nEnter your choice (1, 2, 3, 4): ");
        }

        return choice;
    }
}