﻿// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        if 

        // Create a string array with the lines of text
        string[] lines = ["First line", "Second line", "Third line"];

        // Set a variable to the Documents path.
        string docPath =
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        // Write the string array to a new file named "Challenges.csv".
        using (StreamWriter outStream = new(Path.Combine(docPath, "Challenges.csv")))
        {
            outStream.WriteLine("Apex Challenge Tracker");
            foreach (string line in lines)
                outStream.WriteLine(line);
        }
    }
}