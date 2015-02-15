using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ExceptionA : Exception
    {
        public  ExceptionA() : base("Exception thrown by Exception Class ExceptionA")
        {
            //empty body
        }

        public ExceptionA(string msg) : base(msg) 
        {
            //empty body
        }

        public ExceptionA(string msg, Exception inner) : base(msg, inner)
        {
            //empty body
        }
    } //end ExceptionA

