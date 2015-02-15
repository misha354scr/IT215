using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Lab1
    {
        static void Main(string[] args)
        {
            //declare an array
            Invoice[] invoices = {new Invoice(83, "Electric sander", 7, 57.98M), 
                                  new Invoice(24, "Power saw", 18, 99.99M), 
                                  new Invoice(7, "Sledge hammer", 11, 21.5M), 
                                  new Invoice(77, "Hammer", 76, 11.99M), 
                                  new Invoice(39, "Lawn mower", 3, 79.5M), 
                                  new Invoice(68, "Screwdriver", 106, 6.99M), 
                                  new Invoice(56, "Jig saw", 21, 11M), 
                             	  new Invoice(3, "Wrench", 34, 7.5M)
                                 };

            //First query
            Console.WriteLine("a) Sorted by description:\n");
            var filteredInvoices = from invoice in invoices
                                   orderby invoice.PartDescription
                                   select invoice;

            foreach (var invoice in filteredInvoices)
                Console.WriteLine(invoice);

            Console.WriteLine();

            //Second query
            Console.WriteLine("b) Sorted by price:\n");
            filteredInvoices = from invoice in invoices
                                   orderby invoice.Price
                                   select invoice;

            foreach (var invoice in filteredInvoices)
                Console.WriteLine(invoice);

            Console.WriteLine();

            //Third query
            Console.WriteLine("c) Description and quantity, sort by quantity:\n");
            var filtered3 =    from invoice in invoices
                               orderby invoice.Quantity
                               select new { invoice.PartDescription, invoice.Quantity };

            foreach (var invoice in filtered3)
                Console.WriteLine(invoice);

            Console.WriteLine();

            //Fourth query
            Console.WriteLine("d) Description and invoice total, sort by invoice total:\n");
            var filtered4 = from invoice in invoices
                            let total = invoice.Quantity * invoice.Price
                            orderby total
                            select new { invoice.PartDescription, InvoiceTotal = total };

            foreach (var invoice in filtered4)
                Console.WriteLine(invoice);
            Console.WriteLine();

            //Fifth query
            Console.WriteLine("e) Invoice totals between $200.00 and $500.00:\n");
            var filtered5 = from invoice in filtered4
                            where invoice.InvoiceTotal >= 200M && invoice.InvoiceTotal <= 500M
                            orderby invoice.InvoiceTotal
                            select new { invoice.PartDescription, invoice.InvoiceTotal };

            foreach (var invoice in filtered5)
                Console.WriteLine(invoice);


        }
    }
}
