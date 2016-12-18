using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Error_Tracker_Final
{
    public class Database
    {
        internal Document[] documents;
        private string releaseDate;
        private int kloc;
        private int errorTotal;


        //Kloc will return kloc unless a value is being assigned to Kloc which will update the kloc variable
        internal int klocManip
        {
            get { return kloc; }
            set { kloc = value; }
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

        public Database()
        {
            releaseDate = "";
            documents = null;
            kloc = 0;
            errorTotal = 0;
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
        public string reporter;
        public string affectedComponents;
        public string stepsToReproduce;
    }

    class Metrics
    {
        public float defectRemovalEfficiency(Database DB)
        {
            int errors = 0; //errors are defects caught before product release

            for (int i = 0; i < DB.documents.Length; i++)
            {
                if (Convert.ToDateTime(DB.documents[i].reportDate).Date < Convert.ToDateTime(DB.releaseDateManip).Date)
                {
                    errors++;
                }
            }

            return (float)errors / (float)DB.documents.Length;
        }

        //correctness is calculated by defects per kloc
        public float correctness(Database DB)
        {
            return (float)DB.documents.Length / (float)DB.klocManip;
        }

        //calculated using the sum of the time taken to fix errors divide by the total number of errors
        public float meanTimetoFix(Database DB)
        {
            int sum = 0;
            float meanTime = 0;

            for (int i = 0; i < DB.documents.Length; i++)
            {
                if (DB.documents[i].status == "Resolved")
                {
                    sum += (Convert.ToDateTime(DB.documents[i].resolveDate).Date - Convert.ToDateTime(DB.documents[i].reportDate).Date).Days;
                }
            }

            meanTime = (float)sum / (float)DB.documents.Length;

            return meanTime;
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