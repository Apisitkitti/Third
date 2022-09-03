using System;
public class Program_3
{
   public static void Main(String[] args)
    {
        string NUm_input = Pow_num();
        int Num_num = StringchangetoInt(NUm_input);
        Console.WriteLine(Pow_timewe(Num_num));

        

    }
    public static string Pow_num ()
    {
        Console.Write("Pls input your pow number: ");
        return Console.ReadLine();

    }
    public static int StringchangetoInt(string Value)
    {
        if(int.TryParse(Value,out int Num_changer))
        {
            return Num_changer;
        }
        throw new Exception("Input again");
    }
    public static int Pow_timewe(int num)
    {   
        if(Pow_Check(num))
        {
            num--;
          return 2*Pow_timewe(num);
        }
        else return 1;      
    }   
    public  static bool Pow_Check(int check)
    {
        return check > 0; 
    }
    public static bool Pow_Check_1(int check)
    {
        return check == 1;
    }
    
   
        
    
   
  
    
    

}
    