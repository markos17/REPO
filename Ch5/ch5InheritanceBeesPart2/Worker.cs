using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5InheritanceBeesPart2
{
    class Worker : Bee
    {
        public Worker(string[] jobsICanDo, double weightMg) : base(weightMg)
        {
            this.jobsICanDo = jobsICanDo;
        }
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        private string currentJob = "";
        private int shiftLefts;

        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        public int ShiftLefts
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        public override double HoneyConsumptionRate()
        {
            return base.HoneyConsumptionRate() + .65 * shiftsWorked;
        }

        public bool DoThisJob(string job, int shiftsToWork)
        {
            bool canWork = false;
            if (string.IsNullOrEmpty(currentJob))
            {
                foreach (string jobIcanDo in jobsICanDo)
                {
                    if (jobIcanDo == job)
                    {
                        this.shiftsToWork = shiftsToWork;
                        currentJob = job;
                        shiftsWorked = 0;
                        //   canWork = true;
                        return canWork = true;
                    }
                }
            }
            return canWork;
        }

        public bool DidYouFinish()
        {
            if (string.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsToWork = 0;
                shiftsWorked = 0;
                currentJob = "";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
