using System;

namespace Challenge9TTT
{
    class Program
    {
        static void Main(string[] args)
        {
            Board mainBoard = new Board();
            string notValidField = "This is not a valid field value!";
            int integerField;
            bool isValidField;
            string field;

            while (true)
            {
                mainBoard.Print();
                isValidField = false;

                do
                {
                    Console.WriteLine("Player {0}: Choose your field!", mainBoard.CurrentPlayer);

                    //ask the user for a field position:

                    field = Console.ReadLine();

                    if (!int.TryParse(field, out integerField))
                        Console.WriteLine(notValidField);
                    else if (integerField > 9 && integerField < 1)
                        Console.WriteLine(notValidField);
                    else if(!mainBoard.Move(integerField))
                        isValidField = false;
                    else isValidField = true;

                }
                while (!isValidField);

                if(mainBoard.Winner != 0 || mainBoard.MovesCounter > 8)
                {
                    Console.WriteLine("Press any key to reset the game.");
                    Console.ReadKey();
                    mainBoard.Reset();
                }
            }
        }
    }
}
