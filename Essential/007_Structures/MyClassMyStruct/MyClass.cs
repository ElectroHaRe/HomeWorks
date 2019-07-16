using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassMyStruct
{
    class MyClass
    {
        public MyClass()
        {

        }

        public MyClass(string change_text)
        {
            change = change_text;
        }

        public string change = "не изменено";
    }
}
