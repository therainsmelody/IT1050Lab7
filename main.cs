

using System;
class Program{ 

    public static double CalculateFees(int hours)
    {
      double fees = 0.0;

if (hours <= 3)
 fee = 2.00;

else if (hours >= 17)
fee = 10;

else

fee = (hours*.50) + 2 ;

return fee;
    }
    
public static void Main (string[] args) {

    Console.WriteLine("Are there anymore customers?");
    string input = Convert.ToString(Console.ReadLine()) ;

bool answer = true;
    for (input)
     {
       if (input != "no");
       {
         answer = false;
         break;
       }

     }
    if (answer) 
     {
     Console.WriteLine("Enter the hours parked:");
     int hours = Convert.ToInt32(Console.ReadLine());
     CalculateFees();
     Console.WriteLine("The charge for this customer is $" + fee);

    }
     else
     {
     Console.WriteLine("Thank you have a nice day");
  
     }       
    }  



  }
