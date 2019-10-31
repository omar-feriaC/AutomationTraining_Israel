using Automation_Course_.Test_Cases;
using Automation_Course_.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Course_
{
    class Program
    {
        private static int a = 5, b = 10, c = 20;

        static void Main(string[] args)
        {

            API_Test objAPI = new API_Test();
            Console.WriteLine("Please Enter an input value");
            string strValue = Console.ReadLine();
            objAPI.InvokeService(strValue);


            /*ReflectionExample example = new ReflectionExample();

            // Get methods.
            MethodInfo[] methods = typeof(ReflectionExample).GetMethods();
            foreach (MethodInfo info in methods)
            {
                Console.WriteLine(info.Name);
                // Call Win method.
                if (info.Name == "Win")
                {
                    info.Invoke(example, null);
                }
            }*/



            /*libExcel objxl = new libExcel();
            objxl.FilePath = @"C:\Tools\DataDriven.xlsx";
            objxl.ReadAllExcel("Data1");*/

            /*********************************************************************************
             * Reflection Example: this code set an initial value to 3 int variables, then ask
             * to select one variable and change its value
             *********************************************************************************/
            /*Console.WriteLine("a + b + c = " + (a + b + c));
            Console.WriteLine("Please enter the name of the variable that you wish to change:");
            string varName = Console.ReadLine();
            Type t = typeof(Program);
            FieldInfo fieldInfo = t.GetField(varName, BindingFlags.NonPublic | BindingFlags.Static);
            if (fieldInfo != null)
            {
                Console.WriteLine("The current value of " + fieldInfo.Name + " is " + 
                                  fieldInfo.GetValue(null) + ". You may enter a new value now:");
                string newValue = Console.ReadLine();
                int newInt;
                if (int.TryParse(newValue, out newInt))
                {
                    fieldInfo.SetValue(null, newInt);
                    Console.WriteLine("a + b + c = " + (a + b + c));
                }
            }*/


            /*Type t = typeof(string);

            // Use Reflection to find about 
            // any sort of data related to t 
            Console.WriteLine("Name : {0}", t.Name);
            Console.WriteLine("Full Name : {0}", t.FullName);
            Console.WriteLine("Namespace : {0}", t.Namespace);
            Console.WriteLine("Base Type : {0}", t.BaseType);
            Console.WriteLine("Attributes : {0}", t.Attributes);*/



            Console.ReadKey();

        }
    }
}
