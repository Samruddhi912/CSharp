using System;
class whileLoop{
    static void Main(String[] Arg){
        Console.WriteLine("How many iterations you want");
        int iNum=Convert.ToInt32(Console.ReadLine());
        while(iNum<=30){
            Console.WriteLine("Lavdya");
            iNum++;
        }
    }
}