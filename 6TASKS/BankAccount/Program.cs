/*

Task 1: Bank Account System with Custom Object Comparisons
Task: Develop a BankAccount class that supports:
1. Custom String Representation (ToString() Override)
Format: "Account: [AccountNumber], Balance: [Balance] USD"
2. Equality Check (Equals() and GetHashCode())
Two accounts are equal if they have the same AccountNumber.
3. Overloaded + and - Operators for Transactions
+ should deposit money.
- should withdraw money but prevent overdraft.
4. Comparison Operators (>, <, >=, <=)
Compare accounts based on balance.

*/

using System;

class BankAccount {
    int _accountNumber;
    decimal _accountBalance;

    public int AccountNumber {
        get { return _accountNumber; }
        set { _accountNumber = value; }
    }

    public decimal AccountBalance {
        get { return _accountBalance; }
        set { _accountBalance = value; }
    }

    public BankAccount (int accountNumber, decimal accountBalance) {
        _accountNumber = accountNumber;
        _accountBalance = accountBalance;
    }

    public override string ToString () {
        return $"\nAccount number: {_accountNumber}\nAccount balance: {_accountBalance}\n";
    }

    public override bool Equals (object obj) {
        if (obj is BankAccount other) {
            return this._accountNumber == other._accountNumber;
        } else {
            return false;
        }
    }

    public override int GetHashCode () {
        return _accountNumber ^ 23;
    }

    public static BankAccount operator + (BankAccount a, decimal b) {
        a._accountBalance += b;

        return a;
    }

    public static BankAccount operator - (BankAccount a, decimal b) {
        if (a._accountBalance < b) {
            Console.WriteLine("illegal action");
            return null;
        } else {
            a._accountBalance -= b;
            return a;
        }
    }
    
    public static bool operator <(BankAccount a, BankAccount b) {
        return a._accountBalance < b._accountBalance;
    }

    public static bool operator >(BankAccount a, BankAccount b) {
        return a._accountBalance > b._accountBalance;
    }

    public static bool operator <=(BankAccount a, BankAccount b) {
        return a._accountBalance <= b._accountBalance;
    }

    public static bool operator >=(BankAccount a, BankAccount b) {
        return a._accountBalance >= b._accountBalance;
    }

}

class Program {
    static void Main (string[] args) {
        BankAccount account = new BankAccount(101,200);
        BankAccount account1 = new BankAccount(101,100);
        account -= 100;
    }
}
