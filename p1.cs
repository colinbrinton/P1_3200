using System;

namespace P1
{
    class debtStatsDriver
    {
        const int COUNT_START = 0;
        const int COUNT_OFFSET = 1;
        static void Main()
        {
            debtStats[] studentDebts;
            Console.Write("Please enter the number of students you wish to manage: ");
            int numStudents = Convert.ToInt32(Console.ReadLine());
            studentDebts = new debtStats[numStudents];

            int studentCount = new int(); 
            studentCount = COUNT_START;

            foreach (debtStats element in studentDebts)
            {
                studentDebts[studentCount] = new debtStats();
                Console.Write("Enter the student ID for student ");
                Console.Write(studentCount + COUNT_OFFSET);
                Console.Write(": ");
                studentDebts[studentCount].StudentID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the matriculation date for student ");
                Console.Write(studentCount + COUNT_OFFSET);
                Console.Write(" (DDMMYYY): ");
                studentDebts[studentCount].Matriculation = Convert.ToInt32(Console.ReadLine());


               ++studentCount;
            }

        }
    }
}
