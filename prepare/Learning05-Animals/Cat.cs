using System; 

public class Cat : Animal, IFeline
{
    public override string GetSound()
    {
        return "meow";
    }

    public void Scratch()
    {

    }

    public void Furr()
    {
        
    }
}