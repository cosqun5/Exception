using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Task.Utilites.Exceptions
{
    public class MyExcepition:Exception
    {
        public MyExcepition(string message):base(message)
        {
            
        }
    }
}
