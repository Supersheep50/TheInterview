public abstract class Player
{
    public string Title { get; set; }
    public string Health { get; set; }

    public int Typing { get; set; }

    public int ProblemSolving { get; set; }

    public int Smugness { get; set; }

    public int Interviewing { get; set; }

    public int Admin { get; set; }

    public int Grit { get; set; }

    
    public abstract void Attack(); 

}