using System;

class Program
{
    static void Main(string[] args)
    {
        // This is for the journal program 
        string fileName;
        Journal newJournal = new();
        Prompt newPrompt = new();

        int option; // Declare the variable for user input

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");
            
            // Get user input
            string input = Console.ReadLine();

            // Try to parse the input to an integer
            // ",out option" was provided by ai, but tryParse, takes "input" and trys to parse it as an int
            //      if it works, input is set to option. If it doesnt work tryParse will return false.
            if (int.TryParse(input, out option))
            {
                switch (option)
                {
                    // write
                    case 1:
                        Entry newEntry = new();
                        newEntry._prompt = newPrompt.GeneratePrompt();

                        Console.WriteLine(newEntry._prompt);
                        string userEntry = Console.ReadLine();
                        newEntry._journalInput = userEntry;

                        newEntry._date = DateTime.Now;

                        newJournal._journalEntries.Add(newEntry);

                        break;

                    // Display
                    case 2:
                        newJournal.Display();
                        break;
                    // load
                    case 3:
                        
                        Console.WriteLine("What is the file name: ");
                        fileName = Console.ReadLine();

                        newJournal = LoadFile(fileName);
                        newJournal.Display();

                        break;
                    // save
                    case 4:
                        
                        Console.WriteLine("What is the file name: ");
                        fileName = Console.ReadLine();

                        SaveFile(fileName, newJournal);

                        break;
                    // quit
                    case 5:
                        Console.WriteLine("Quitting...");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
                option = 0; // Reset option to ensure loop continues
            }

            Console.WriteLine(); 
        } while (option != 5);

    }

    static void SaveFile(string fileName, Journal journalEntries)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry journal in journalEntries._journalEntries)
            {
                outputFile.Write($"{journal._date.ToShortDateString()}|{journal._prompt}|{journal._journalInput}|\n");
            }
        }
    }

    static Journal LoadFile(string fileName)
    {
        Journal newJournal = new();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] journal = line.Split("|");

            Entry newEntry = new();

            newEntry._date = DateTime.Parse(journal[0]);
            newEntry._prompt = journal[1];
            newEntry._journalInput = journal[2];

            newJournal._journalEntries.Add(newEntry); 
        }

        return newJournal;
    }
}