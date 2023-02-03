namespace DotnetTraining
{
    public class JumpStatements{
        public void BreakExp(){
            for(int i=0;i<10;i++){
                if(i==5){
                    break;
                }
                Console.WriteLine(i);
                
            }
        }
        public void ContinueExp(){
            for(int i=0;i<10;i++){
                if(i==5){
                    continue;
                }
                Console.WriteLine(i);
                
            }
        }
    }
    
}