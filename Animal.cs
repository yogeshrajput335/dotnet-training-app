public abstract class Animal{
    public abstract void animalSound();
    public void sleep() 
    {
        Console.WriteLine("Zzz");
    }
    public virtual void run(){
        Console.WriteLine("Animal is running");
    }
}