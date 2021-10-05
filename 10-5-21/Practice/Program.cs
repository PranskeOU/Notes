using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two parallel arrays. The first will hold student IDs and the second will hold their overall GPA. Ask the user for one of the IDs that they want to see the GPA for and then output it.
            int[] studentIds = { 1, 2, 3 };
            double[] GPAs = new double[3];
            GPAs[0] = 2.5;
            GPAs[1] = 3.5;
            GPAs[2] = 4.0;

            Console.WriteLine("Which student do you want to see the GPA of? >>");
            int studentID = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < studentIds.Length; i++)
            {
                int id = studentIds[i];
                double gpa = GPAs[i];
                
                if (id == studentID)
                {
                    Console.WriteLine($"Student {studentID}'s GPA is {gpa.ToString("N")}");
                }
            }
        } 
    }
}
