using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@".\input.txt", Encoding.UTF8);
            var antalUpp = input.Count(p => p == '(');
            var antalNer = input.Count(p => p == ')');
            System.Console.WriteLine($"Day 1 assignment 1: Santas ending up at floor: {antalUpp - antalNer}");

            int currentFloor = 0;
            int i=0;
            for (; i < input.Length && currentFloor >=0; i++)
            {
                if(input[i] == '(') 
                    currentFloor++;
                else
                    currentFloor--;
            }
            System.Console.WriteLine($"Day 1 assigngment 2: Santas in the basement for the firsttime at postition: {i}");
            
        }
    }
}
