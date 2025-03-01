/*

Task 4: Weather Forecast System
Task: Create a class WeatherReport with:
1. Fields: temperature, humidity, and weatherCondition.
2. In Main(), create an array of WeatherReport objects for different cities and display the reports.

*/

class WeatherReport {

    string? _reportCity;
    string? _reportTemperature;
    string? _reportHumidity;
    string? _reportWeatherCondition;

    public string City {
        get { return _reportCity!; }
        set {_reportCity = value; }
    }

    public string Temperature {
        get { return _reportTemperature!; }
        set {_reportTemperature = value; } 
    }

    public string Humidity {
        get { return _reportHumidity!; }
        set {_reportHumidity = value; }
    }

    public string WeatherCondition {
        get {return _reportWeatherCondition!; }
        set { _reportWeatherCondition = value; }
    }

    public WeatherReport(string city, string temperature, string humidity, string weatherCondition) {
        _reportCity = city;
        _reportTemperature = temperature;
        _reportHumidity = humidity;
        _reportWeatherCondition = weatherCondition;
    }

    public void DisplayInfo() {
        Console.WriteLine($"\nIn City {_reportCity}\nThe temperature is {_reportTemperature} celsius\nThe humidity is {_reportHumidity}%\nThe Weather Condition: {_reportWeatherCondition}\n");
        return ;
    }

}

class Program {
    public static void Main(String[] args) {   
        WeatherReport[] reports = new WeatherReport[4];

        reports[0] = new WeatherReport("Yerevan", "-10", "54", "Mostly Cloudy");
        reports[1] = new WeatherReport("Dilijan", "-15", "75",  "Snowing");
        reports[2] = new WeatherReport("Barcelona", "+17", "77", "Cloudy");
        reports[3] = new WeatherReport("Los Angeles", "+20", "85", "Sunny");

        for (int i = 0; i < reports.Length; ++i) {
            reports[i].DisplayInfo();   
        }

        
    }
}