namespace csharp_day_1
{
    class Game
    {
        public Game()
        {
           Console.WriteLine("Type your choice! (Rock, Paper or Scissors)"); 
           string playerChoice = Console.ReadLine();
           Round(playerChoice);
           }
           public void Round(string playerChoice)
           {
               if( playerChoice.ToLower() == "rock"){
                   if(Computer() == 1 )
                   {
                       Console.WriteLine("Computer chose rock! It's a TIE!");
                   }
                   else if(Computer() == 2 )
                   {
                       Console.WriteLine("Computer chose paper! You Lost... :(");
                   }
                   else if(Computer() == 3 )
                   {
                       Console.WriteLine("Computer chose scissors! You Won! :) ");
                   }
               }
               else if ( playerChoice.ToLower() == "paper"){
                   if(Computer() == 1 )
                   {
                       Console.WriteLine("Computer chose rock! You Won! :)");
                   }
                   else if(Computer() == 2 )
                   {
                       Console.WriteLine("Computer chose paper! It's a TIE!");
                   }
                   else if(Computer() == 3 )
                   {
                       Console.WriteLine("Computer chose scissor! You Lost... :(");
                   }
               }
               else if( playerChoice.ToLower() == "scissors"){
                    if(Computer() == 1 )
                    {
                    Console.WriteLine("Computer chose Rock! You Lost... :(");
                    }
                     else if(Computer() == 2 )
                    {
                      Console.WriteLine("Computer chose Paper! You Won! :) ");
                    }
                     else if(Computer() == 3 )
                    {
                      Console.WriteLine("Computer chose Scissors! It's a TIE!");
                    }
                  }
           }
           private int Computer()
           {
             var Random = new Random();
             int computer = Random.Next(1,3);
             return computer;
           }

        
       
    
    }
}