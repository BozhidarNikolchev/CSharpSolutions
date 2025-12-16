using var reader = new StreamReader(@".\Data\Input.txt");
using var writer = new StreamWriter(@".\Data\Output.txt", true);

    int counter = 1;

    while (true)
    {
        var line = reader.ReadLine();

        if (line == null)
        {
            break;
        }

        writer.WriteLine($"{counter}. {line}");
        counter++;
    }

Console.WriteLine("Done");


// . -> Current directory
// .. -> Parent directory

