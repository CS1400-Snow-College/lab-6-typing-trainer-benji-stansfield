/*Benji Stansfield, 02-27-25, Lab 6 "Typing Trainer"*/
Console.Clear();

/*Greeting screen*/
Console.WriteLine(@"----------------
 TYPING TRAINER
----------------
");

Console.WriteLine("Type the text that appears on the screen as quickly and as accurately as possible.");
Console.WriteLine("Press any key to start");
Console.ReadKey(true);
Console.Clear();

/*Challenge text*/
string challengeText = "Let me tell you something you already know: the world ain't all sunshine and rainbows. It's a very mean and nasty place, and I don't care how tough you are it will beat you to your knees and keep you there permanantly if you let it. You, me, or nobody is gonna hit as hard as life. But it ain't about how hard you hit. It's about how hard you can get hit and keep moving forward. How much you can take and keep moving forward. That's how winning is done! If you know what you're worth, go and get what you're worth. But you gotta be willing to take the hits, and not pointing fingers saying you ain't where you wanna be because of him or her or anybody! Cowards do that, and that ain't you! You're better than that!";

/*Reposition cursor*/
Console.WriteLine(challengeText);
Console.SetCursorPosition(0,0);

/*Read each input*/
int errors = 0;

for (int i = 0; i < challengeText.Length; i++)
{
    char expectedChar = challengeText[i]; //expected character is where the cursor is
    char userChar = Console.ReadKey(true).KeyChar;

    if (userChar == expectedChar)
    {
        Console.ForegroundColor = ConsoleColor.Green; //changes text to green if the user types what is expected
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        errors++; //changes text to red if the user types an error and increases the error count
    }

    Console.Write(expectedChar);
    Console.ForegroundColor = ConsoleColor.White;
}
