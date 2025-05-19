using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secretAgent
{
    internal static class IntelTools
    {
        public static string EncryptMessage(string msg)
        {
            char[] revMsg = msg.ToCharArray();
            Array.Reverse(revMsg);
            return new string(revMsg);
        }
        
        public static void LogTransmission(string agentName, string message)
        {
            Console.WriteLine($"{agentName} sent encrypted message: {IntelTools.EncryptMessage(message)}");
        }
    }
}
