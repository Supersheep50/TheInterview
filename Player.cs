public abstract class Player
{
    public string Title { get; set; }
    public string Health { get; set; }

    public int Typing { get; set; }

    public int ProblemSolving { get; set; }

    public int Smugness { get; set; }
    public abstract void Attack(); 

}