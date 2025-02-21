string? userInput;
System.Console.WriteLine("Enter an integer value between 5 and 10");
int numericValue = 0;
bool validNumber = false;

do
{
    userInput = Console.ReadLine();
    if (userInput != null)
    validNumber = int.TryParse(userInput, out numericValue);
    if (validNumber == true)
    {
        if (numericValue <= 5 || numericValue >= 10)
        {
            validNumber = false;
            System.Console.WriteLine($"You entered {userInput}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        System.Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);


System.Console.WriteLine($"Your input value {userInput} has been accepted.");
Console.ReadLine();
