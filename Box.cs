//********** https://www.csharpstar.com/star-pattern-programs-in-csharp/
namespace StarPatterns{
    public class Box{
        public void DisplaySquare(int leg = 10){
            for (int i = 0; i < leg; i++)
            {
                for (int j = 0; j < leg; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        public void DisplayRectangle(int h = 10,int w= 5){
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}