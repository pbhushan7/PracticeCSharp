
using System;
class HelloWorld {
  static void Main() {
    Class4 o = new Class4();
    //o.Display();
    ImplementInterface Obj = new ImplementInterface();
    Obj.Show();
    
  }
  
  public class Class1
  {
      public void Display()
      {
          Console.WriteLine("Display In Base Class");
      }
  }
  public class Class2 : Class1 {
      public void Show(){
          Console.WriteLine("Show in Derived class called");
      }
  }
  public class Class3 : Class2 {
      public void Trythis(){
          Console.WriteLine("try this in Sub-Derived class called");
      }
  }
  public class Class4 : Class1{
      public void Method1(){
          Console.WriteLine("Called method of Class 4");
      }
  }
  public interface IDisplay{
      void Display();
  }
  public interface IShow{
      void Show();
  }
  public interface IMethod1{
      void Method1();
  }
  
  public class ImplementInterface : IDisplay , IShow , IMethod1{
      public void Display(){
          Console.WriteLine("Display In Interface 1 Class");
      }
      public void Show(){
          Console.WriteLine("Show In Interface 1 Class");
      }
      public void Method1(){
          Console.WriteLine("Method In Interface 1 Class");
      }
  }
}