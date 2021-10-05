﻿using System;
using System.Collections.Generic;

namespace Dictionary_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> studentRecords = new Dictionary<int, double>();
            studentRecords.Add(1, 2.5);
            studentRecords.Add(2, 3.5);
            studentRecords.Add(3, 4.0);

            foreach (int id in studentRecords.Keys)
            {
                Console.WriteLine(id);
            }
            Console.WriteLine();
            string answer;
            do
            {
                Console.WriteLine("Do you want to add another student to our records? yes or no >>");
                answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    Console.WriteLine("What is the ID? >>");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the GPA? >>");
                    double gpa = Convert.ToDouble(Console.ReadLine());

                    if (studentRecords.ContainsKey(id) == true)
                    {
                        studentRecords[id] = gpa;
                    }
                    else
                    {
                        Console.WriteLine("That student already exists. We updated the GPA.");
                        studentRecords.Add(id, gpa);
                    }
                }
            } while (true);

            Console.WriteLine("Which student do you want to see the GPA of? >>");
            int studentID = Convert.ToInt32(Console.ReadLine());

            if (studentRecords.ContainsKey(studentID) == true)
            {
                Console.WriteLine($"Student {studentID}'s GPA is {studentRecords[studentID].ToString("N")}");
            }
            else
            {
                Console.WriteLine($"The student with the ID '{studentID}' was not found.");
            }
        }
    }
}
