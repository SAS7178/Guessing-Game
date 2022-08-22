using System;

// The program should...

// Display a message to the user asking them to guess the secret number.
// Display a prompt for the user's guess.
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.

//prompt needs to prrint to screen(WriteLine)
    Console.WriteLine("Guess the secret number");

//user needs to respond(Input/REadLine--reades input)
//save user response aas variable()
    string answer = Console.ReadLine();
    int ParsedAnswer = int.Parse(answer);

//show users guess back to them (writeLine--your guess is..)
Console.WriteLine($"Your guess is {ParsedAnswer}");

