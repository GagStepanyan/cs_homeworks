/*

Task 9: Car Rental System
Task: Create a Car class with:
1. Model, Year, IsRented.
2. Methods RentCar() and ReturnCar().
3. In Main(), create a fleet of 5 cars, let users rent and return cars.
4. Prevent renting an already rented car.

*/

using System;

class Car {
    string? _carModel;
    int _carYear;
    bool _carIsRented;

    public string CarModel
    {
        get { return _carModel!; }
        set { _carModel = value; }
    }

    public int CarYear
    {
        get { return _carYear; }
        set { _carYear = value; }
    }

    public bool CarIsRented
    {
        get { return _carIsRented;}
        set { _carIsRented = value;}
    }

    public Car(string model, int year) {
        _carModel = model;
        _carYear = year;
        _carIsRented = false;
    }

    public void RentCar() {
        if (_carIsRented) {
            Console.WriteLine("the car is already rented");
            return;
        }
        _carIsRented = true;
        Console.WriteLine();
        Console.WriteLine("You rented");
        Console.WriteLine($"{_carModel} of {_carYear} year");
        Console.WriteLine();
        return;
    }

    public void ReturnCar() {
        if (!_carIsRented) {
            Console.WriteLine("you havent rented this car from us");
            return;
        }
        _carIsRented = false;
        Console.WriteLine();
        Console.WriteLine($"you have returned {_carModel} of {_carYear} year");
        Console.WriteLine("Thank you!");
        Console.WriteLine();

        return;
    }

    public void ShowInfo() {
        Console.WriteLine();
        Console.WriteLine($"Car's model: {_carModel}");
        Console.WriteLine($"Car's year: {_carYear}");
        if (_carIsRented) {
            Console.WriteLine("Availability: not available");
        } else {
            Console.WriteLine("Availability: is available");

        }
        Console.WriteLine();
        return;
    }

    public static void Run() {
        Car[] cars = new Car[5];
        cars[0] = new Car("BMW e60", 2004);
        cars[1] = new Car("BMW g30", 2024);
        cars[2] = new Car("BMW g60", 2024);
        cars[3] = new Car("BMW e90", 2015);
        cars[4] = new Car("BMW e46", 2005);

        Console.WriteLine("Welcome to Central Car Salon");
        Console.WriteLine("this is what we have");
        for (int i = 0; i < cars.Length; ++i) {
            cars[i].ShowInfo();
        }

        string? answ;
        
        while(true) {
            Console.WriteLine("Press 'r' to rent a car");
            Console.WriteLine("Press 'b' to return a car");
            Console.WriteLine("Press 'l' to see the assorty");
            Console.WriteLine("Press 'x' to exit");

            answ = Console.ReadLine();

            if (answ == "x" || answ == "X") {
                break;
            } else if (answ == "r" || answ == "R") {
                Console.WriteLine("Wich car you want to rent?");
                Console.Write("enter model's name: ");
                string? model = Console.ReadLine();
                for (int i = 0; i < cars.Length; ++i) {
                    if (cars[i].CarModel == model) {
                        cars[i].RentCar();
                        break;
                    }
                    if (i == cars.Length - 1) {
                        Console.WriteLine("We dont have such Car");
                    }
                }
            } else if (answ == "b" || answ == "B") {
                Console.WriteLine("Wich car you want to return?");
                Console.Write("enter model's name: ");
                string? model = Console.ReadLine();
                for (int i = 0; i < cars.Length; ++i) {
                    if (cars[i].CarModel == model) {
                        cars[i].ReturnCar();
                        break;
                    }
                    if (i == cars.Length - 1) {
                        Console.WriteLine("You doesnt rented such car form us");
                    }
                }
            } else if (answ == "l" || answ == "L") {
                for (int i = 0; i < cars.Length; ++i) {
                    cars[i].ShowInfo();
                }
            }
        }
    }
}


class Program {
    static void Main(string[] args) {
        Car.Run();
    }
}