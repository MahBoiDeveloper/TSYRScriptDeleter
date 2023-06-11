using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rampastring.Tools;

namespace ScriptDeleter
{
    class Program
    {
        static void Main(string[] args)
        {
            IniFile map = new IniFile(args.First());

            Console.WriteLine("Trying to open [" + args.First() + "] map.");
            Console.WriteLine("Deleting [Triggers]...");
            map.EraseSectionKeys("Triggers");
            map.RemoveSection("Triggers");
            Console.WriteLine("Deleting [Events]...");
            map.EraseSectionKeys("Events");
            map.RemoveSection("Events");
            Console.WriteLine("Deleting [Tags]...");
            map.EraseSectionKeys("Tags");
            map.RemoveSection("Tags");
            Console.WriteLine("Deleting [Actions]...");
            map.EraseSectionKeys("Actions");
            map.RemoveSection("Actions");
            Console.WriteLine("Deleting [AITriggerTypesEnable]...");
            map.EraseSectionKeys("AITriggerTypesEnable");
            map.RemoveSection("AITriggerTypesEnable");
            Console.WriteLine("All script-related sections in [" + args.First() + "] has been deleted.");

            map.WriteIniFile();
        }
    }
}
