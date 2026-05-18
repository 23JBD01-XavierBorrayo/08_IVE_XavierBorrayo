//variables
double saldo = 1000;
int trys = 0;
int correct = 123456;
int pin;

//validar el pin /acceso
while (trys < 3)
{
    Console.Write("Type the PIN: ");
    if (int.TryParse(Console.ReadLine(), out pin))
    {
        if (pin == correct)
        {
            Console.WriteLine("Access Successfully");

            int option = 0;
            while (option != 4)
            {
                Console.WriteLine("=====LOCAL ATM=====");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Go Back -->");
                Console.WriteLine("=====LOCAL ATM=====");
                Console.WriteLine("Type a number: ");

                int.TryParse(Console.ReadLine(), out option);

                switch(option)
                {
                    case 1:
                        Console.WriteLine("Check Balance");
                        Console.WriteLine("Your Balance: $"+saldo);
                        break;
                    case 2:
                        Console.WriteLine("Deposit Money");
                        Console.WriteLine("Enter the amount: ");
                        double deposit;
                        if (double.TryParse(Console.ReadLine(), out deposit))
                        {
                            saldo += deposit;
                            Console.WriteLine("Deposit successfully completed'\nNew Balance: $" + saldo);
                        }
                        else
                        {
                            Console.WriteLine("Not valid, fuckin liar.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Withdraw Money");
                        Console.WriteLine("Enter the amount: ");
                        double retire;
                        if (double.TryParse(Console.ReadLine(), out retire) && retire > 0)
                        {
                            if (retire <= saldo)
                            {
                                saldo -= retire;
                                Console.WriteLine("Withdraw successfully completed'\nNew Balance: $" + saldo);
                            }
                            else
                            {
                                Console.WriteLine("You don't have enought money, fuckin poor");
                            }
                        }
                        else
                        {
                            Console.WriteLine("-> Invalid Datatype <-");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Thanks for support, join discord: https://discord.com/invite/lolesp");
                        break;
                    case 5:
                        Console.WriteLine("Invalid number");
                        break;
                }
                Console.WriteLine(); //salto de linea

            }
            return;
        }
        else
        {
            trys++;
            Console.WriteLine("Incorrect Access, "+trys+" intentos de 3\n");
        }
    }
    else
    {
        Console.WriteLine("Type a valid PIN");


    }
}
