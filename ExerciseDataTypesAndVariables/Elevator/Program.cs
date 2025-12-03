int numberOfPeople = int.Parse(Console.ReadLine());
int capacityOfElevator = int.Parse(Console.ReadLine());

int fullCapacityCourses = numberOfPeople / capacityOfElevator;
int underCapacityPeopleLeft = numberOfPeople % capacityOfElevator;

if (numberOfPeople > capacityOfElevator)
{
    if (underCapacityPeopleLeft > 0 && underCapacityPeopleLeft < numberOfPeople)
    {
        Console.WriteLine(fullCapacityCourses + 1);
    }
    else if (underCapacityPeopleLeft == 0)
    {
        Console.WriteLine(fullCapacityCourses);
    }
}
else if (numberOfPeople < capacityOfElevator)
{
    Console.WriteLine(1);
}
