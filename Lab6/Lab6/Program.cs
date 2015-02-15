//Mike Zhukovskiy
//IT 215 Spring 2015
//Lab 6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyException : Exception
{
    public MyException()
        : base("My Exception")
    {
        //empty body
    }

    public MyException(string msg)
        : base(msg)
    {
        //empty body
    }

    public MyException(string msg, Exception inner)
        : base(msg, inner)
    {
        //empty body
    }
}

public class ClassWithNestedMethods
{

    public static void MethodA()
    {
        MethodB();
    }

    public static void MethodB()
    {
        MethodC();
    }

    public static void MethodC()
    {
        MethodD();
    }

    public static void MethodD()
    {
        MethodE();
    }

    public static void MethodE()
    {
        MethodF();
    }

    public static void MethodF()
    {
        MethodG();
    }

    public static void MethodG()
    {
        MethodH();
    }

    public static void MethodH()
    {
        throw new MyException("Custom Exception throw from MethodH");
    }


    public static void Main(string[] args)
    {
        try
        {
            MethodA();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message + "\n");
            Console.WriteLine(ex.StackTrace);
        }
    }
}
