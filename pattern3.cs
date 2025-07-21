using System;
class pattern{
    static void Main(String[] Arg){
        Console.WriteLine("Enter how many stars you want in row");
        int iRow=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter how many stars you want in column");
        int iCol=Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<iRow;i++){
            for(int j=0;j<=i;j++){
            Console.Write("*\t");
            
            }
            Console.WriteLine();
            
        }
    }
}