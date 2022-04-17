bool continueLoop = true; // the loop will continue until successful parse
// Start of loop to see if the user wants to continue the program. 
while (continueLoop)
{

    Console.WriteLine(" Enter a number between 1 and 100: ");
int parsedUserInput = 0; // initialized user input to 0 because it is being used after the while and need to be used later. 
 
while (continueLoop) // This is the loop to verify the user inputed the value I asked for. the integer between 1 and 100.
{

    string userInput = Console.ReadLine();
   
    bool result = int.TryParse(userInput, out parsedUserInput); // trying to parse a string into an int and if it fails the result will be false if successful is true. Out is the keyword for a successful parse and variable attached to it.
    // used tryParse so not to get an error if the parse failed.  example if the user puts non integers it would break allowing the program to continue.
    // failedParse = int.Parse(userInput); // This will break if the parse fails

    //Console.WriteLine($"The type of the userInput var is {userInput.GetType()}"); used to check the initial user input type
    //Console.WriteLine($"The type of the parsedUserInput var is {parsedUserInput.GetType()}"); used to check to see if the input was converted properly

    if (result == false) // result is the var assigned on line 9 that means was the parse successful. 
    {
        Console.WriteLine(" Please enter a valid number between 1 and 100: "); 
    }
    else if (result == true && parsedUserInput <= 100 && parsedUserInput >= 1) //  this checks the bounds. else if to check if the input was parsed successfully and the integer was greater or equal to 1 and less than or equal to 100
    {
        continueLoop = false; // this breaks the loop.
    }
}  // this is where the loop ends. 

//  If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60".
//  input % 2 == 0 is an even number and input % 2 != 0 is odd.  ! means not.
if (parsedUserInput % 2 != 0 && parsedUserInput < 60)
{
    Console.WriteLine($"{parsedUserInput} is Odd and less than 60 ");
}
// If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25.”
else if (parsedUserInput % 2 == 0 && parsedUserInput < 25 && parsedUserInput > 1)
{
    Console.WriteLine($"{parsedUserInput} is even and greater than 1 and less than 25");
}
//If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive.”
else if (parsedUserInput % 2 == 0 && parsedUserInput > 25 && parsedUserInput < 61)
{
    Console.WriteLine($"{parsedUserInput} is Even and between 26 and 60 inclusive.");  
}
    //  If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.”
    else if (parsedUserInput % 2 == 0 && parsedUserInput > 60)
{
    Console.WriteLine($"{parsedUserInput} is even and greater than 60");
}
//  //If the integer entered is odd and greater than 60, print the number entered and “Odd and greater than 60.”
else if (parsedUserInput % 2 != 0 && parsedUserInput > 60)
{
    Console.WriteLine($"{parsedUserInput} Odd and greater than 60");
}
Console.WriteLine("Would you like to enter another number? y/n: ");
    string wouldYouLikeToContinue = Console.ReadLine();
    if(wouldYouLikeToContinue .Equals("y", StringComparison.InvariantCultureIgnoreCase) || wouldYouLikeToContinue.Equals("yes", StringComparison.InvariantCultureIgnoreCase)) 
        // StringComparison.InvariantCultureIgnoreCase means ignore the difference between upperCase and lowerCase letters and the culture is for the type of language used.
    {
        continueLoop = true;
    }
    else
    {
        continueLoop = false;
    }
}