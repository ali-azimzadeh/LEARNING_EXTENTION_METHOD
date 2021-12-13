using OtherClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_EXTENTION_METHOD.ExtentionSample3
{
    class B : IMyInterface
    {
        public void MethodB()
        {
            Console.WriteLine("B.MethodB()"); 
        }
        public void MethodA(int i) 
        {
            Console.WriteLine("B.MethodA(int i)"); 
        }
    }
}
