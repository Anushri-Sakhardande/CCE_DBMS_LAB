import java.io.*;
import java.util.Scanner;

class Account{
    String AccountNumber;
    String Name;
    double balance;
    Account(String AccountNumber,String Name,double balance){
        this.AccountNumber = AccountNumber;
        this.Name = Name;
        this.balance = balance;
    }
}

class Transactions {

}

public class Bank {
    public static void main(String[] args) {
        String AccountNumber;
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter account number");
        AccountNumber = sc.nextLine();

    }
}