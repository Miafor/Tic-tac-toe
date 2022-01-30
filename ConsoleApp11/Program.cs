using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] game = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                 
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", game[0], game[1], game[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", game[3], game[4], game[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", game[6], game[7], game[8]);
            Console.WriteLine("_____|_____|_____");

            char nr;
            int counter = 0;
            char [] board = new char[9];
            Person person1 = new Person('X');
            Person person2 = new Person('O');
            //char[] numbers = new char[counter];

            bool won = false;
            while (won== false)
            {
                Console.WriteLine("Enter a number:");
                nr = Console.ReadLine()[0];
                //numbers[nr] = numbers[counter];
                //foreach (char num in numbers)
                //{ if (num.Equals('O') || num.Equals('X'))
                //        Console.WriteLine("Select a number that hasn't been played"); 
                //}
                Console.Clear();
                if (counter % 2 == 0)
                {
                    game= person1.Move(game, nr, 'X');
                    game = Board(game, 'X');
                    won= person1.PlayerWin(game,'X');
                    if (won == true)
                    {
                        Console.WriteLine("Player 1 WINS!!!!!!");
                    }
                }
                else 
                {
                    game = person2.Move(game, nr, 'O');
                    game = Board(game, 'O');
                    won = person2.PlayerWin(game, 'O');
                    if (won == true)
                    {
                        Console.WriteLine("Player 2 WINS!!!!!!");
                    }

                }


                counter++;
            }
            Console.ReadLine();
            
           

        }
        static char[] Board(char[] values, char Id)
        {

           
            for (int i = 0; i < values.Length; i++)
            {
                if (Id == values[i])
                {
                    values[i] = Id;
                }
            }

            Console.WriteLine("  {0}  |  {1}  |  {2}  ", values[0], values[1], values[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", values[3], values[4], values[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", values[6], values[7], values[8]);
            Console.WriteLine("_____|_____|_____");
            return values;
        }
    }
        
    
}
