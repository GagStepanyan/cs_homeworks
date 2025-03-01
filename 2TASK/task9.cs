/*

Task 9: Finding the Longest Word in a Sentence
Task: Ask the user for a sentence and use a loop to determine the longest word.

*/
using System;

 Class Program {
 
    static void Main(string[] args) {
             Console.WriteLine("enter words");
             string conversation = Console.ReadLine();
             string[] words = conversation.Split(new char[]{' ','\n','\t',',',':',';'});
             int maxlen = 0;
             string longestword = " ";
             foreach (string word in words)
             {
                 if (word.Length > maxlen)
                 {
                     maxlen = word.Length;
                     longestword = word;
                 }
             }
             Console.WriteLine($"the longest word is {longestword} and lenght is {maxlen}");
    }
}