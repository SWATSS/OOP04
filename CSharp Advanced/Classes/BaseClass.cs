using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Classes
{
    #region Q5) a) Create a base class BaseClass with a virtual method DisplayMessage that prints  "Message from BaseClass".
    internal class BaseClass
    {
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }
    } 
    #endregion
}
