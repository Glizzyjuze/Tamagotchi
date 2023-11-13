public class Tamagotchi
{
    private int hunger = 5;
    private int boredom = 5;
    private List<string> words;
    private bool isAlive;
    public string name;
    public void Feed(int foodAmount)
    {

    }
    public void Hi()
    {

    }
    public void Teach(string word)
    {

    }
    public void Tick()
    {

    }
    public void Printstats()
    {
        Console.WriteLine($@"
        {name} 
        Hunger: {hunger}
        Boredom: {boredom}");
    }
    public bool GetAlive()
    {
        return true;
    }
    private void ReduceBoredom()
    {
        
    }
}