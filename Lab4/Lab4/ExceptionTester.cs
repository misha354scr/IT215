//Mike Zhukovskiy IT-215 Lab 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ExceptionTester
    {
        public static void Main(String[] args)
        {
            //1 Throw a base class exception
            try
            {
                Console.WriteLine("1) Throw a base class exception, ExceptionA");
                throw new ExceptionA();
            }
            catch (ExceptionC ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionC\n" + ex + "\n");
            }
            catch (ExceptionB ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionB\n" + ex + "\n");
            }
            catch (ExceptionA ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionA\n" + ex + "\n");
            }

            //2
            //Throw a derived class exception. Catch has only base exception class, which should
            //catch all "custom exceptions
            try
            {
                //throw derived-class ExceptionB
                Console.WriteLine("\n\n\n2) Throw a derived-class ExceptionB");
                throw new ExceptionB();
            } //end try
            catch (ExceptionA ex) 
            {
                Console.WriteLine("\n\nExceptionB caught in ExceptionA " + 
                    "catch block: \n" + ex + "\n");
            }//end catch

            /* 3
             * Throw a derived class exception. Catch it in catch block that catches derived class exception.
             */
            try
            {
                //throw derived-class ExceptionC
                Console.WriteLine("\n\n3) About to throw Exception C:");
                throw new ExceptionC("Exception C occured...");
            } //end try
            catch (ExceptionC ex) {
                Console.WriteLine("Caught by catch block that has ExceptionC\n" + ex +"\n");
            } //end catch
            catch (ExceptionB ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionB\n" + ex + "\n");
            } //end catch
            catch (ExceptionA ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionA\n" + ex + "\n");
            } //end catch


            /* 4
             * Throw a derived class exception. Catch it in Catch block
             * and then re-throw an exception to show inner exception
             */
            try 
            {
                //throw derived-cass exceptionC
                Console.WriteLine("\n\n4) InnerException. Calling method that throws Exception.");
                MethodThatThrowsException();
            }
            catch (ExceptionC ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionC\n" + ex + "\n");
            } //end catch
            catch (ExceptionB ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionB\n" + ex + "\n");
            } //end catch
            catch (ExceptionA ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionA\n" + ex + "\n");
            } //end catch
            
        } //end Main

        public static void MethodThatThrowsException() 
        {
            /* 4
             * Throw a derived class exception. Catch it in Catch block
             * and then re-throw an exception to show inner exception
             */
            try
            {
                //throw derived-cass exceptionC
                Console.WriteLine("Inside method, about to throw Exception C.");
                throw new ExceptionC("Exception C occured...");
            }
            catch (ExceptionC ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionC\n" + ex + "\n");
                throw new ExceptionC("Caught exception, re-throwing it back", ex);
            } //end catch
            catch (ExceptionB ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionB\n" + ex + "\n");
            } //end catch
            catch (ExceptionA ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionA\n" + ex + "\n");
            } //end catch
        
        }

    }
