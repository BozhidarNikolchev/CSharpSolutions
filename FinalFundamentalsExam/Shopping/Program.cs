Dictionary<string, List<string>> notepad = new Dictionary<string, List<string>>();
List<string> importantItems = new List<string>();
List<string> allItems = new List<string>();

while (true)
{
    string input = Console.ReadLine();
    if (input == "Go Shopping")
    {
        break;
    }

    string[] parts = input.Split(new string[] { "->" }, StringSplitOptions.None);

    if (parts[0] == "Add")
    {
        string store = parts[1];
        string itemsString = parts[2];
        string[] items = itemsString.Split(',');

        if (!notepad.ContainsKey(store))
        {
            notepad[store] = new List<string>();
        }

        for (int i = 0; i < items.Length; i++)
        {
            string item = items[i];
            if (!allItems.Contains(item))
            {
                notepad[store].Add(item);
                allItems.Add(item);
            }
        }
    }
    else if (parts[0] == "Important")
    {
        string store = parts[1];
        string item = parts[2];

        if (!allItems.Contains(item))
        {
            if (!notepad.ContainsKey(store))
            {
                notepad[store] = new List<string>();
            }
            notepad[store].Insert(0, item);
            importantItems.Add(item);
            allItems.Add(item);
        }
    }
    else if (parts[0] == "Remove")
    {
        string store = parts[1];

        if (notepad.ContainsKey(store))
        {
            bool hasImportant = false;
            for (int i = 0; i < notepad[store].Count; i++)
            {
                if (importantItems.Contains(notepad[store][i]))
                {
                    hasImportant = true;
                    break;
                }
            }
            if (!hasImportant)
            {
                for (int i = 0; i < notepad[store].Count; i++)
                {
                    string itemToRemove = notepad[store][i];
                    allItems.Remove(itemToRemove);
                }
                notepad.Remove(store);
            }
        }
    }
}

foreach (var store in notepad)
{
    Console.WriteLine(store.Key + ":");
    for (int i = 0; i < store.Value.Count; i++)
    {
        Console.WriteLine(" - " + store.Value[i]);
    }
}

