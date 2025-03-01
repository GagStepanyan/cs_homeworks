/*

Task 7: Fitness Tracker System
Task: Create a class WorkoutSession with:
1. Fields: exerciseType and durationInMinutes.
2. Add a method ShowWorkoutDetails().
3. In Main(), create and display different workout sessions.

*/
using System;

class WorkoutSession {
    string? _sessionExerciseType;
    double _sessionDurationInMinutes;


    public WorkoutSession(string type) {
        _sessionExerciseType = type;
        _sessionDurationInMinutes = 0;
    }

    public void Workout(double minutes) {
        if (minutes < 0) {
            Console.WriteLine("invalid input");
            return;
        }
        _sessionDurationInMinutes += minutes;
    }

    public void ShowWorkoutDetails() {
        Console.WriteLine();
        Console.WriteLine($"Exercise type: {_sessionExerciseType}");
        Console.WriteLine($"Duration in minutes: {_sessionDurationInMinutes}");
        Console.WriteLine();
    }

}

class Program {
    static void Main(string[] args) {  
        WorkoutSession[] session = new WorkoutSession[3];
        session[0] = new WorkoutSession("Push-Ups");
        session[1] = new WorkoutSession("Plank");
        session[2] = new WorkoutSession("Deadlifts");

        session[0].Workout(30);
        session[1].Workout(15);
        session[2].Workout(20);
        session[0].Workout(30);
        for (int i = 0; i < session.Length; ++i) {
            session[i].ShowWorkoutDetails();
        }
    }
}