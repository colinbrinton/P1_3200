using System;

namespace P1
{
    class debtStats
    {
        const sbyte LOAN_INCREASE = 1;
        const sbyte LOAN_DECREASE = -1;
        const sbyte NO_LOAN_CHNG = 0;
        const int DEBT_CAP = 100000;
        const int DEFAULT_LOAN = -1;
        const int DEFAULT_GRANT = -1;
        const int DEFAULT_MATRIC = -1;
        const int DEFAULT_GRAD = -1;
        const int DEFAULT_ID = -1;
        const int ID_MIN = 100000;
        const int ID_MAX = 1000000;
        const int MIN_LOAN = 0;
        const int MIN_GRANT = 0;
        const int MIN_DATE = 01000000;
        const int MAX_DATE = 12319999;


        private int studentID;
        public int StudentID
        {
            set
            {
                if (studentID == DEFAULT_ID)
                {
                    while (value >= ID_MAX || value < ID_MIN)
                    {
                        Console.WriteLine("Error. ID must be a six digit, positive number.");
                        Console.Write("Please reenter ID: ");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    studentID = value;
                }
                else
                    Console.WriteLine("Error. Student ID has already been set.");
            }
        }
        private int origLoan;
        public int OrigLoan
        {
            set
            {
                if (origLoan != DEFAULT_LOAN)
                    if (value >= MIN_LOAN)
                        origLoan = value;
                    else
                        Console.WriteLine("Error. Loan must be positive.");
                else
                    Console.WriteLine("Error. Original Loan value has already been set.");
            }
        }
        private int currLoan;
        public int CurrLoan
        {
            set
            {
                if (value >= MIN_LOAN)
                    currLoan = value;
                else
                    Console.WriteLine("Error. Loan must be positive.");
            }
        }
        private int origGrant;
        public int OrigGrant
        {
            set
            {
                if (value >= MIN_GRANT)
                    origGrad = value;
                else
                    Console.WriteLine("Error. Grant must be positive.");
            }
        }
        private int matriculation;
        public int Matriculation
        {
            set
            {
                if (matriculation != DEFAULT_MATRIC)
                    if (value <= MIN_DATE && value >= MAX_DATE)
                        matriculation = value;
                    else
                        Console.WriteLine("Error. Date must be in DDMMYYYY format.");
                else
                    Console.WriteLine("Error. Matriculation date has already been set.");
            }
        }
        private int anticGrad;
        public int AnticGrad
        {
            set
            {
                if (value <= MIN_DATE && value >= MAX_DATE)
                    anticGrad = value;
                else
                    Console.WriteLine("Error. Date must be in DDMMYYYY format.");
            }
        }
        private int origGrad;
        public int OrigGrad
        {
            set
            {
                if (origGrad != DEFAULT_GRAD)
                    if (value <= MIN_DATE && value >= MAX_DATE)
                        OrigGrad = value;
                    else
                        Console.WriteLine("Error. Date must be in DDMMYYYY format.");
                else
                    Console.WriteLine("Error. Original graduation date has already been set.");
            }
        }
        
        public debtStats(int id = DEFAULT_ID, int loan = DEFAULT_LOAN, int grant = DEFAULT_GRANT, 
            int matric = DEFAULT_MATRIC, int grad = DEFAULT_GRAD)
        {
            studentID = id;
            origLoan = loan;
            origGrant = grant;
            matriculation = matric;
            origGrad = grad;
            currLoan = origLoan;
            anticGrad = origGrad;
        }

       /*void generateID()
        {
           Random rndID = new Random();
           studentID = rndID.Next(ID_MIN, ID_MAX);
        }*/

        public bool gradExten()
        {
            if (anticGrad > origGrad)
                return true;
            return false;
        }
        public int loanChange()
        {
            if (currLoan > origLoan)
                return LOAN_INCREASE;
            if (currLoan < origLoan)
                return LOAN_DECREASE;
            return NO_LOAN_CHNG;
        } 

        public void deactivate()
        {
            studentID = DEFAULT_ID;
            origLoan = DEFAULT_LOAN;
            currLoan = DEFAULT_LOAN;
            origGrant = DEFAULT_GRANT;
            matriculation = DEFAULT_MATRIC;
            anticGrad = DEFAULT_GRAD;
            origGrad = DEFAULT_GRAD;
        }

        public bool debtExceed()
        {
            if (currLoan > DEBT_CAP)
                return true;
            return false;
        }

    }
}
