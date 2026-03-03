using System;

public static class InputValidation
{
    public static bool IsValidMove(int move, Board board)
    {
        // Implement validation logic here
        return true;
    }

    public static int GetUserIntInput()
    {
        int number = 0;
        bool isValid = false;

        while (!isValid)
        {
            string? input = Console.ReadLine();

            if (int.TryParse(input, out number) && number >= 0 && number <= 2)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 2.");
            }
        }
        return number;
    }
}