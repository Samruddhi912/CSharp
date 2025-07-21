using System;
class whileX{
    static void Main(String[] Args){
        int iCnt=0;
        Console.WriteLine("Enter Number of your Choice:");
        int iNo=Convert.ToInt32(Console.ReadLine());
        while(iNo!=0){
            iCnt=iNo%10;
            Console.WriteLine(iCnt);
            iNo=iNo/10;

        }
    }
}