//**********
namespace StarPatterns{
    public class Line{
        public void Display(int leg = 10){
            for (int i = 0; i < leg; i++)
            {
                Console.Write("*");
            }
        }
        public void DisplayVertical(int leg = 10){
            for (int i = 0; i < leg; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}