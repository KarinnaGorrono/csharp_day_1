
namespace csharp_day_1
{
  public class Rock : Choice
  {
    public Rock()
    {
      Win = "scissors";
      Lose = "paper";
      Tie = "rock";
      Name = "rock";
    }

    public string Win { get; private set; }
    public string Lose { get; private set; }
    public string Tie { get; private set; }
  }
}