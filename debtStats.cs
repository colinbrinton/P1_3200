using System;

namespace P1
{
    class debtStats
    {
        const sbyte LOAN_INCREASE = 1;
        const sbyte LOAN_DECREASE = -1;
        const sbyte NO_LOAN_CHNG = 0;
        const int DEBT_CAP = 100000;
        const int DEFAULT_LOAN = 0;
        const int DEFAULT_GRANT = 0;
        const int DEFAULT_MATRIC = 0;
        const int DEFAULT_GRAD = 0;
        const int DEFAULT_ID = 000000;
        //const int ID_MIN = 100000;
        //const int ID_MAX = 1000000;


        private int studentID;
        public int StudentID
        {
            set
            {
                studentID = value;
            }
        }
        int origLoan;
        int currLoan;
        public int CurrLoan
        {
            set
            {
                currLoan = value;
            }
        }
        int origGrant;
        int matriculation;
        int anticGrad;
        int origGrad;
        
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

        }

        public bool debtExceed()
        {
            if (currLoan > DEBT_CAP)
                return true;
            return false;
        }

    }
}
