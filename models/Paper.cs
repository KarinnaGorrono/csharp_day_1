


namespace csharp_day_1
{
  public class Paper : Choice
  {
    public Paper()
    {
      Win = "rock";
      Lose = "scissors";
      Tie = "paper";
      Name = "paper";

    }

    public string Win { get; private set; }
    public string Lose { get; private set; }
    public string Tie { get; private set; }
  }
}