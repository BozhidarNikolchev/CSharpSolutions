//////using var reader = new StreamReader(@"..\..\..\Data\Input.txt");
//////using var writer = new StreamWriter(@"..\..\..\Data\Output.txt", true);

//////    int counter = 1;

//////    while (true)
//////    {
//////        var line = reader.ReadLine();

//////        if (line == null)
//////        {
//////            break;
//////        }

//////        writer.WriteLine($"{counter}. {line}");
//////        counter++;
//////    }

//////Console.WriteLine("Done");


//////// . -> Current directory
//////// .. -> Parent directory



//// Memory Stream:

//////using System.Text;

//////var memory = new MemoryStream();

//////string text = "My friend";

//////var textBytes = Encoding.UTF8.GetBytes(text);

//////memory.Write(textBytes, 0, textBytes.Length);

//////memory.Flush();

//////var result = memory.ToArray();

//////Console.WriteLine(Encoding.UTF8.GetString(result, 0, result.Length));



//// Memory Stream:

////using System.Text;

////using var memory = new MemoryStream();

////string text = "John Doe";

////var textBytes = Encoding.UTF8.GetBytes(text);

////memory.Write(textBytes, 0, textBytes.Length); // 3, 6 buffer

////memory.Flush();

////memory.Seek(0, SeekOrigin.Begin);

////var result = new byte[memory.Length];

////memory.Read(result, 0, result.Length); // / 2 buffer

////Console.WriteLine(Encoding.UTF8.GetString(result, 0, result.Length));

////memory.Close(); 


//// File Stream

//using System.Text;

//using var fileStreamCreate = new FileStream("log.bin", FileMode.Create);

//var bufferCreate = Encoding.UTF8.GetBytes("C# Advanced - Lecture about streams");

//fileStreamCreate.Write(bufferCreate, 0, bufferCreate.Length);

//fileStreamCreate.Close();

//using var fileStreamOpen = new FileStream("log.bin", FileMode.Open);

////var bufferOpen = new byte[fileStreamOpen.Length];

//var resultText = string.Empty;

//while (true)
//{
//    var bufferOpen = new byte[4];

//    int read = fileStreamOpen.Read(bufferOpen);

//    if (read == 0)
//    {
//        break;
//    }

//    var currentBufferText = Encoding.UTF8.GetString(bufferOpen);
//    resultText += currentBufferText;
//}



////fileStreamOpen.Read(bufferOpen, 0, bufferOpen.Length); // what buffer to read but this is once
////var resultText = Encoding.UTF8.GetString(bufferOpen);

//Console.WriteLine(resultText);



// Crypt 

//int num = 100;
//int pw = 443;

//var encrypted = num ^ pw;

////Console.WriteLine(encrypted); // 479
//Console.WriteLine(encrypted ^ pw); // 100


// Encrypting files

//int password = 187;

//var byteContent = File.ReadAllBytes("cats.jpg");

//for (int i = 0; i < byteContent.Length; i++)
//{
//    byteContent[i] = (byte)(byteContent[i] ^ password);
//}

//File.WriteAllBytes("cats-encrypted.jpg", byteContent);

// Decrypting files

//int password = 187;

//var byteContent = File.ReadAllBytes("cats-encrypted.jpg");

//for (int i = 0; i < byteContent.Length; i++)
//{
//    byteContent[i] = (byte)(byteContent[i] ^ password);
//}

//File.WriteAllBytes("cats-decrypted.jpg", byteContent);



// Directories - create, delete, get files, get directories

//Console.WriteLine(Directory.GetCurrentDirectory());

//Directory.CreateDirectory(@"My new directory\ Sub directory\ More directories\ Final directory");

//Directory.Delete("My new directory", true);

//var currentDirectory = Directory.GetCurrentDirectory();
//var files = Directory.GetFiles(currentDirectory);
//foreach (var file in files)
//{
//    var fileInfo = new FileInfo(file);
//    Console.WriteLine(fileInfo.Length); // Many methods and properties
//}

var currentDirectory = Directory.GetCurrentDirectory();
var directories = Directory.GetDirectories(currentDirectory);
foreach (var directory in directories)
{
    var directoryInfo = new DirectoryInfo(directory);
    Console.WriteLine(directoryInfo.Parent);
}