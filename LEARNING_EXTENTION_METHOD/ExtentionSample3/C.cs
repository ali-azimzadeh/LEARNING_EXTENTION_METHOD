using OtherClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_EXTENTION_METHOD.ExtentionSample3
{
    class C : IMyInterface
    {
        public void MethodB()
        {
            Console.WriteLine("C.MethodB()"); 
        }
        public void MethodA(object obj)
        {
            Console.WriteLine("C.MethodA(object obj)");
        }
    }
}
