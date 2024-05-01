var allUniversity = new List<University.Test.University>()
{
    new University.Test.University()
    {
        Faculty = "FSHN"
    },
    new University.Test.University()
    {
        Faculty = "UPT"
    }
};


foreach (var university in allUniversity)
{
    Console.WriteLine(university.Faculty);
}

Console.ReadLine();