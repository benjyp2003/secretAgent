using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secretAgent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agent agent1 = new Agent("eli chohen");
            Report report1 = new Report(4, agent1); 
            MissionControl.AnalyzeReport(report1);
            IntelTools.LogTransmission(agent1.CodeName, "capture the terrorist!");
        }
    }
}
