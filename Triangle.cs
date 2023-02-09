//**********
namespace StarPatterns{
    public class Triangle{
        public void Display(int leg = 10){
            for (int i = 0; i < leg; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}