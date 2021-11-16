using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItvdnStudy.Resources.Invoice
{
    class Invoice
    {
        // Title
        public DateTime Date { get; set; }
        public string Number { get; set; } = null;
        public string To { get; set; } = null;
        public string From { get; set; } = null;
        // Body
        public Table Table { get; } = new Table();
        //Footer
        public decimal Total { get=>Table.Total; }
        public string StorekeeperSurname { get; set; } = null;
        public string ForwarderSurname { get; set; } = null;
    }
    class Table
    {
        Row[] rows = new Row[0];
        public int Size => rows.Length;
        public decimal Total { get; private set; }
        public void AddRow(Row row)
        {
            Array.Resize(ref rows, rows.Length + 1);
            rows[rows.Length - 1] = row;
            row.SequentialNumber = rows.Length;
            Total = +row.Amount;
        }
        public Row GetRow(int index) => rows[index];
    }
    class Row
    {
        /// <summary>
        /// 
        /// </summary>
        public int SequentialNumber { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount
        {
            get => Quantity * Price;
        }
    }

}