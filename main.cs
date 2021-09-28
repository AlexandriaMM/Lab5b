using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter the number of cars");
    int counter = Convert.ToInt32(Console.ReadLine());
    int totalSpeed = 0;
    
    for (int i = 1; i <= counter; i++) {
      Console.WriteLine("Enter the distance covered by Car #" + i);
      int distance = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Enter the time taken by Car #" + i);
      int time = Convert.ToInt32(Console.ReadLine());
      
      int speed = distance / time;
      Console.WriteLine("The speed of this car is " + speed + " miles per hour");
      
      totalSpeed = totalSpeed + speed;
    }
    
    int averageSpeed = totalSpeed / counter;
    Console.WriteLine("The average speed of the cars is " + averageSpeed);
  }
}