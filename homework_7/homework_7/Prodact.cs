using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7
{
    public class Prodact
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Code { get; set; }
        public byte Categoty_ID { get; set; }
        public byte Quantity { get; set; }
        public string Measuring { get; set; }
        public DateTime? Expiration { get; set; }
        public string Valute { get; set; }

    }
    public class ProdactCategory
    {
        public byte Id { get; set; }
        public string Name { get; set; }

    }
}
