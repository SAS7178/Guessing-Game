using System;

// The program should...

// Display a message to the user asking them to guess the secret number.
// Display a prompt for the user's guess.
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.

// //prompt needs to prrint to screen(WriteLine)
//     Console.WriteLine("Guess the secret number");

// //user needs to respond(Input/REadLine--reades input)
// //save user response aas variable()
//     string answer = Console.ReadLine();
//     int ParsedAnswer = int.Parse(answer);

// //show users guess back to them (writeLine--your guess is..)
// Console.WriteLine($"Your guess is {ParsedAnswer}");

// Phase 2
// The program should be updated to...

// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
// No longer display the user's guess. They know what they guessed, right?
// Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.

// int SecretNumber = 40;
//  CompareToNumber();
// void CompareToNumber()
// {
//     Console.WriteLine("Guess the secret Number: ");
//     string answer = Console.ReadLine();
//     int ParsedAnswer = int.Parse(answer);

//         while (String.IsNullOrWhiteSpace(answer))

//         {
//             Console.WriteLine("Guess the secret number: ");
//             answer = Console.ReadLine();
//             ParsedAnswer = int.Parse(answer);
//         }
//     if (ParsedAnswer == SecretNumber)
//      {
//         Console.WriteLine("Your guess is correct");
//     }
// }

// Phase 3
// The program should be updated to...

// Give the user four chances to guess the number.


// Continue to display the success or failure messages as in phase 2


///while loop that will check if the count and / or the person has guuessed correctly

//conditions/(person correct or 4 times tried)

//create var set to 0 and each time loop run add ++ to the var

// bool var isAnswercorrect  set equal to false to see if parsed answer is true if soo change bool var to true

int SecretNumber = 40;
bool isAnswerCorrect = false;
int timesGuessed = 0;
 CompareToNumber();

void CompareToNumber()
{
    Console.WriteLine("Guess the secret Number: ");
    string answer = Console.ReadLine();
    int ParsedAnswer = int.Parse(answer);
    GuessEqualToSecretNumber( ParsedAnswer);

        // while (String.IsNullOrWhiteSpace(answer))
        // {
        //     Console.WriteLine("Guess the secret number: ");
        //     answer = Console.ReadLine();
        //     ParsedAnswer = int.Parse(answer);
        // }
        while (isAnswerCorrect == false && timesGuessed < 3)
        {
            Console.WriteLine("Guess the secret number: ");
            answer = Console.ReadLine();
            ParsedAnswer = int.Parse(answer);
            GuessEqualToSecretNumber( ParsedAnswer);
        }
    }  

void GuessEqualToSecretNumber(int ParsedAnswer)
{
             timesGuessed += 1;

    if (ParsedAnswer == SecretNumber)
     {
        Console.WriteLine("Your guess is correct");
        isAnswerCorrect = true;
    } else {
        Console.WriteLine($"You guessed {timesGuessed} of 4 tries");
    }
}

