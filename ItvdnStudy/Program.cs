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
            Row row = new Row
            {
                Description = "Code complete. Steve McConnel.",
                Quantity = 1,
                Price = 100
            };
            invoice.Table.AddRow(row);
            row = new Row
            {
                Description = "CLR via C#. Jeffrey Richter.",
                Quantity = 3,
                Price = 80
            };
            invoice.Table.AddRow(row);

            string stringTitle = $"Дата: {invoice.Date}. \nНомер накладной: {invoice.Number}. " +
               $"Кому:{invoice.To} От кого:{invoice.From}";
            Console.WriteLine(stringTitle);
            for (int i = 0; i < invoice.Table.Size; i++)
            {
                row = invoice.Table.GetRow(i);
                string stringTable = $"{row.SequentialNumber} | {row.Description} | " +
                   $"{row.Quantity} шт. | {row.Price} руб. | {row.Amount} руб.";
                Console.WriteLine(stringTable);
            }
            Console.WriteLine($"Всего: {invoice.Total} руб.") ;
            string stringFooter = $"Кладовщик:{invoice.StorekeeperSurname}  \nЭкспедитор:{invoice.ForwarderSurname}";

            Console.WriteLine(stringFooter);



            Console.Read();

        }
    }
}
