using System;
using System.Collections.Generic;


// Phase 1
// The program should...
// Display a message to the user asking them to guess the secret number.
// Display a prompt for the user's guess.
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.
//funct to ask user to guess num check input num guessed to be secretmun and amount of times guessed is less than 3 

// Console.WriteLine("Guess the secret number...");
// string guess = Console.ReadLine();
// int userNumber = int.Parse(guess);
// Console.WriteLine("You guessed" + " " + userNumber);
//////////////////////////////////////////////////////////////////////////////////////

// Phase 2
// The program should be updated to...

// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
// No longer display the user's guess. They know what they guessed, right?
// Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.

// Console.WriteLine("Guess the secret number...");
// string guess = Console.ReadLine();
// int userNumber = int.Parse(guess);
// if(secretNumber == userNumber) 
// {
// Console.WriteLine("You guessed correctly");
// } else Console.WriteLine("You guessed incorrectly");
//////////////////////////////////////////////////////////////////////////////////////

// Phase 3
// The program should be updated to...

// Give the user four chances to guess the number.
// Continue to display the success or failure messages as in phase 2

// for(int guesses = 1; guesses < 5; guesses++ )
// {
// Console.WriteLine("Guess the secret number...");
// string guess = Console.ReadLine();
// int userNumber = int.Parse(guess);
// if(secretNumber == userNumber && guesses < 5) 
// {
// Console.WriteLine("You guessed correctly");
// } else Console.WriteLine("You guessed incorrectly");
// }
//////////////////////////////////////////////////////////////////////////////////////

// Phase 4
// The program should be updated to...

// Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
// End the loop early if the user guesses the correct number.

// for(int guesses = 1; guesses < 5; guesses++ )
// {
// Console.WriteLine("Guess the secret number...");
// string guess = Console.ReadLine();
// int userNumber = int.Parse(guess);

// if(secretNumber == userNumber && guesses < 5) 
// {
//  Console.WriteLine($"Your guess of {userNumber} was correct");
//   break;
// } else Console.WriteLine($"Your guess of {userNumber} was incorrect");
// }

//////////////////////////////////////////////////////////////////////////////////////

// Phase 5
// The program should be updated to...

// Use a random number to set the secret number between 1 and 100 instead of a hard-coded number.
// The prompt should display the number of guesses the user has left.

// for(int guesses = 3; guesses > -1; guesses-- )
// {
// Console.WriteLine("Guess the secret number...");
// string guess = Console.ReadLine();
// int userNumber = int.Parse(guess);

// if(secretNumber == userNumber && guesses > 0) 
// {
//  Console.WriteLine($"Your guess of {userNumber} was correct");
//   break;
// } else Console.WriteLine($"Your guess of {userNumber} was incorrect you have {guesses} remaining.");
// }

//////////////////////////////////////////////////////////////////////////////////////

// Phase 6
// The program should be updated to...

// Inform the user if their guess was too high or too low, when they guess incorrectly.

// for (int guesses = 3; guesses > -1; guesses--)
// {
//     Console.WriteLine("Guess the secret number...");
//     string guess = Console.ReadLine();
//     int userNumber = int.Parse(guess);

//     if (secretNumber == userNumber && guesses > 0)
//     {
//         Console.WriteLine($"Your guess of {userNumber} was correct.. WELL DONE!!");
//         break;
//     }
//     else if(userNumber > secretNumber)
//     {
//         Console.WriteLine($"Your guess of {userNumber} was too high!, you have {guesses} remaining.");
//     }
//     else if(userNumber < secretNumber)
//     {
//         Console.WriteLine($"Your guess of {userNumber} was too low!, you have {guesses} remaining.");
//     }
// }

//////////////////////////////////////////////////////////////////////////////////////

// Phase 7
// The program should be updated to...

// Prompt the user for a difficulty level before they are prompted to guess the number.
// The difficulty level should determine how many guesses the user gets. The difficulty levels should be:
// Easy - this gives the user eight guesses.
// Medium - this gives the user six guesses.
// Hard - this gives the user four guesses.

// Random random = new Random();
// int secretNumber = random.Next(1, 100);
// Console.WriteLine($"secret number is {secretNumber}");

//    Console.WriteLine("Welcome to the guessing game!!!");
//    Console.WriteLine("Choose a Difficulty level of easy(e),medium(m) or hard(h)...");
//     string userDifficulty = Console.ReadLine();

//   if(userDifficulty == "e") {
//     runTest(7,-1);
//   }
//   if(userDifficulty == "m") {
//     runTest(5,-1);
//   }
//   if(userDifficulty == "h") {
//     runTest(3,-1);
//   }

//  void runTest(int a,int b)
// {
// for (int guesses = a; guesses > b; guesses--)
// { 
//     Console.WriteLine("Guess the secret number...");
//     string guess = Console.ReadLine();
//     int userNumber = int.Parse(guess);

//     if (secretNumber == userNumber && guesses > b - 1)
//     {
//         Console.WriteLine($"Your guess of {userNumber} was correct.. WELL DONE!!");
//         break;
//     }
//     else if(userNumber > secretNumber)
//     {
//         Console.WriteLine($"Your guess of {userNumber} was too high!, you have {guesses} remaining.");
//     }
//     else if(userNumber < secretNumber)
//     {
//         Console.WriteLine($"Your guess of {userNumber} was too low!, you have {guesses} remaining.");
//     }}

// } 

//////////////////////////////////////////////////////////////////////////////////////

// Phase 8
// The program should be updated to...

// Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct.

Random random = new Random();
int secretNumber = random.Next(1, 100);
Console.WriteLine($"secret number is {secretNumber}");

Console.WriteLine("Welcome to the guessing game!!!");
Console.WriteLine("Choose a Difficulty level of easy(e),medium(m) or hard(h) to try until you succeed choose cheater(c)...");
string userDifficulty = Console.ReadLine();

if (userDifficulty == "e")
{
    runTest(7, -1);
}
if (userDifficulty == "m")
{
    runTest(5, -1);
}
if (userDifficulty == "h")
{
    runTest(3, -1);
}
if (userDifficulty == "c")
{
    CheaterTest();
}

void runTest(int a, int b)
{
    for (int guesses = a; guesses > b; guesses--)
    {
        Console.WriteLine("Guess the secret number...");   
        string guess = Console.ReadLine();
        int userNumber = int.Parse(guess);

        if (secretNumber == userNumber && guesses > b - 1)
        {
            Console.WriteLine($"Your guess of {userNumber} was correct.. WELL DONE!!");
            break;
        }
        else if (userNumber > secretNumber)
        {
            Console.WriteLine($"Your guess of {userNumber} was too high!, you have {guesses} remaining.");
        }
        else if (userNumber < secretNumber)
        {
            Console.WriteLine($"Your guess of {userNumber} was too low!, you have {guesses} remaining.");
        }
    }

}
//function to call cheater test with while loop

//recursive cheater function
void CheaterTest()
{
    {
        Console.WriteLine("Guess the secret number...");
        string guess = Console.ReadLine();
        int userNum = int.Parse(guess);

        if (secretNumber == userNum)
        {
           Console.WriteLine($"Your guess of {userNum} was correct.. WELL DONE!!");
           return;
        } 
        else if (userNum > secretNumber)
        {
            Console.WriteLine($"Your guess of {userNum} was too high!");
        }
        else if (userNum < secretNumber)
        {
            Console.WriteLine($"Your guess of {userNum} was too low!");
        }
        CheaterTest();
    }
}


