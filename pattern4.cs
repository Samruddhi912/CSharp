using System;
class pattern4{
    static void Main(String[] Args){
        Console.WriteLine("Enter number of rows: ");
        int iRow=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of columns: ");
        int iCol=Convert.ToInt32(Console.ReadLine());
        for(int i=iRow;i>=0;i--){
            for(int j=0;j<=i;j++){
                Console.Write("*\t");
            }
            Console.WriteLine();
        }

    }
}