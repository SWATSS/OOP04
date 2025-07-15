using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced.Classes
{
    #region Q4) b) Create a derived class named Manager that overrides the Work method to print "Manager is managing".
    internal class Manager : Employee
    {
        public override string Work()
        {
            string Emp = base.Work();
            return $"* {base.Work()}\n* Manager is managing";
        }
    }
    #endregion
}
