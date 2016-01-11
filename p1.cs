using System;

namespace P1
{
    class debtStatsDriver
    {
        const int COUNT_START = 0;
        const int COUNT_OFFSET = 1;
        const int MAX_NUM_STU = 5;
        const int MIN_NUM_STU = 1;
        const int ID_MIN = 100000;
        const int ID_MAX = 1000000;
        const int MIN_DATE = 18000100;
        const int MAX_DATE = 30001231;
        const int MAX_GRAD = 30000000;
        const int MIN_GRAD = 20160000;
        const int MIN_MATR = 18000000;
        const int MAX_MATR = 20150000;
        const int MAX_MONTH = 1200;
        const int MIN_MONTH = 100;
        const int MAX_DAY = 31;
        const int MIN_DAY = 1;
        const int YEAR_MOD = 100000000;
        const int MONTH_MOD = 10000;
        const int DAY_MOD = 100;
        const int MIN_MONEY = 1;
        const int MAX_MONEY = 100000;

        static Random rnd = new Random();

        static void Main()
        {
            debtStats[] studentDebts;
            int[] testStuIDs;
            Console.Write("Please enter the number of students you wish to manage: ");
            debtStatsDriver functions = new debtStatsDriver();
            int numStudents = functions.randomNumStu();
            Console.Write(numStudents);
            //numStudents = randomNumStu();
            studentDebts = new debtStats[numStudents];
            testStuIDs = new int[numStudents];
            Console.WriteLine();

            Console.Write("Please enter the debt threshold: $");
            int debtThresh = randomMoney();
            int tempMoney = randomMoney();
            studentDebts[COUNT_START] = new debtStats();
            studentDebts[COUNT_START].DebtCap = tempMoney;
            Console.Write(tempMoney);

            int studentCount = new int(); 
            studentCount = COUNT_START;
            Console.WriteLine();

            foreach (debtStats element in studentDebts)
            {
                Console.WriteLine();
                studentDebts[studentCount] = new debtStats();

                Console.Write("Enter the student ID for student ");
                Console.Write(studentCount + COUNT_OFFSET);
                Console.Write(": ");
                int tempID = functions.generateID();
                studentDebts[studentCount].StudentID = tempID;
                Console.Write(tempID);
                Console.WriteLine();
                testStuIDs[studentCount] = tempID;

                Console.Write("Enter the matriculation date for student ");
                Console.Write(studentCount + COUNT_OFFSET);
                Console.Write(" (YYYYMMDD): ");
                int tempMatr = randomMatr();
                studentDebts[studentCount].Matriculation = tempMatr;
                Console.Write(tempMatr);
                Console.WriteLine();

                Console.Write("Enter the anticipated graduation date for student ");
                Console.Write(studentCount + COUNT_OFFSET);
                Console.Write(" (YYYYMMDD): ");
                int tempGrad = randomGrad();
                studentDebts[studentCount].OrigGrad = tempGrad;
                Console.Write(tempGrad);
                Console.WriteLine();

                Console.Write("Enter the loan amount for student ");
                Console.Write(studentCount + COUNT_OFFSET);
                Console.Write(": $");
                int tempLoan = randomMoney();
                studentDebts[studentCount].OrigLoan = tempLoan;
                Console.Write(tempLoan);
                Console.WriteLine();

                Console.Write("Enter the grant amount for student ");
                Console.Write(studentCount + COUNT_OFFSET);
                Console.Write(": $");
                int tempGrant = randomMoney();
                studentDebts[studentCount].OrigGrant = tempGrant;
                Console.Write(tempGrant);
                Console.WriteLine();

               ++studentCount;

            }

            Console.WriteLine();
            Console.WriteLine("Please enter the ID of the student whose loan amount you with to update: ");
            //int tempID = Convert.ToInt32(Console.ReadLine());
            studentCount = COUNT_START;

            //if (studentDebts[studentCount].idMatch(tempID))

            Console.ReadKey();

        }

        public int randomNumStu()
        {
            return rnd.Next(MIN_NUM_STU, MAX_NUM_STU);
        }

        public int generateID()
       {
          return rnd.Next(ID_MIN, ID_MAX);
       }

        public static int randomGrad()
        {
            int tempYear = rnd.Next(MIN_GRAD, MAX_GRAD);
            tempYear -= tempYear % MONTH_MOD;
            //Console.WriteLine(tempYear);
            int tempMonth = rnd.Next(MIN_MONTH, MAX_MONTH);
            tempMonth -= tempMonth % DAY_MOD;
            // Console.WriteLine(tempMonth);
            int tempDay = rnd.Next(MIN_DAY, MAX_DAY);
            int tempGrd = tempYear + tempMonth + tempDay;
            return tempGrd;
        }

        public static int randomMatr()
        {
            int tempYear = rnd.Next(MIN_MATR, MAX_MATR);
            tempYear -= tempYear % MONTH_MOD;
            //Console.WriteLine(tempYear);
            int tempMonth = rnd.Next(MIN_MONTH, MAX_MONTH);
            tempMonth -= tempMonth % DAY_MOD;
           // Console.WriteLine(tempMonth);
            int tempDay = rnd.Next(MIN_DAY, MAX_DAY);
            int tempMtr = tempYear + tempMonth + tempDay;
            return tempMtr;
        }

        public static int randomMoney()
        {
            return rnd.Next(MIN_MONEY, MAX_MONEY);
        }

    }


}
