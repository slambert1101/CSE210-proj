public abstract class Animal
{

    protected string name;
    protected string sound;

    //protected means only child class can access constructor vvv
    protected Animal(string name, string sound)
    {
        this.name = name;
        this.sound = sound;
    }
    public virtual void MakeSound()
    {
        Console.WriteLine("**Ominous Silence**");
    }


}