int counter = int.Parse(Console.ReadLine());

string output = "";

string[] t9 = {
    " ",    
    "",     
    "abc",  
    "def",  
    "ghi",  
    "jkl",  
    "mno",  
    "pqrs", 
    "tuv",  
    "wxyz"  
};

for (int i = 0; i < counter; i++)
{
    string input = Console.ReadLine();

    int mainDigit = input[0] - '0';
    int pressCount = input.Length;

    if (mainDigit == 0)
    {
        output += " ";
    }
    else
    {
        output += t9[mainDigit][pressCount - 1];
    }
}

Console.WriteLine(output);