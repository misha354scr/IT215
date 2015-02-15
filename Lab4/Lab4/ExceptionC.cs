using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ExceptionC : ExceptionB
    {
        public ExceptionC()
            : base("Exception thrown by Exception Class ExceptionC")
        {
            //empty body
        }

        public ExceptionC(string msg)
            : base(msg)
        {
            //empty body
        }

        public ExceptionC(string msg, Exception inner)
            : base(msg, inner)
        {
            //empty body
        }
    } //end ExceptionA

