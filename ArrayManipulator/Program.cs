
//int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

//string command = string.Empty;

//while ((command = Console.ReadLine()) != "end")
//{
//    string[] arguments = command.Split();
//    string firstArgument = arguments[0];
    
//    switch (firstArgument)
//    {
//        case "exchange":
//            int swappingIndex = int.Parse(arguments[1]);

//            if (swappingIndex < inputArray.Length && swappingIndex > inputArray.Length)
//            {
//                Console.WriteLine("Invalid index");
//            }
//            else
//            {
//                inputArray = SwapArrayAccordingToIndex(inputArray, swappingIndex);
//            }
//            break;

//        case "max":
//            string evenOrOdd = arguments[1];
//            Console.WriteLine(MaxOddOrEvenIndex(inputArray, evenOrOdd));
//            break;

//        case "min":

//            break;

//        case "first":

//            break;

//        case "last":

//            break;
//    }
//}

//static int MaxOddOrEvenIndex(int[] array, string oddOrEvenCommand)
//{
//    int index = 0;
//    int biggestNumber = int.MinValue;

//    if (oddOrEvenCommand == "odd")
//    {
//        for(int i = 0; i < array.Length; i++)
//        {
//            if (array[i] % 2 != 0)
//            {
//                if (array[i] > biggestNumber)
//                {
//                    biggestNumber = array[i];
//                    index = i;
//                }
//            }
//        }
//    }
//    else if (oddOrEvenCommand == "even")
//    {
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] % 2 == 0)
//            {
//                if (array[i] > biggestNumber)
//                {
//                    biggestNumber = array[i];
//                    index = i;
//                }
//            }
//        }
//    }

//    return index;
//}


//static int[] SwapArrayAccordingToIndex(int[] array, int index)
//{
//    int[] changedArray = new int[array.Length];
//    int currentIndex = 0;

//    for (int i = index + 1; i < array.Length; i++)
//    {
//        changedArray[currentIndex] = array[i];
//        currentIndex++;
//    }

//    for (int i = 0; i <= index; i++)
//    {
//        changedArray[currentIndex] = array[i];
//        currentIndex++;
//    }

//    return changedArray;
//}