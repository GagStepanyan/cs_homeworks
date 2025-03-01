/*

Task 10: To-Do List Application
Task: Create a TaskItem class with:
1. Description, IsCompleted.
2. Methods MarkComplete() and MarkIncomplete().
3. Store multiple tasks in a list and allow users to add, remove, or mark tasks as complete.

*/

using System;
using System.Collections.Generic;

class TaskItem {
    string? _taskDescription;
    bool _taskIsCompleted;

    public string TaskDescription {
        get { return _taskDescription; }
        set { _taskDescription = value; }
    }

    public bool TaskIsCompleted {
        get { return _taskIsCompleted; }
        set { _taskIsCompleted = value; }
    }

    public TaskItem(string taskDescription) {
        _taskDescription = taskDescription;
        _taskIsCompleted = false;
    }

    public void MarkComplete() {
        if (!_taskIsCompleted) {
            _taskIsCompleted = true;
            Console.WriteLine();
            Console.WriteLine("marked as completed");
            Console.WriteLine();
        } else {
            Console.WriteLine("task was already marked as completed");
        }
    }

    public void MarkIncomplete() {
        if (_taskIsCompleted) {
            _taskIsCompleted = false;
            Console.WriteLine();
            Console.WriteLine("marked as incompleted");
            Console.WriteLine();
        } else {
            Console.WriteLine("task is already marked as incompleted");
        }
    }

    public void ShowInfo() {
        Console.WriteLine();
        Console.WriteLine("Task Description: ");
        Console.WriteLine($"{_taskDescription}");
        if (_taskIsCompleted) {
            Console.WriteLine("Task status: Is Completed");
        } else {
            Console.WriteLine("Task status: Is Incompleted");
        }
        Console.WriteLine();
    }
}

class TaskManager {
    List <TaskItem> _managerTasks;
    int _managerTaskCount;

    public TaskManager() {
        _managerTasks = new List<TaskItem>();
        _managerTaskCount = 0;
    }

    public void AddTask() {
        Console.WriteLine();
        Console.WriteLine("enter a description: ");
        string? desc = Console.ReadLine();
        _managerTasks.Add(new TaskItem(desc!));
        ++_managerTaskCount;
    }
    public void RemoveTask() {
        Console.WriteLine();
        Console.WriteLine("enter task's description to delete");
        string? desc = Console.ReadLine();

        for (int i = 0; i < _managerTaskCount; ++i) {
            if (_managerTasks[i].TaskDescription == desc) {
                _managerTasks.Remove(_managerTasks[i]);
                --_managerTaskCount;
                break;
            }

            if (i == _managerTaskCount - 1) {
                Console.WriteLine("there is no such task");
                return;
            }
        } 
    }

    public void MarkCompleteInList() {
        Console.WriteLine("enter the description");
        string? description = Console.ReadLine();
        for (int i = 0; i < _managerTaskCount; ++i) {
            if (_managerTasks[i].TaskDescription == description) {
                _managerTasks[i].MarkComplete();
                break;
            }

            if (i == _managerTaskCount - 1) {
                Console.WriteLine("there is no such task");
            }
        }
    }

    public void MarkInCompleteInList() {
        Console.WriteLine("enter the description");
        string? description = Console.ReadLine();
        for (int i = 0; i < _managerTaskCount; ++i) {
            if (_managerTasks[i].TaskDescription == description) {
                _managerTasks[i].MarkIncomplete();
                break;
            }

            if (i == _managerTaskCount - 1) {
                Console.WriteLine("there is no such task");
            }
        }
    }


    public void ShowList() {
        for (int i = 0; i < _managerTaskCount; ++i) {
            _managerTasks[i].ShowInfo();
        }
    }

    public static void Run() {
        TaskManager manager = new TaskManager();
        string? answ;
        while (true) {
            Console.WriteLine();
            Console.WriteLine("Enter '+' to add a task");
            Console.WriteLine("Enter '-' to add a task");
            Console.WriteLine("Enter 'C' to mark a task as completed");
            Console.WriteLine("Enter 'I' to mark a task as incomleted");
            Console.WriteLine("Enter 'L' to show all Tasks");
            Console.WriteLine("Enter 'X' to exit");
            answ = Console.ReadLine();
            if (answ == "x" || answ == "X") {
                break;
            } else if (answ == "+") {
                manager.AddTask();
            } else if (answ == "-") {
                manager.RemoveTask();
            } else if (answ == "c" || answ == "C") {
                manager.MarkCompleteInList();
            } else if (answ == "i" || answ == "I") {
                manager.MarkInCompleteInList();
            } else if (answ == "l" || answ == "L") {
                manager.ShowList();
            } else {
                Console.WriteLine("invalid command, try again");
            }
        }
    }

}


class Program {

    static void Main(string[] args) {
        TaskManager.Run();

        Console.WriteLine("GoodBye!");
 
    }

}