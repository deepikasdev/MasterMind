using System;

class MasterMind
{
    static void Main()
    {
        //Declaring Variables
        int ans = 0;
        string pass = "";
        int userCount = 0;

        //Generating the Random Password
        Random random = new Random();
        for (int i = 0; i < 4; i++)
        {
            pass += random.Next(1, 6);
        }
        Console.Write("Random Password: {0}", pass);

        while (true)
        {
            ans = 0;
            string userChoice = "";
            int wronginputs = 1;
            while (userChoice.Length != 4)
            {
                Console.WriteLine("\nGuess the 4 digit number? ");
               
                userChoice = Console.ReadLine();
                if (userChoice.Length != 4)
                
                {
                    Console.WriteLine("Invalid combination. Please try again ");
                    if(wronginputs >= 10)
                    {
                        Console.WriteLine("invalid attempts exceeded by 10");
                        return;
                    }
                    wronginputs++;
                }

            }
            userCount++;
            for (int i = 0; i < 4; i++)
            {
                if (userChoice[i] == pass[i])
                {
                    ans++;
                    Console.Write("+");
                    if (ans == 4)
                    {
                        Console.WriteLine("\n You Won");
                    }
                }
                else
                {
                    if (pass.Contains(Char.ToString(userChoice[i])))
                        Console.Write("-");
                    else
                        Console.Write("X");


                }
            }
            Console.WriteLine("");
            if (userCount == 10 || ans == 4)
                break;
            
        }
        if (userCount == 10 && ans != 4)
            Console.WriteLine("limit exceeded, Total attempts: {0}", userCount);

        Console.WriteLine("The correct 4 digit guess was " + pass);
    }
}
