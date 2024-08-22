using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_demo
{
    internal interface IApply
    {       
        public int ApplicationId { get; set; }
        string ApplyChequeBook();
        string ApplyATMCard();
        string ApplyPINChange();
        void TakeBackup();
    }
}
