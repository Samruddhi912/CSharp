using System;
class AdditionX{
    static void Main(String[] Args){
        Console.WriteLine("Enter First Number: ");
        int iNo1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number: ");
        int iNo2=Convert.ToInt32(Console.ReadLine());
        int iRet=iNo1+iNo2;
        Console.WriteLine("Addition is :"+iRet);
    }
}