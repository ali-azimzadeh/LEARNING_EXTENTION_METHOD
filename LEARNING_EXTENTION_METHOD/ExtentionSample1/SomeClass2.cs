using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_EXTENTION_METHOD
{
    static class SomeClass2 : Object
    {
        static SomeClass2()
        {
        }

        /// <summary>
        /// باشد static کلاسی که بصورت پارامتر ورودی در متد تعریف می شود نباید از نوع 
        ///باشد static به کلاس دیگری اضافه شود باید بصورت  extention متدی که قرار است به صورت 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="name"></param>
        public static void SomeMethod2(this SomeClass1 obj, string name)
        {
            System.Console.WriteLine("Name : {0}", name);
        }
    }
}
