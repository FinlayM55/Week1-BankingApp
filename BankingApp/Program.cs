/*
 * Class name: Banking App
 * Version 1
 * Author: Finlay Morgan
 */

void BuildBankingApp()
{

    // initialise variable
    int choice;
    double depositAmount;
    double accountBalance = 1000.00;

    // display the main menu screen
    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1 - Deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please chooose an option (1-2)");


    // read users menu choice
    // convert the string to an integer
    // using explicit typecasting

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1 ||  choice == 2)
    {
        // valid menu choice
        if (choice == 1)
        {
            // deposit or withdraw funds
            Console.WriteLine("You have chosen to deposit or withdraw funds");
            Console.WriteLine("How much do you want to deposit?");
            Console.WriteLine("Enter amount including pence using a decimal point");

            depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your original account balance was {accountBalance}");

            accountBalance += depositAmount;
            Console.WriteLine($"Your new account balance is {accountBalance}");

        }
        if (choice == 2)
        {
            // view current account information
            Console.WriteLine("You have chosen to view current account information");
            Console.WriteLine($"Your current account balance is {accountBalance}");
        }
        else
        {
            // view current account information
            accountBalance = 1000.00;
            Console.WriteLine("You have chosen to view current account information");
        }
    }
    else
    {

       // invalid menu choice
       Console.WriteLine("Invalid choice, please choose 1 or 2");

    }
}

BuildBankingApp();