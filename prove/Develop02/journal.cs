using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

class Journal{

    // Atributes 
    // public List<string> _journal = new();
    public List<Entry> _journalEntries = new();



    // Behaviors
    public void Display()
    {
        // Prints the dictionary of journal entries. 
        foreach (Entry journal in _journalEntries)
        {
            Console.WriteLine();
            journal.Display();
        }

        
    }

    
}
