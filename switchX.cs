using System;
class switchX{
    static void Main(String[] Args){
        Console.WriteLine("Enter one number of your choice");
        int iNo=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the operation you want to see on that number(EG: Odd,Even etc)");
        string iChoice=Console.ReadLine();
        //int iRes=0;
        int iDigit=0;
        int iSum=0;
        switch(iChoice){
            case "Even":
            if(iNo%2==0){
                Console.WriteLine("Number is Even number");
                
            }
            else{
                Console.WriteLine("Number is not Even number");

            }
            break;
            case "Odd":
            if(iNo%2!=0){
                Console.WriteLine("Number is Odd number");
                
            }
            else{
                Console.WriteLine("Number is not Odd number");

            }
            break;
            case "Reverse":
            while(iNo!=0){
                iDigit=iNo%10;
                Console.WriteLine(iDigit);
                iNo=iNo/10;
            }
            break;
            case "Addition":
            while(iNo!=0){
               
                iDigit=iNo%10;
                iSum+=iDigit;
                iNo=iNo/10;
            }
            Console.WriteLine("Sum is "+iSum);
            break;
            default:
            Console.WriteLine("No such method Defined Yet!");
            break;
            

        }
        
    }
}