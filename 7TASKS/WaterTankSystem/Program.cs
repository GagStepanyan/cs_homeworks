/*

Task 1: Water Tank System
Concept: Simulate water tanks where water can be transferred or consumed.
Requirements
Implement a WaterTank class:
1. Capacity (double, liters)
2. CurrentLevel (double, liters)
3. Overload + operator: Combine two water tanks (capped at the capacity limit).
4. Overload - operator: Consume water from the tank (cannot go below 0).
5. Override ToString() to display tank levels.

*/

using System;

class WaterTank {
    double _tankCapacity;
    double _tankCurrentLevel;

    public WaterTank(double currentLevel = 0) {
        _tankCapacity = 1000;
        if (currentLevel < 0 || currentLevel > _tankCapacity) {
            throw new ArgumentException("invalid argument");
        }
        _tankCurrentLevel = currentLevel;

    }

    //allowing user to add water directly
    public void AddWater(double liters) {
        if (_tankCurrentLevel + liters > _tankCapacity) {
            Console.WriteLine("there is no enough space");
            return;
        } else {
            _tankCurrentLevel += liters;
        }
    }



    public static WaterTank operator +(WaterTank tank1, WaterTank tank2) => new WaterTank(AddCurrents(tank1, tank2));
    public static double AddCurrents(WaterTank tank1, WaterTank tank2) {
        if (tank1._tankCurrentLevel + tank2._tankCurrentLevel > tank1._tankCapacity) {
            Console.WriteLine("not enaugh capacity");
            return -1;
        }
        return tank1._tankCurrentLevel + tank2._tankCurrentLevel;
    }

    public static WaterTank operator -(WaterTank tank1, double liters) => new WaterTank(SubCurrents(tank1, liters));
    public static double SubCurrents(WaterTank tank1, double liters) {
        if (tank1._tankCurrentLevel - liters < 0) {
            Console.WriteLine("goin below zero");
            return -1;
        }

        return (tank1._tankCurrentLevel - liters);
    }


    public override string ToString() {
        return $"{_tankCurrentLevel}/{_tankCapacity}";
    }

    public void Display() {
        Console.WriteLine(this.ToString());
    }
}

class Program {
    static void Main(string[] args) {
        WaterTank tank1 = new WaterTank(900);
        WaterTank tank2 = new WaterTank(250);
        
        WaterTank res = tank1 - 100;
        res.Display();
        
        res = tank1 - tank2;
        res.Display();

        Cosnole.Write("Water Tank1: ");
        tank1.Display();
        
        Cosnole.Write("Water Tank2: ");
        tank2.Display();


    }
}