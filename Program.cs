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

            Console.WriteLine("Trying to open" + args.First());
            Console.WriteLine("Deleting all key in [Triggers]");
            map.EraseSectionKeys("Triggers");
            map.RemoveSection("Triggers");
            Console.WriteLine("Deleting all key in [Events]");
            map.EraseSectionKeys("Events");
            map.RemoveSection("Events");
            Console.WriteLine("Deleting all key in [Tags]");
            map.EraseSectionKeys("Tags");
            map.RemoveSection("Tags");
            Console.WriteLine("Deleting all key in [Actions]");
            map.EraseSectionKeys("Actions");
            map.RemoveSection("Actions");
            Console.WriteLine("Deleting all key in [AITriggerTypesEnable]");
            map.EraseSectionKeys("AITriggerTypesEnable");
            map.RemoveSection("AITriggerTypesEnable");

            map.WriteIniFile();
        }
    }
}
