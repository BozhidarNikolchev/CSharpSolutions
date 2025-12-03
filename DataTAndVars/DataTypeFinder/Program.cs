using System;

string inputData;
object resultType;

while ((inputData = Console.ReadLine()) != "END")
{
    if (int.TryParse(inputData, out int intResult))
    {
        resultType = "integer";
    }
    else if (float.TryParse(inputData, out float floatResult))
    {
        resultType = "floating point";
    }
    else if (char.TryParse(inputData, out char charResult))
    {
        resultType = "character";
    }
    else if (bool.TryParse(inputData, out bool boolResult))
    {
        resultType = "boolean";
    }
    else
    {
        resultType = "string";
    }

    Console.WriteLine($"{inputData} is {resultType} type");
}