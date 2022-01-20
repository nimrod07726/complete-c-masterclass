using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge9TTT
{
    class Board
    {
        private string[] fields = new string[9];
        private string invalidSlot = "This is an invalid move!";
        private string alreadyAWinner = "Player {0} is already a winner!";
        private string playerHasWon = "Player {0} is the winner!";
        private string drawCaption = "It is a draw!";
        private int currentPlayer;
        private int winner;
        private int movesCounter;

        public int MovesCounter {
            get 
            {
                return movesCounter;   
            } 
        }

        public int CurrentPlayer {
            get
            {
                return currentPlayer;
            }
        }

        public int Winner {
            get
            {
                return winner;
            }
        }

        public Board()
        {
            Reset();
        }

        public void Reset()
        {
            string[] resetBoard = {"1","2","3","4","5","6","7","8","9"};
            fields = resetBoard;
            currentPlayer = 1;
            winner = 0;
            movesCounter = 0;
        }

        public bool Move(int position)
        {
            if (!AttemptMove(position)) return false;
            else
            {
                winner = CheckWinner();

                if(winner != 0)
                {
                    Print();
                    Console.WriteLine(playerHasWon, winner);
                }

                movesCounter++;

                if (movesCounter > 8)
                {
                    Print();
                    Console.WriteLine(drawCaption);
                }


                return true;
            }
        }

        private int WinnerByScore(int player1Hits, int player2Hits)
        {
            int winner = player1Hits == 3 ? 1 : player2Hits == 3 ? 2 : 0;
            return winner;
        }

        private int CheckWinner()
        {
            int i, j;
            int player1Hits = 0;
            int player2Hits = 0;

            // first diagonal
            for (i = 0; i < Math.Sqrt(fields.Length); i++)
            {
                switch(fields[4*i])
                {
                    case "O":
                        player1Hits++;
                        break;
                    case "X":
                        player2Hits++;
                        break;
                    default:
                        break;
                }
            }

            winner = WinnerByScore(player1Hits, player2Hits);
            if ( winner != 0) return winner;
            player1Hits = 0;
            player2Hits = 0;

            // second diagonal
            for (i = 2; i < fields.Length-1; i+=2)
            {
                
                switch (fields[i])
                {
                    case "O":
                        player1Hits++;
                        break;
                    case "X":
                        player2Hits++;
                        break;
                    default:
                        break;
                }
            }
            
            winner = WinnerByScore(player1Hits, player2Hits);
            if (winner != 0) return winner;
            player1Hits = 0;
            player2Hits = 0;

            //columns search

            for (i = 0; i < Math.Sqrt(fields.Length); i++)
            {
                for (j = 0; j < Math.Sqrt(fields.Length); j++)
                {
                    switch (fields[3*j + i])
                    {
                        case "O":
                            player1Hits++;
                            break;
                        case "X":
                            player2Hits++;
                            break;
                        default:
                            break;
                    }
                }

                winner = WinnerByScore(player1Hits, player2Hits);
                if (winner != 0) return winner;
                player1Hits = 0;
                player2Hits = 0;
            }

            // rows search

            for (i = 0; i < Math.Sqrt(fields.Length); i++)
            {
                for (j = 0; j < Math.Sqrt(fields.Length); j++)
                {
                    switch (fields[j + 3*i])
                    {
                        case "O":
                            player1Hits++;
                            break;
                        case "X":
                            player2Hits++;
                            break;
                        default:
                            break;
                    }
                }

                winner = WinnerByScore(player1Hits, player2Hits);
                if (winner != 0) return winner;
                player1Hits = 0;
                player2Hits = 0;
            }

            return winner;
        }

        private bool AttemptMove(int position)
        {
            position--;
            if(winner != 0)
            {
                Console.WriteLine(alreadyAWinner, winner);
                return false;
            }

            if(fields[position] == "X" || fields[position] == "O" || 
                (position < 0 || position > 8) )
            {
                Console.WriteLine(invalidSlot);
                return false;
            }

            switch (currentPlayer)
            {
                case 1:
                    fields[position] = "O";
                    currentPlayer = 2;
                    return true;
                case 2:
                    fields[position] = "X";
                    currentPlayer = 1;
                    return true;
                default:
                    return false;
            }
        }

        public void Print()
        {
            Console.Clear();
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", fields[0], fields[1], fields[2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", fields[3], fields[4], fields[5]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", fields[6], fields[7], fields[8]);
            Console.WriteLine("   |   |   \n");
        }
    }






}
