string[] studentNames = new string[] { "Brittany", "Tina", "Brianna", "Kayden", "Kayleb", "Layla", "Taishawn" };
string[] homeTown = new string[] { "Detroit", "Romulus", "Grand Rapids", "Livonia", "Garden City", "Westland", "Wayne" };
string[] favoriteFoods = new string[] { "pizza", "nachos", "chicken tenders", "tacos", "alfredo", "fries", "mac n cheese" };

bool repeat;

do
{
    Console.WriteLine("Please enter the number of the student you would like information about. " +
        "\nIf you would like to see a list of students please press 9.");
    int studentNumber = Convert.ToInt32(Console.ReadLine());

    if (studentNumber < 1 || studentNumber > studentNames.Length)
    {
        if (studentNumber == 9)
        {
            Console.WriteLine($"Here are our students:");
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {studentNames[i]}");
            }
            Console.WriteLine("Please enter the number of the student you would like information about:");
            studentNumber = Convert.ToInt32(Console.ReadLine());
        }

        while (studentNumber < 1 || studentNumber > studentNames.Length)
        {
            Console.WriteLine($"That is not a valid number. Please enter a number between 1 and {studentNames.Length}.");
            studentNumber = Convert.ToInt32(Console.ReadLine());
        }
    }

    Console.WriteLine($"Students Name: {studentNames[studentNumber - 1]}");

    bool invalidResponse;
    do
    {
        Console.WriteLine("Would you like to display the students hometown or favorite food?");
        string answer = Console.ReadLine().ToLower();
        if (answer == "hometown" || answer.Contains("home") || answer.Contains("town"))
        {
            Console.WriteLine($"{studentNames[studentNumber - 1]}'s hometown is {homeTown[studentNumber - 1]}.");
            invalidResponse = false;
        }
        else if (answer == "favorite food" || answer.Contains("food") || answer.Contains("favorite"))
        {
            Console.WriteLine($"{studentNames[studentNumber - 1]}'s favorite food is {favoriteFoods[studentNumber - 1]}.");
            invalidResponse = false;
        }
        else
        {
            Console.WriteLine("That is not a valid response. Let's try again.");
            invalidResponse = true;
        }
    }
    while (invalidResponse);

    Console.WriteLine("Would you like to learn about another student? (y/n)");
    string userAnswer = Console.ReadLine().ToLower();

    if (userAnswer == "y" || userAnswer == "yes")
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