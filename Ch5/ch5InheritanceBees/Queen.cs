using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5InheritanceBees
{
    class Queen
    {
        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        private Worker[] workers;
        private int shiftNumber;

        public bool AssignWork(string job, int shiftNumbers)
        {
            bool isFree = false;
            foreach (Worker worker in workers)
            {
                //   if (worker.ShiftLefts == 0 && string.IsNullOrEmpty(worker.CurrentJob))
                if (worker.DoThisJob(job, shiftNumbers))
                    isFree = true;
            }

            return isFree;
        }

        public string WorkTheNextShift()
        {
            shiftNumber++;
            string report = "Report for shift #" + shiftNumber + "\r\n";

            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                    report += "Worker #" + (i + 1) + " finished the job \r\n";
                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + (i + 1) + " is not working \r\n";
                else
                {
                    if (workers[i].ShiftLefts > 0)
                        report += "Worker #" + (i + 1) + " is doing ‘" + workers[i].CurrentJob
                    + " for " + workers[i].ShiftLefts + " more shifts\r\n";
                    else
                        report += "Worker #" + (i + 1) + " will be done with ‘"
                        + workers[i].CurrentJob + "’ after this shift\r\n";
                }
            }
            return report;

        }
    }
}
