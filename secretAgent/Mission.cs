using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secretAgent
{
    internal class Mission
    {
        string MissionName;
        string TargetLocation;
        Agent AssignedAgent;


        public Mission(string missionName, string targetLocation) 
        {
            MissionName = missionName;
            TargetLocation = targetLocation;
        }

        public void AssignAgent(string codeName)
        {
            AssignedAgent = new Agent(codeName);
        }


        public void Brief()
        {
            Console.WriteLine($"Mission: {MissionName} \n" +
                              $"Target: {TargetLocation} \n" +
                              $"Agent: {AssignedAgent.CodeName}");
        }
    }
}
