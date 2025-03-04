/*Benji Stansfield, 02-27-25, Lab 6 "Typing Trainer"*/

using System.Diagnostics;
Console.Clear();
Stopwatch stopwatch = new Stopwatch();

/*Greeting screen*/
Console.WriteLine(@"----------------
 TYPING TRAINER
----------------
");

Console.WriteLine("Type the text that appears on the screen as quickly and as accurately as possible.");
Console.WriteLine("Press any key to start (timer will start)");
Console.ReadKey(true);
Console.Clear();

/*Challenge text*/
string[] challengeText = new string[5];
challengeText[0] = "Let me tell you something you already know: the world ain't all sunshine and rainbows. It's a very mean and nasty place, and I don't care how tough you are it will beat you to your knees and keep you there permanantly if you let it. You, me, or nobody is gonna hit as hard as life. But it ain't about how hard you hit. It's about how hard you can get hit and keep moving forward. How much you can take and keep moving forward. That's how winning is done! If you know what you're worth, go and get what you're worth. But you gotta be willing to take the hits, and not pointing fingers saying you ain't where you wanna be because of him or her or anybody! Cowards do that, and that ain't you! You're better than that!";
challengeText[1] = "Four score and seven years ago our fathers brought forth on this continent a new nation, conceived in liberty, and dedicated to the proposition that all men are created equal. Now we are engaged in a great civil war, testing whether that nation, or any nation so conceived and so dedicated, can long endure. We are met on a great battlefield of that war. We have come to dedicate a portion of that field as a final resting place for those who here gave their lives that that nation might live. It is altogether fitting and proper that we should do this.";
challengeText[2] = "Don't look at me like that! You aren't the only one who's trapped. They expect me to cook it again! I mean, I'm not ambitious. I wasn't trying to cook. I was just trying to stay out of trouble. You're the one who was getting fancy with the spices! What did you throw in there? Oregano? No? Rosemary? That's a spice, isn't it? You didn't throw rosemary in there? Then what was all the flipping and all the throwing the... I need this job. I've lost so many. I don't know how to cook, and now I'm actually talking to a rat as if you... Did you nod? Have you been nodding? You understand me? So I'm not crazy!";
challengeText[3] = "Did you ever hear the tragedy of Darth Plagueis the Wise? I thought not. It's not a story the Jedi would tell you. It's a Sith legend. Darth Plagueis was a Dark Lord of the Sith so powerful and so wise, he could use the Force to influence the midi-chlorians to create life. He had such a knowledge of the dark side, he could even keep the ones he cared about from dying. He became so powerful, the only thing he was afraid of was losing his power. Which eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew. Then his apprentice killed him in his sleep. It's ironic. He could save others from death, but not himself.";
challengeText[4] = "Been a while since I was in front of you. I figure I'll stick to the cards this time. There's been speculation that I was involved in the events that occurred on the freeway and the rooftop. I know that it's confusing. It is one thing to question the official story and another thing entirely to make wild accusations or insinuate that I'm a superhero because that would be outlandish and fantastic. I'm just not the hero type, clearly, with this laundry list of character defects, all the mistakes I've made, largely public... The truth is: I am Iron Man.";

/*Reposition cursor*/
Random rand = new Random();
int textNumber = rand.Next(0,5);
string usedChallengeText = challengeText[textNumber];
Console.WriteLine(usedChallengeText);
Console.SetCursorPosition(0,0);

/*Read each input*/
int errors = 0;
int correctInputs = 0;

stopwatch.Start();
for (int i = 0; i < usedChallengeText.Length; i++)
{
    char expectedChar = usedChallengeText[i]; //expected character is where the cursor is
    char userChar = Console.ReadKey(true).KeyChar;

    if (userChar == expectedChar)
    {
        Console.ForegroundColor = ConsoleColor.Green; //changes text to green if the user types what is expected
        correctInputs++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        errors++; //changes text to red if the user types an error and increases the error count
    }

    Console.Write(expectedChar);
    Console.ForegroundColor = ConsoleColor.White;
}
stopwatch.Stop();
double elapsedSeconds = stopwatch.ElapsedMilliseconds/1000.0; //calculates the amount of seconds it took to type
double accuracy = (double)correctInputs / usedChallengeText.Length * 100; //calculates the accuracy of users typing

/*Words per minute*/
string[] words = usedChallengeText.Split(" ");
double wpm = (words.Length - errors) / (elapsedSeconds / 60);

/*Display number of errors*/
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"You completed the text with {errors} errors for an accuacy of {accuracy:00}%.");
Console.WriteLine($"Your time: {elapsedSeconds} seconds ({wpm:00} words per minute).");