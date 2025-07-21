using System;
class switchcase{
    static void Main(String[] Args){
        Console.WriteLine("Enter one number : ");
        int iNo1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number : ");
        int iNo2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the operator on which you want to perform the calculation");
        char op=Convert.ToChar(Console.ReadLine());
        int iRes=0;
        switch(op){
            case '+':
                 iRes=iNo1+iNo2;
                break;
            
            case '-':
                 iRes=iNo1-iNo2;
                break;
            
            case '*':
                 iRes=iNo1*iNo2;
                break;
            
            case '/':
                if((iNo2)!=0){
                 iRes=iNo1/iNo2;
                }
                break;
            
            default:
                Console.WriteLine("Invalid Operator");
                break;
            

        }
        Console.WriteLine("Resulat is "+iRes);

    }
}