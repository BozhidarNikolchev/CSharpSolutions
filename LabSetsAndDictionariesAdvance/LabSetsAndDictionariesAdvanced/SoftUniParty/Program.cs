var vipGuestsList = new HashSet<string>();
var regularGuestsList = new HashSet<string>();

while (true)
{
    string reservationNumber = Console.ReadLine();

    if (reservationNumber == "PARTY") break;

    if (reservationNumber.Length == 8)
    {
        if (char.IsDigit(reservationNumber[0]))
        {
            vipGuestsList.Add(reservationNumber);
        }
        else
        {
            regularGuestsList.Add(reservationNumber);
        }
    }
}

while (true)
{
    string arrivedGuest = Console.ReadLine();

    if (arrivedGuest == "END") break;

    if (vipGuestsList.Contains(arrivedGuest)) vipGuestsList.Remove(arrivedGuest);
    if (regularGuestsList.Contains(arrivedGuest)) regularGuestsList.Remove(arrivedGuest);
}

bool hasGuests = vipGuestsList.Any() || regularGuestsList.Any();

if (hasGuests)
{
    Console.WriteLine(vipGuestsList.Count + regularGuestsList.Count);

    foreach (string vipGuest in vipGuestsList)
    {
        Console.WriteLine(vipGuest);
    }

    foreach (string regularGuest in regularGuestsList)
    {
        Console.WriteLine(regularGuest);
    }
}