using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace secretAgent
{
    internal class Agent
    {
        public string CodeName;
        int ClearanceLevel;

        public Agent(string codeName)
        {
            CodeName = codeName;
        }

        int GetClearanceLevel()
        {
            return ClearanceLevel;
        }

        void SetClearanceLevel(int level)
        {
            if (level > 5 || level < 1)
            {
                Console.WriteLine("level can be between 1-5.");
            }
            else
            { ClearanceLevel = level; }

            void Report()
            {
                Console.WriteLine($"Agent {CodeName} reporting. \n" +
                                  $"clearance level: {ClearanceLevel}");
            }
        }
    }
}
