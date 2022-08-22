using System;



    Random r = new Random();
    int SecretNumber = r.Next(1,100);
    Console.WriteLine(SecretNumber);



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

