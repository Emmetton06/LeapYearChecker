LeapYearChecker();

    void LeapYearChecker()
    {
    Console.WriteLine("Please enter a year");
    int year = Convert.ToInt32(Console.ReadLine());
    if (year < 0)
    {
        Console.WriteLine($"{year} is not a valid year. Ir must be a negative number.");
    }
    else
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }
}