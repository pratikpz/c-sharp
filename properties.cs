using System;
public class BankAccount{
    public string AccountNumber{get;set;}
    public string OwnerName{get;set;}
    int Balance{get;set;}
    
    public BankAccount(){}
    public BankAccount(string accNum,string ownName,int Blnc){
       AccountNumber=accNum;
        OwnerName=ownName;
        Balance=Blnc;
    }
    
    public void Deposit(int amt){
        this.Balance+=amt;
    }
    
    public void Withdraw(int amt){
        if(this.Balance<amt){
            Console.WriteLine("Sorry Note enough cash!!");
        }
        else{
            this.Balance-=amt;
        }
    }
    
    public void DisplayAccountInfo(){
        Console.WriteLine("Account Number :  "+ this.AccountNumber +
        "  Owner name :  "+ this.OwnerName +
        "  Current Balance :  "+this.Balance);
    }
    
    public static void Main(string[] args){
     
      BankAccount b= new BankAccount("1122","Pratik Parajuli",10000);
       b.Withdraw(5000);
       b.DisplayAccountInfo();
       b.Deposit(9000);
       b.DisplayAccountInfo();  
    }
}
