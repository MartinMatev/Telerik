using System;
using System.Collections.Generic;

class IntrestingDataStructures
{
    static void Main()
    {
        List<string> words = new List<string>();

        words.Add("karakondjul");
        words.Add("something");

        words.Remove("something");  // SLOW
        words.RemoveAt(0);  // removes the value at the index 0

        // Hashset - quicker. Drawbacks - no indexer !
        HashSet<string> quickWords = new HashSet<string>();
        quickWords.Add("chiburashka");
        quickWords.Remove("something");

        // Hashset takes into account ONLY unique items, since it has NO indexer !!!
        HashSet<int> test = new HashSet<int>();
        test.Add(1);
        test.Add(1);
        test.Add(1);
        test.Add(1);
        test.Add(5);
        test.Add(5);
        test.Add(7);
        // After all this it will contain 1 and 5 ONLY ONCE!

        test.Remove(5); // Since no indexer, we must give him the exact name of the value !

        // We CAN foreach the hashset !!
        Console.WriteLine("HASHSET");
        foreach (var number in test)
        {
            Console.WriteLine(number);
        }

        // Adds everything SORTED, again NO indexer  !!!!
        SortedSet<int> sortedNumbers = new SortedSet<int>();

        sortedNumbers.Add(5);
        sortedNumbers.Add(2);
        sortedNumbers.Add(8);
        sortedNumbers.Add(4);

        Console.WriteLine("SORTED SET");
        foreach (var number in sortedNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("DICTIONARY");
        // First `string` is for the type of the KEY, next `string` is for the type of the VALUE
        // Dictionaries work like arrays, but you can CHANGE their indexes, to NOT be only numbers like an arrays
        Dictionary<string, string> dict = new Dictionary<string, string>();

        // Assign to the KEY pesho, VALUE of 550
        dict.Add("pesho", "550");

        // assigns to the variable peshosResult the VALUE of the key(index) dict["pesho"];
        string peshosResult = dict["pesho"];
        dict["pesho"] = "gosho";    // assigns to the key "pesho", the value "gosho"
        
        Console.WriteLine(peshosResult);
        Console.WriteLine(dict["pesho"]);

        if (dict.ContainsKey("pesho"))
        {
            dict["pesho"] += 1;
        }
        else
        {
            dict["pesho"] = "1";
        }

        Console.WriteLine(dict["pesho"]);

        Console.WriteLine("SORTED DICT");
        // Sorting dictionary. Sorts the added KEYS
        SortedDictionary<string, string> sortedDict = new SortedDictionary<string, string>();
        sortedDict["gosho"] = "550";
        sortedDict["abc"] = "600";
        sortedDict["aaa"] = "1000";

        foreach (var name in sortedDict.Keys)
        {
            string value = sortedDict[name]; // we loop the KEYS, take they values and CW them 
            Console.WriteLine(value);
        }
    }
}