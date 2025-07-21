using System;
class pattern1{
    static void Main(String[] Args){
        Console.WriteLine("Enter how many times you want to print : ");
        int iNo=Convert.ToInt32(Console.ReadLine());
        for(int iCnt=0;iCnt<iNo;iCnt++){
            Console.WriteLine("*\t");
        }
    }
}