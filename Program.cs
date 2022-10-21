//lerissa lazar
//10-20-22
//madlib
//the computer will ask the user to input 9 nouns, the computer will then take those nouns and turn them into a sentence.

Console.Clear();

string[] input = new String[10];
string[] partsOfSpeech = {"a location", "an animal", "a celebrity", "a celebrity", "an adjective", "an adjective",
                            "a verb", "a verb", "a vehicle", "a restraunt"};

bool run = true;
while (run)
{
    for (int i = 0; i < partsOfSpeech.Count(); i++)
    {
        Console.WriteLine("Please enter " + partsOfSpeech[i]);
        input[i] = Console.ReadLine();
    }

    Console.WriteLine($"I was in the middle of {input[0]} when I caught the smell of a {input[1]} roasting. I looked into the distance, and saw {input[2]} staring at me. {input[3]} called me {input[4]} and {input[5]}, so I started to {input[6]} and {input[7]}. I then saw a {input[8]} and stole it to go to {input[9]}.");

    Console.WriteLine("Would you like to try again? yes or no?");

    string playAgain;
    bool validInput = false;
    while (!validInput)
    {
        playAgain = Console.ReadLine().ToLower();
        if (playAgain == "yes")
        {
            validInput = true;
        }
        else if (playAgain == "no")
        {
            validInput = true;
            run = false;
            Console.WriteLine("Thank you for playing!");
        }
        else
        {
            Console.WriteLine("Invalid repsonse, answer yes or no");
        }
    }
}


