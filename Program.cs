using Python.Runtime;
using System;

namespace PythonNet
{
    internal class Program
    {
       
        static void Main(string[] args) //set project platform target to x64
        {
            RunScript("pyscript"); //remember to right click properties for the .py file, Copy to Output folder -> Always

            void RunScript(string scriptname)
            {
                string pythonDLL = @"C:\Users\Orange\AppData\Local\Programs\Python\Python312\Python312.dll"; //where the python dll is located
                Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", pythonDLL);
                PythonEngine.Initialize();
                using (Py.GIL())
                {
                    var pythonScript = Py.Import(scriptname);
                    var message = new PyString("Test Message");
                    // var func = pythonScript.InvokeMethod("return_message", new PyObject[] { message });
                    // Console.WriteLine(func);
                    pythonScript.InvokeMethod("convert");
                }
            }
        }
    }
}






