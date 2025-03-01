/*

Task 3: Bank Account
Task: Create a BankAccount class with:
1. AccountNumber, HolderName, Balance.
2. Methods Deposit(amount) and Withdraw(amount), ensuring balance never goes negative.
3. In Main(), allow the user to create an account and perform deposits/withdrawals.
4. Prevent withdrawal if insufficient funds and show an error message.

*/

using System;

class BankAccount {

//static instance count for sequential IDs;
     static int _instanceCount = 0;
     string? _accountNumber;
     string? _accountHolderName;
     int _accountBalance;

    public BankAccount(string holderName)
    {   
        ++_instanceCount;
        _accountHolderName = holderName;
        
        // allow uniq sequential IDs
        
        if (_instanceCount < 10) {
            _accountNumber = $"000{_instanceCount}";
        } else if (_instanceCount < 100) {
        _accountNumber = $"00{_instanceCount}";
        } else if (_instanceCount < 1000) {
            _accountNumber = $"0{_instanceCount}";
        } else {
            _accountNumber = $"{_instanceCount}";
        } 
        _accountBalance = 0;

    }

    ~BankAccount() 
    {
        _instanceCount--;
        Console.WriteLine("Instance finalized. Count: " + _instanceCount);
    }

    public void Deposit() {
        Console.WriteLine("How much of a deposit are you looking to make?");
        int cash = Convert.ToInt32(Console.ReadLine());
        _accountBalance += cash;
        Console.WriteLine($"Dear {_accountHolderName}, the Deposit was done succesfully!\n");
    }

    public void Withdrawal() {
        Console.WriteLine("How much are you looking to take out?");
        int cash = Convert.ToInt32(Console.ReadLine());
        if (_accountBalance - cash < 0) {
            Console.WriteLine("Insufficient Funds...\n");
            return;
        } else {
            _accountBalance -= cash;
            Console.WriteLine($"Withrawd: ${cash}\n");
        }
    }

    public void ShowInfo() {
        Console.WriteLine($"Name:{_accountHolderName}\nID:{_accountNumber}\nBalance: ${_accountBalance}\n");
        Console.WriteLine("");
    }
    
    public static void Run() {
        Console.WriteLine("WELCOME TO OUR BANK!\n");
        Console.Write("please enter your name: ");
        BankAccount bankAccount = new BankAccount(Console.ReadLine()!);
        Console.WriteLine();

            while (true) {
                Console.WriteLine("Press 'D' to make a deposite\nPress 'W' to do a withrawal\nPress 'L' to show info about your account\nPress 'X' to exit\n");
                string? answ = Console.ReadLine();
                if (answ == "d" || answ == "D") {
                    bankAccount.Deposit();
                } else if (answ == "w" || answ == "W") {
                    bankAccount.Withdrawal();
                } else if (answ == "l" || answ == "L") {
                    bankAccount.ShowInfo();
                } else if (answ == "X" || answ == "x") {
                    break;
                } else {
                    Console.WriteLine("invalid command, try again");
                }
            }
    }
}

class Program {
    public static void Main(String[] args) {
        BankAccount.Run();

    
    }
}