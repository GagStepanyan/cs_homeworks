/*

Implement a BigInt Class in C#
Task: Implement a custom BigInt class in C# to handle arbitrarily large integers using strings or arrays.
Class Definition:
Create a BigInt class with an appropriate private field (e.g., a string) to store large numbers.
Constructors:
A constructor that takes a string as input and initializes the BigInt object.
A constructor that takes an int for small numbers.
Properties:
A Length property that returns the number of digits in the BigInt.
Overloaded Operators:
Implement +, -, *, and ==, !=, <, >, <=, >= for BigInt objects.
Ensure the subtraction operator works correctly for positive and negative results.
Implement multiplication without directly converting to int or long.
Methods:
ToString(): Converts the BigInt object into a string
Abs(): Returns the absolute value of the BigInt.
CompareTo(BigInt other): Compare two BigInt objects.

*/
using System;
using System.Text;
class BigInt {

    string? _bigIntNumber;
    public string BigIntNumber { get => _bigIntNumber!; }
    public BigInt(string? number) {
        _bigIntNumber = number;
    }

    public BigInt(int number) {
        _bigIntNumber = number.ToString();
    }

    public int bigIntLength => _bigIntNumber!.StartsWith("-") ? _bigIntNumber.Length - 1 : _bigIntNumber.Length;

    public static BigInt operator +(BigInt bigInt1, BigInt bigInt2) => new BigInt(AddStrings(bigInt1._bigIntNumber!, bigInt2._bigIntNumber!));
    public static string AddStrings(string bigInt1, string bigInt2) {
        
        if (string.IsNullOrEmpty(bigInt1)) { return bigInt2; }
        if (string.IsNullOrEmpty(bigInt2)) { return bigInt1; }      

        int maxLength = Math.Max(bigInt1.Length, bigInt2.Length);
        bigInt1 = bigInt1.PadLeft(maxLength, '0');
        bigInt2 = bigInt2.PadLeft(maxLength, '0');

        StringBuilder result = new StringBuilder();
        int carry = 0;

        for (int i = maxLength - 1; i >= 0; --i) {
            int num1 = bigInt1[i] - '0';
            int num2 = bigInt2[i] - '0';
            int sum = num1 + num2 + carry;
            result.Insert(0, sum % 10);
            carry = sum / 10;
        }

        if (carry > 0) {
            result.Insert(0, carry);
        } 

        string finalResult = result.ToString().TrimStart('0');
        
        return string.IsNullOrEmpty(finalResult) ? "0" : finalResult;
    }

    
    public static BigInt operator -(BigInt bigInt1, BigInt bigInt2) => new BigInt(SubstractStrings(bigInt1._bigIntNumber!, bigInt2._bigIntNumber!));
    public static string SubstractStrings(string bigInt1, string bigInt2) {
        if (string.IsNullOrEmpty(bigInt1)) { return "-" + bigInt2; }
        if (string.IsNullOrEmpty(bigInt2)) { return bigInt1; }
        if (bigInt1 == bigInt2) { return "0"; }

    static bool IsLessThan(string num1, string num2) {
            if (num1.Length != num2.Length)
            {
                return num1.Length < num2.Length;
            }

            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] != num2[i])
                {
                    return num1[i] < num2[i];
                }
            }

            return false;
    }

        bool negativeRes = false;

        if (IsLessThan(bigInt1, bigInt2)) {
            (bigInt1, bigInt2) = (bigInt2, bigInt1);
            negativeRes = true;
        }

        StringBuilder result = new StringBuilder();
        int len1 = bigInt1.Length;
        int len2 = bigInt2.Length;
        int borrow = 0;

        bigInt2 = bigInt2.PadLeft(len1, '0');

        for (int i = len1 -1; i >= 0; --i) {
            int num1 = bigInt1[i] - '0';
            int num2 = bigInt2[i] - '0';
            int diff = num1 - num2 - borrow;

            if (diff < 0) {
                diff += 10;
                borrow = 1;
            } else {
                borrow = 0;
            }

            result.Insert(0,diff);
        }

        string finalResult = result.ToString().TrimStart('0');

        if (string.IsNullOrEmpty(finalResult)) {
            return "0";
        }

        return negativeRes ? "-" + finalResult : finalResult;

    }

    public static BigInt operator *(BigInt bigInt1, BigInt bigInt2) => new BigInt(MultiplyStrings(bigInt1._bigIntNumber!, bigInt2._bigIntNumber!));
    public static string MultiplyStrings(string bigInt1, string bigInt2) {
        
        if (string.IsNullOrEmpty(bigInt1) || string.IsNullOrEmpty(bigInt2) || bigInt1 == "0" || bigInt2 == "0") {
            return "0";
        } 

        int len1 = bigInt1.Length;
        int len2 = bigInt2.Length;
        int[] result = new int[len1 + len2];

        for (int i = len1 - 1; i >= 0; --i) {
            int num1 = bigInt1[i] - '0';
            for (int j = len2 - 1; j >= 0; --j) {
                int num2 = bigInt2[j] - '0';
                result[i + j + 1] += num1 * num2;
            }
        }

        int carry = 0;
        for (int i = result.Length - 1; i >= 0; --i) {
            int sum = result[i] + carry;
            result[i] = sum % 10;
            carry = sum / 10;
        }

        StringBuilder sbResult = new StringBuilder();

        for (int i = 0; i < result.Length; ++i) {
            sbResult.Append(result[i]);
        }

        string finalResult = sbResult.ToString().TrimStart('0');
        return string.IsNullOrEmpty(finalResult) ? "0" : finalResult;
    }

    
    public static bool operator ==(BigInt bigInt1, BigInt bigInt2) => bigInt1._bigIntNumber == bigInt2._bigIntNumber;
    public static bool operator !=(BigInt bigInt1, BigInt bigInt2) => bigInt1._bigIntNumber != bigInt2._bigIntNumber;
    public static bool operator <(BigInt bigInt1, BigInt bigInt2) => string.Compare(bigInt1._bigIntNumber, bigInt2._bigIntNumber) < 0;
    public static bool operator >(BigInt bigInt1, BigInt bigInt2) => string.Compare(bigInt1._bigIntNumber, bigInt2._bigIntNumber) > 0;
    public static bool operator <=(BigInt bigInt1, BigInt bigInt2) => string.Compare(bigInt1._bigIntNumber, bigInt2._bigIntNumber) <= 0;
    public static bool operator >=(BigInt bigInt1, BigInt bigInt2) => string.Compare(bigInt1._bigIntNumber, bigInt2._bigIntNumber) >= 0;

    public override string ToString() => _bigIntNumber!;
    public BigInt Abs() => _bigIntNumber!.StartsWith("-") ? new BigInt(_bigIntNumber.Substring(1)) : this;
    public string CompareTo(BigInt other) {
        if (this == other) {
            return "Numbers are Equal";
        }
            return this > other ? "First number is greater" : "Second number is greater";
    }
        public override bool Equals(object? bigInt) {
            if (bigInt == null || !(bigInt is BigInt)) {
                return false;
            }

            BigInt other = (BigInt)bigInt;
            return this._bigIntNumber == other._bigIntNumber;
        }

        public override int GetHashCode() {
            return _bigIntNumber!.GetHashCode();
        }
    }

    class Program{
        static void Main() {
            BigInt bigInt1 = new BigInt("9");
            BigInt bigInt2 = new BigInt("5");
            Console.WriteLine($"bigInt1's Length: {bigInt1.bigIntLength}");
            Console.WriteLine($"bigInt1 + bigInt2 = {bigInt1 + bigInt2}");
            Console.WriteLine($"bigInt1 - bigInt2 = {bigInt1 - bigInt2}");
            Console.WriteLine($"bigInt1 * bigInt2 = {bigInt1 * bigInt2}");
            Console.WriteLine($"bigInt1 == bigInt2 = {bigInt1 == bigInt2}");
            Console.WriteLine($"bigInt1 != bigInt2 = {bigInt1 != bigInt2}");
            Console.WriteLine($"bigInt1 > bigInt2 = {bigInt1 > bigInt2}");
            Console.WriteLine($"bigInt1 < bigInt2 = {bigInt1 < bigInt2}");
            Console.WriteLine($"bigInt1 >= bigInt2 = {bigInt1 >= bigInt2}");
            Console.WriteLine($"bigInt1 <= bigInt2 = {bigInt1 <= bigInt2}");
            Console.WriteLine($"bigInt1.ToString() = {bigInt1.ToString()}");
            Console.WriteLine($"bigInt1.Abs() = {bigInt1.Abs()}");
            Console.WriteLine($"bigInt1.CompareTo(bigInt2) = {bigInt1.CompareTo(bigInt2)}");


        }
    }
