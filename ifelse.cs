using System;
class ifelse{
    static void Main(String[] Args){
        Console.WriteLine("What is your Age");
        int iAge=Convert.ToInt32(Console.ReadLine());
        if(iAge<18){
            Console.WriteLine("Your are not an adult");
        }
        else{
            Console.WriteLine("Your are an adult");

        }
    }
}