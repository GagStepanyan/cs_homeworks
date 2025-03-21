using System;

class Course
{
    protected string? _courseName;
    protected double _coursePrice;
    protected Module[]? _courseModules;

    public string Name
    {
        get => _courseName!;
    }

    public double Price
    {
        get => _coursePrice;
    }

    public Module[] Modules
    {
        get => _courseModules!;
    }   

    public Course(string name, double price, Module[] modules)
    {
       _courseName = name;
       _coursePrice = price;
       _courseModules = modules;
    }
    
}

class Module
{
    public string? Title { get; }
    public double Duration { get; }

    public Module(string title, double duration)
    {
        Title = title;
        Duration = duration;
    }
}

class Web : Course
{
    public string? Type { get; }

    public Web(string name, double price, string type, Module[] modules) : base(name, price, modules)
    {
        Type = type;
    }
}

class Game : Course
{
    public string? Engine { get; }

    public Game(string name, double price, string engine, Module[] modules) : base(name, price, modules)
    {
        Engine = engine;
    }
}

class AI : Course
{
    public AI(string name, double price, Module[] modules) : base(name, price, modules)
    {
    }
}

class Group
{
    public string? Name { get; }
    public int StudentCount { get; }
    public Course TheCourse { get; }
    
    public Group (string name, int count, Course course)
    {
        Name = name;
        StudentCount = count;
        TheCourse = course;
    }
}

class Program
{
    static void Main(string[] args) 
    {
        Course[] courses = new Course[]
        {
            new Web("Frontend Development", 500000, "frontend", new Module[] 
            { 
                new Module("HTML & CSS", 2), new Module("JavaScript", 3) 
            }),
            new Web("Fullstack Development", 60000, "fullstack", new Module[] 
            { 
                new Module("Node.js", 4), new Module("React", 5) 
            }),
            new AI("Machine Learning", 80000, new Module[] 
            { 
                new Module("Python for AI", 6), new Module("Deep Learning", 8) 
            }),
            new Game("Game Development", 72000, "Unity", new Module[] 
            { 
                new Module("C# for Unity", 5), new Module("Physics in Games", 4) 
            }),
            new Game("Game Dev Advanced", 42000, "Unreal", new Module[] 
            { 
                new Module("Blueprints", 6), new Module("C++ for Unreal", 7) 
            })
        };
        
        Group[] groups = new Group[]
        {
            new Group("Frontend Group 1", 15, courses[0]),   // Frontend Development
            new Group("Fullstack Group 1", 12, courses[1]),  // Fullstack Development
            new Group("AI Group 1", 10, courses[2]),         // Machine Learning
            new Group("Game Dev Group 1", 20, courses[3]),   // Unity Game Development
            new Group("Game Dev Group 2", 18, courses[4])    // Unreal Game Development
        };
    
        // Finding Web Students Count
            int webStudentCount = 0;
            foreach (var group in groups)
            {
                if (group.TheCourse is Web)
                {
                    webStudentCount += group.StudentCount;
                }
            }

            Console.WriteLine($"Web Stutend count: {webStudentCount}");

        // Finding GameDev Course's Profit
        

            double profit = 0;

            foreach (var group in groups)
            {
                if (group.TheCourse is Game)
                {
                    Game game = (Game)group.TheCourse;
                    if (game.Engine == "Unreal")
                    {
                        profit += group.StudentCount * group.TheCourse.Price;
                    }
                }
            }

            Console.WriteLine($"GameDev Course Profit: {profit}");
        
        //Finding The Most Popular Course 

            int mostPopular = 0;

            for (int i = 1; i < groups.Length; ++i)
            {
                if (groups[i].StudentCount > groups[mostPopular].StudentCount)
                {
                    mostPopular = i;
                }  
            }

        Console.WriteLine($" The Most Populare Course: {groups[mostPopular].TheCourse.Name}");
        Console.WriteLine($" The Most Populare Group: {groups[mostPopular].Name}");

    }
}