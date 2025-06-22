List<string> chatResult = new List<string>();

while (true)
{
    string[] input = Console.ReadLine().Split();
    string command = input[0];

    if (command == "end")
    {
        foreach (string message in chatResult)
        {
            Console.WriteLine(message);
        }
        return;
    }
    else if (command == "Chat")
    {
        chatResult.Add(input[1]);
    }
    else if (command == "Delete")
    {
        if (chatResult.Contains(input[1]))
        {
            chatResult.Remove(input[1]);
        }
    }
    else if (command == "Edit")
    {
        string presentMessage = input[1];
        string newMessage = input[2];

        int index = chatResult.IndexOf(presentMessage);
        if (index != -1)
        {
            chatResult[index] = newMessage;
        }
    }
    else if (command == "Pin")
    {
        string givenMessage = input[1];

        if (chatResult.Contains(givenMessage))
        {
            chatResult.Remove(givenMessage);
            chatResult.Add(givenMessage);
        }
    }
    else if (command == "Spam")
    {
        for (int i = 1; i < input.Length; i++)
        {
            chatResult.Add(input[i]);
        }
    }
}
