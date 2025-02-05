using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask_AQA.Data
{
    public static class GlobalConfigs
    {
        public static string Browser { get; set; }
        public static string BaseUrl { get; set; }
        public static void ReadConfigs()
        {
            if (TestContext.Parameters.Count == 0)
            {
                Console.WriteLine("test.runsettings file is empty");
            }
            else
            {
                foreach (var name in TestContext.Parameters.Names)
                {
                    SetConfig(name);
                }
            }
        }

        private static void SetConfig(string parameter)
        {
            string value = TestContext.Parameters.Get(parameter);
            switch (parameter)
            {
                case nameof(Browser):
                    Browser = value;
                    break;
                case nameof(BaseUrl):
                    BaseUrl = value;
                    break;
                default:
                    throw new Exception("Not valid parameter: " + parameter);
            }
        }
    }
}
