// Using directive to include the System namespace, granting access to types in the System library, such as Console for input and output operations.
using System;

// Definition of the Program class.
class Program
{
    // Declaration of a static 2D array of chars to represent the game board. Static means it belongs to the class itself, rather than instances of the class.
    static char[,] board = new char[3, 3];

    // The Main method, the entry point of the application. args contains any command-line arguments.
    static void Main(string[] args)
    {
        // Call to a method that initializes the game board with spaces, indicating empty spots.
        InitializeBoard();
        // Declaration and initialization of a boolean variable to track if the game has ended.
        bool isGameOver = false;
        // Declaration and initialization of a char variable to track the current player, starting with 'X'.
        char currentPlayer = 'X';

        // Game loop that continues until isGameOver is true.
        while (!isGameOver)
        {
            // Clears the console window to keep the board visible without clutter.
            Console.Clear();
            // Calls a method to print the current state of the board.
            PrintBoard();
            // Prompts the current player to make a move by entering a row and column number.
            Console.WriteLine($"Player {currentPlayer}, make your move (row and column): ");
            // Reads the player's input, converts it to an integer, and assigns it to row and column variables.
            int row = Convert.ToInt32(Console.ReadLine());
            int column = Convert.ToInt32(Console.ReadLine());

            // Checks if the selected board position is empty (' ').
            if (board[row, column] == ' ')
            {
                // If so, the board position is updated with the current player's symbol ('X' or 'O').
                board[row, column] = currentPlayer;
                // Switches the current player.
                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            }
            else
            {
                // If the position is not empty, informs the player and waits for any key to continue.
                Console.WriteLine("This cell is already occupied. Try again.");
                Console.ReadKey();
            }

            // Future enhancement: Insert method calls here for checking win conditions and if the board is full.
        }

        // Future enhancement: Add methods to check the game status (win/draw) and to print the final game state.
    }

    // Method to initialize the game board with spaces, indicating they are empty.
    static void InitializeBoard()
    {
        // Nested for loops to iterate through each row and column of the board.
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                // Sets each position on the board to a space (' ').
                board[row, col] = ' ';
            }
        }
    }

    // Method to print the current state of the game board to the console.
    static void PrintBoard()
    {
        // Prints column headers for clarity.
        Console.WriteLine(" 0 1 2");
        // Loop through each row of the board.
        for (int row = 0; row < 3; row++)
        {
            // Print the row number at the start of the row.
            Console.Write(row + " ");
            // Loop through each column in the current row.
            for (int col = 0; col < 3; col++)
            {
                // Print the value at the current board position.
                Console.Write(board[row, col]);
                // If not at the last column, print a separator.
                if (col < 2) Console.Write("|");
            }
            // Move to a new line after printing the row.
            Console.WriteLine();
            // If not at the last row, print a row separator.
            if (row < 2) Console.WriteLine("  -----");
        }
    }
}
