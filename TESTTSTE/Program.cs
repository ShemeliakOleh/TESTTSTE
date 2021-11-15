using System;
using MathWorks.MATLAB.NET.Arrays;
namespace TESTTSTE
{
    class Program
    {
        static void Main(string[] args)
        {
            LibForChMMF.LibForChMMF libclass = new LibForChMMF.LibForChMMF();
            try
            {
                var s = libclass.Draw("C:\\Source\\Triangle.NET\\FEMSolver\\bin\\Debug\\net5.0\\Test1.txt");

            }
            catch (Exception)
            {

               
            }
            
            Console.ReadKey();
        }
    }
}
