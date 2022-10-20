string[] studentNames = new string[] { "Brittany", "Tina", "Brianna", "Kayden", "Kayleb", "Layla", "Taishawn" };
string[] homeTown = new string[] { "Detroit", "Romulus", "Grand Rapids", "Livonia", "Garden City", "Westland", "Wayne" };
string[] favoriteFoods = new string[] { "pizza", "nachos", "chicken tenders", "tacos", "alfredo", "fries", "mac n cheese" };

bool repeat = false;

do
{
    Console.WriteLine($"Here are our students:");
    for (int i = 0; i < studentNames.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {studentNames[i]}");
    }
    Console.WriteLine("Please enter the number of the student you would like information about:");
    int studentNumber = Convert.ToInt32(Console.ReadLine());

    if (studentNumber < 1 || studentNumber > studentNames.Length)
    {
        do
        {
            Console.WriteLine($"That is not a valid number. Please enter a number between 1 and {studentNames.Length}.");
            studentNumber = Convert.ToInt32(Console.ReadLine());
        }
        while (studentNumber < 1 || studentNumber > studentNames.Length);
    }

    Console.WriteLine($"Students Name: {studentNames[studentNumber - 1]}");

    bool tryAgain = false;
    do
    {
        Console.WriteLine("Would you like to display the students hometown or favorite food?");
        string answer = Console.ReadLine().ToLower();
        if (answer == "hometown")
        {
            Console.WriteLine($"{studentNames[studentNumber - 1]}'s hometown is {homeTown[studentNumber - 1]}.");
            tryAgain = false;
        }
        else if (answer == "favorite food")
        {
            Console.WriteLine($"{studentNames[studentNumber - 1]}'s favorite food is {favoriteFoods[studentNumber - 1]}.");
            tryAgain = false;
        }
        else
        {
            Console.WriteLine("That is not a valid response. Let's try again.");
            tryAgain = true;
        }
    }
    while (tryAgain);

    Console.WriteLine("Would you like to learn about another student? (y/n)");
    string userAnswer = Console.ReadLine().ToLower();

    if (userAnswer == "y")
    {
        repeat = true;
    }
    else
    {
        Console.WriteLine("Goodbye!");
        repeat = false;
    }
} while (repeat);

Console.ReadKey();