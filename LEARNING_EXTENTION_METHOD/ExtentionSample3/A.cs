using OtherClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LEARNING_EXTENTION_METHOD.ExtentionSample3
{
    class A : IMyInterface
    {
        public void MethodB() 
        {
            Console.WriteLine("A.MethodB()"); 
        }
    }

}
