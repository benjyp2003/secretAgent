using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secretAgent
{
    internal class Report
    {
        string Summary;
        public int UrgencyLevel;
        Agent SubmittedBy;


        public Report(int urgencyLevel, Agent submittedBy)
        {
            UrgencyLevel = urgencyLevel;
            SubmittedBy = submittedBy;
        }

    }
}
