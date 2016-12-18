using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Error_Tracker_Final
{
    class Database
    {
        internal List<Document> documents;
        private int size;
        public string releaseDate;
        private int kloc;
        private int errorTotal;
        private float probOfAttack;
        private float probOfRepel;

        //Kloc will return kloc unless a value is being assigned to Kloc which will update the kloc variable
        internal int klocManip
        {
            get {return kloc;}
            set {kloc = value;}
        }

        //releaseDateManip will return the value of releaseDate if no assignment is being made 
        internal string releaseDateManip
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        //Error Total will return value of size if there is no assignment being made to errorTotal
        internal int errorTotalManip
        {
            get { return errorTotal; }
            set { errorTotal = value; }
        }

        //sizeManip will return value of size if there is no assignment being made to sizeManip
        internal int sizeManip
        {
            get { return size; }
            set { size = value; }
        }

        internal float probOfAttackManip
        {
            get { return probOfAttack; }
            set { probOfAttack = value; }
        }

        internal float probOfRepelManip
        {
            get { return probOfRepel; }
            set { probOfRepel = value; }
        }
    }

    public class Document
    {
        public string document;
        public string description;
        public string idNumber;
        public string name;
        public string status;
        protected internal string resolveDate;
        protected internal string reportDate;
        protected internal string releaseDate;
        public string reporter;
        public string affectedComponents;
        public string stepsToReproduce;
    }

    class Metrics : Document
    {        
        private Document documents;
        
        public float defectRemovalEfficiency(Database DB)
        {
            int errors = 0; //errors are defects caught before product release

            for (int i = 0; i < DB.sizeManip; i++)
            {
                if ((Convert.ToInt32(DB.documents[i].reportDate) / 10000) < (Convert.ToInt32(DB.releaseDate) / 10000))
                {
                    errors++;
                }
            }

            DB.errorTotalManip = errors;
            return errors / DB.sizeManip;
        }

        //correctness is calculated by defects per kloc
        public float correctness(Database DB)
        {
            int defects = DB.sizeManip - DB.errorTotalManip;
            return defects / DB.klocManip;
        }

        //calculated using the sum of the time taken to fix errors divide by the total number of errors
        public string maintainabilty(Database DB)
        {
            int sum = 0;
            float meanTime;

            for (int i = 0; i < DB.sizeManip; i++)
            {
                if ((Convert.ToInt32(DB.documents[i].resolveDate) / 10000) != -1)
                {
                    sum += (Convert.ToInt32(DB.documents[i].resolveDate) / 10000) - (Convert.ToInt32(DB.documents[i].reportDate) / 10000);
                }   
            }

            meanTime = sum / DB.sizeManip;

            //subjective determination on what is maintainable
            if (meanTime < 1)
            {
                return "Code is Highly Maintainable";

            }
            else
            {
                return "Code is not Maintainable";
            }
        }

        public float integrity(double probOfAttack, double probOfRepel)
        {
            return (1 - ((float)probOfAttack * (1 - (float)probOfRepel)));
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeWindow());
        }
    }
}