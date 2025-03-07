/*

    3D Vector Class with Overloaded Operators
Task: Create a Vector3D class representing a three-dimensional vector. Implement the following:
1. Override ToString()
Format: "(X, Y, Z)"
2. Overload Arithmetic Operators
+ to add vectors.
- to subtract vectors.
* to multiply by a scalar.
/ to divide by a scalar (handle division by zero).
3. Overload Equality Operators (==, !=)
Two vectors are equal if all components are equal.
4. Implement Equals() and GetHashCode() Consistently
5. Overload true and false Operators
A vector is "true" if it's non-zero, otherwise "false".
6. Overload >, <, >=, <= Based on Magnitude

*/

using System;

class Vector3D {
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Vector3D(double x, double y, double z) {
        X = x;
        Y = y;
        Z = z;
    }

    public override string ToString() {
        return $"X = {X}\nY = {Y}\nZ = {Z}\n";
    }


    public static Vector3D operator +(Vector3D v1, Vector3D v2) {
        return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }

    public static Vector3D operator -(Vector3D v1, Vector3D v2) {
        return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z); 
    }

    public static Vector3D operator *(Vector3D v1, double scalar) {
        return new Vector3D(v1.X * scalar, v1.Y * scalar, v1.Z * scalar); 
    }

    public static Vector3D operator *(double scalar, Vector3D v1) {
        return v1 * scalar;
    }

    public static Vector3D operator /(Vector3D v1, double scalar) {
        if (scalar == 0) {
            Console.WriteLine("Dividing to 0 is illegal");
            return null;
        }

        return new Vector3D(v1.X / scalar, v1.Y / scalar, v1.Z / scalar);
    }

    public static bool operator ==(Vector3D v1, Vector3D v2) {
        if (ReferenceEquals(v1, v2)) {
            return true;
        }

        if (v1 is null || v2 is null) {
            return false;
        }

        return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z;
    }

    public static bool operator !=(Vector3D v1, Vector3D v2) {
        return !(v1 == v2);
    }

    public override bool Equals(object obj) {
        if (obj is Vector3D other) {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode() {
        return HashCode.Combine(X, Y, X);
    }

    public static bool operator true(Vector3D v1) {
        return v1.X != 0 && v1.Y != 0 && v1.Z != 0;
    }
    
    public static bool operator false(Vector3D v1) {
        return v1.X == 0 && v1.Y == 0 && v1.Z == 0;
    }

    public double Magnitude() {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    public static bool operator >(Vector3D v1,Vector3D v2) {
        return v1.Magnitude() > v2.Magnitude();
    }

    public static bool operator <(Vector3D v1,Vector3D v2) {
        return v1.Magnitude() < v2.Magnitude();
    }

    public static bool operator >=(Vector3D v1, Vector3D v2) {
        return v1.Magnitude() >= v2.Magnitude();
    }

    public static bool operator <=(Vector3D v1, Vector3D v2) {
        return v1.Magnitude() <= v2.Magnitude();
    }
}   

class Program {
    public static void Main(string[] args)
    {
        Vector3D v1 = new Vector3D(1, 2, 3);
        Vector3D v2 = new Vector3D(4, 5, 6);
        Vector3D v3 = new Vector3D(1, 2, 3);
        Vector3D v4 = new Vector3D(0, 0, 0);

        Console.WriteLine($"v1: {v1}");
        Console.WriteLine($"v2: {v2}");

        Console.WriteLine($"v1 + v2: {v1 + v2}");
        Console.WriteLine($"v2 - v1: {v2 - v1}");
        Console.WriteLine($"v1 * 2: {v1 * 2}");
        Console.WriteLine($"3 * v1: {3 * v1}");
        Console.WriteLine($"v2 / 2: {v2 / 2}");

        Console.WriteLine($"v1 == v3: {v1 == v3}");
        Console.WriteLine($"v1 == v2: {v1 == v2}");
        Console.WriteLine($"v1 != v2: {v1 != v2}");

        Console.WriteLine($"v1.Equals(v3): {v1.Equals(v3)}");
        Console.WriteLine($"v1.Equals(v2): {v1.Equals(v2)}");

        Console.WriteLine($"if (v1): {v1}");
        Console.WriteLine($"if (v4): {v4}");

        Console.WriteLine($"v1 > v2 : {v1 > v2}");
        Console.WriteLine($"v1 < v2 : {v1 < v2}");
        Console.WriteLine($"v1 >= v3 : {v1 >= v3}");
        Console.WriteLine($"v1 <= v3 : {v1 <= v3}");

    
    }
}

