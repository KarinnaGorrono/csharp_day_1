


namespace csharp_day_1
{
  public class Scissors : Choice
  {
    public Scissors()
    {
      Win = "paper";
      Lose = "rock";
      Tie = "scissors";
      Name = "scissors";

    }

    public string Win { get; private set; }
    public string Lose { get; private set; }
    public string Tie { get; private set; }
  }
}