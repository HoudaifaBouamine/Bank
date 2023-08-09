using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_Bank
{
    public class clsTransaction
    {

        public enum enType { eDisposit, eWithdraw, eTransfer, eShowBalance }
        public clsTransaction() { }

        public DateTime datetime;
        public enType type;

        public string to = null;
    }

}
