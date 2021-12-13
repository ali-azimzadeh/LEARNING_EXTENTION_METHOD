using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_EXTENTION_METHOD.ExtentionSample2
{
    public class Main
    {
        public void Sample()
        {
            string s = "Hello Extension Methods";
            int i = s.WordCount();

            System.Console.WriteLine("Word Count {0}", i);
        }
    }
}
