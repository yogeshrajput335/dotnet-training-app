using Reflection_Metadata;
// See https://aka.ms/new-console-template for more information
// Dog d = new Dog();
// d.animalSound();
// d.run();

// Cat c = new Cat();
// c.animalSound();
// c.run();

//Animal a = new  Animal(); //Cannot create an instance of the abstract type or interface 'Animal'

// using System.Reflection;
// using Reflection_Demo;

// Rat r = new Rat();
// r.animalSound();
// r.sleep();
// r.run();

// RefClass r = new RefClass();
// r.Main1();

// OutClass o = new OutClass();
// o.Main1();

// Par p = new Par();
// p.p();
// Console.ReadLine();

// ReflectionDemo r1 = new ReflectionDemo();
// r1.Method1();

// Assembly executing = Assembly.GetExecutingAssembly();
// Type[] types = executing.GetTypes();


// foreach(var item in types)
// {
//     // Display each type
//     Console.WriteLine("Class : {0}", item.Name);

//     // Array to store methods
//     MethodInfo[] methods = item.GetMethods();
//     foreach(var method in methods)
//     {
//         // Display each method
//         Console.WriteLine("--> Method : {0}", method.Name);

//         // Array to store parameters
//         ParameterInfo[] parameters = method.GetParameters();
//         foreach(var arg in parameters)
//         {
//             // Display each parameter
//             Console.WriteLine("----> Parameter : {0} Type : {1}",
//                                     arg.Name, arg.ParameterType);
//         }
//     }
// }
    
// Wrapper w = new Wrapper();
// w.CallRapper();

// Wrapper.InnerClass  i = new Wrapper.InnerClass();
// i.ProcessData(100);

Student s = new Student();
s.Meth1(100);
