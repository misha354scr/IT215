using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ExceptionB : ExceptionA
    {
        public ExceptionB()
            : base("Exception thrown by Exception Class ExceptionB")
        {
            //empty body
        }

        public ExceptionB(string msg)
            : base(msg)
        {
            //empty body
        }

        public ExceptionB(string msg, Exception inner)
            : base(msg, inner)
        {
            //empty body
        }
    } //end ExceptionA

