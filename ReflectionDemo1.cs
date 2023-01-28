using System;
using System.Reflection;
  
namespace Reflection_Metadata {
      
/// <summary>
/// This is a student class
/// </summary>
public class Student {
      
    // Properties definition
    public int RollNo
    {
        get;
        set;
    }
      
    public string Name
    {
        get;
        set;
    }
  
    // No Argument Constructor
    public Student()
    {
        RollNo = 0;
        Name = string.Empty; 
    }
  
    // Parameterised Constructor
    public Student(int rno, string n)
    {
        RollNo = rno;
        Name = n;
    }
  
    /// <summary>
    /// This is display data method
    /// </summary>
    public void displayData()
    {
        Console.WriteLine("Roll Number : {0}", RollNo);
        Console.WriteLine("Name : {0}", Name);
    }
    /// <summary>
    /// This is Meth1 method for testing
    /// </summary>
    /// <param name="m1">This is m1 parameter</param>
    /// <returns>Please provide data in int format</returns>
    public int Meth1(int m1){
        return 0;
    }
}
}