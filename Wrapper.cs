public class Wrapper //Wrapper Class
{
    public class InnerClass //Inner Class
    {
        public Int32 ProcessData(int Val)
        {
            return Val + 1;
        }
    }
    public Int32 CallRapper()
    {
        Wrapper.InnerClass wpr = new Wrapper.InnerClass(); // Internally call to Wrapper class.
        return wpr.ProcessData(100);
    }
}