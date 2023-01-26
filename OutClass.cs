using System;
  
class OutClass {
  
    // Main Method
    public void Main1()
    {
  
        // Assign string value
        string str = "Geek";
  
        // Pass as a reference parameter
        SetValue(ref str);
  
        // Display the given string
        Console.WriteLine(str);
    }
  
    void SetValue(ref string str1)
    {
  
        // Check parameter value
        if (str1 == "Geek") {
            Console.WriteLine("Hello!!Geek");
        }
  
        // Assign the new value
        // of the parameter
        str1 = "GeeksforGeeks";
    }
}