using System;
using ItvdnStudy.Resources.Invoice;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItvdnStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Invoice invoice = new Invoice();    
            //invoice.Date= DateTime.Parse("17/11/2021 20:00");
            //invoice.Number = "1";
            //invoice.From = "Издательство";
            //invoice.To = "Магазин";
            //invoice.StorekeeperSurname = "Иванов";
            //invoice.ForwarderSurname = "Петров";

            Invoice invoice = new Invoice
            {
                Date = DateTime.Parse("17/11/2021 20:00"),
                Number = "1",
                From = "Издательство",
                To = "Магазин",
                StorekeeperSurname = "Иванов",
                ForwarderSurname = "Петров"
            };


        

           
            Console.Read();
 
        }
    }
}
